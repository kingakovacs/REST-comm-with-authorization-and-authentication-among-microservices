//load memory-store
var tokenStore = [];
var clientStore = [];

// load the model Users 
var Users = require('./users');

//this key is used for token encoding 
var cert = 'b96c9f01-fbfe-468f-beea-79ffac7a2d32';

function TokenData(token, clientId, expires, user) {
  this.token = token,
  this.clientId = clientId,
  this.user = user;
  this.expires = expires;
}

function getAccessToken(bearerToken, callback) {
    var error;
    var tokenData = null;
    for (var i in tokenStore) {
      if (tokenStore[i].key === bearerToken) {
        tokenData = tokenStore[i].value;
        break;
      }
    }
    if (tokenData == null) {
      token = false;
      callback(error, token);
      return;
    }

    // verify token
    if (tokenData.clientId == null || tokenData.user == null || 
              tokenData.expires == null || tokenData.token == null) {
      token = false;
      callback(error, token);
      return
    }

    if (tokenData.expires <= Date.now() / 1000) {
      token = false;
      callback(error, token);
    }
    callback(error, tokenData);
    return;
}

function getClient(clientId, clientSecret, callback) {
  var error;
  var client = {clientId, clientSecret};
  var oldSecret = clientStore[clientId];
  if (oldSecret == undefined) {
    clientStore.push({
      key: clientId,
      value: clientSecret
    });
    callback(error, client);
    return;
  } else {
    if (oldSecret === clientSecret) {
      callback(error, client);
      return;
    } else {
      client = false;
      callback(error, client);
      return;
    }
  }
}

function grantTypeAllowed (clientId, grantType, callback) {
  var error;
  var allowed = false;
  if (grantType == "password") {
    allowed = true;
  }
  callback(error, allowed);
  return;
}

function saveAccessToken (accessToken, clientId, expires, user, callback) {
  var error;
  var tokenData = new TokenData(accessToken, clientId, expires, user);
  tokenStore.push({
    key: accessToken,
    value: tokenData
  });
  callback(error);
  return;
}

function getUser(username, password, callback) {
  //some code about reading users from db
  var passBuffer = new Buffer(password).toString('base64');
  Users.find({username: username, password: passBuffer}, function ( err, userlist) {
    var error, user;
		if (err) {
      user = false;
    } else if (userlist.length == 0) {
      user = false;
    } else {
      user = userlist[0];
      user.id = user.username;
      console.log(user);
    }
    callback(error, user);
  });
  return;
}

module.exports = {
  getAccessToken: getAccessToken,
  getClient: getClient,
  getUser: getUser,
  grantTypeAllowed : grantTypeAllowed, 
  saveAccessToken: saveAccessToken
}