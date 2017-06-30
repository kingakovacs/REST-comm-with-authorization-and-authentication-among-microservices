// load express module
var express = require('express');

//load body-parser
var bodyParser = require('body-parser');
    
//load oauth server
var oauthserver = require('oauth2-server');

//load mongoose module
var mongoose = require('mongoose');
var Schema = mongoose.Schema;

// load the configuration module 
var config = require('./config'); 

// load the model Users 
var Users = require('./users');
 
// connect to the db 
mongoose.connect(config.mongourl); 

// create the db handler 
var db = mongoose.connection; 

// register some actions on different events 
db.on('error', console.error.bind(console, 'Connection error:')); 
db.once('open',   function (){ 
  // connected 
  console.log('Connected to the mongolab server. ');  
});

// set the host name 
var hostname = 'localhost'; 

//set the port nr
var port = 3030; 

var app = express();
 
app.use(bodyParser.urlencoded({ extended: false }));
 
app.use(bodyParser.json());
 
app.oauth = oauthserver({
  model: require('./model.js'), 
  grants: ['password'],
  debug: false,
  accessTokenLifetime: 21600 //6 hours
});

//post here to get token
app.post('/token/auth', app.oauth.grant());

//list all users
app.get('/', app.oauth.authorise(), function(req, res) {
	// list all the users
	Users.find({}, function ( err, userlist) {
		if (err) {
      res.status(500);
      res.send("Server error");
    }; 
      res.status(200);
      res.send(userlist);
		console.log(userlist);
  }); 
});

//add new user
app.post('/', app.oauth.authorise(), function(req, res) {
	if (!req.body.username || !req.body.password) {
    res.status(400);
    res.send("Invalid user data");
    return;
  }
  
  // create a user from request 
	var newUser = Users({
    username: req.body.username,
	  password: new Buffer(req.body.password).toString('base64'), 
    admin: req.body.admin,
    fullname: req.body.fullname,
    emailaddress: req.body.emailaddress
  }); 

 	// push it to the db 
	newUser.save( function (err) { 
		if (err) {
      res.status(500);
      res.send("Error when saving the user");
      return;
    } 
    res.status(200);
    res.send("User saved");
    return;
  }); 
});
 
app.use(app.oauth.errorHandler());

// start the app 
app.listen( port, hostname, function () {
	console.log(`Server running at http://${hostname}:${port}/`); 
}); 
