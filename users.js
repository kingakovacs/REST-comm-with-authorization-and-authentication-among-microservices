// load the mongoose schema 
var mongoose = require('mongoose'); 

// create the first schema 
var Schema = mongoose.Schema; 

// create the user schema 
var userSchema = new Schema ({
	username: { type: String, required: true},
	password: { type: Buffer, required: true}, 
    admin: Boolean,
    fullname: String,
    emailaddress: String
	}); 

// Create the model 
 var Users = mongoose.model('User', userSchema); 

// export it to the other modules
module.exports = Users; 

