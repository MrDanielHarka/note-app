let databaseHost,
  databaseUser,
  databasePassword,
  databaseName,
  user,
  userId,
  userEmail,
  userPassword;
const express = require('express');
const app = express();
const port = process.env.PORT || 5000;
const bodyParser = require('body-parser');

// const cors = require('cors');
// var corsOptions = {
//   origin: 'http://localhost:5000',
// };
// app.use(cors(corsOptions));

// const mysql = require('mysql');
// const isLocalEnvironment = false;

// if (isLocalEnvironment) {
//   databaseHost = 'localhost';
//   databaseUser = 'root';
//   databasePassword = '';
//   databaseName = 'note_app';
// } else {
//   const mysqlCredentials = require('./mysql-credentials');
//   databaseHost = mysqlCredentials.host;
//   databaseUser = mysqlCredentials.user;
//   databasePassword = mysqlCredentials.password;
//   databaseName = mysqlCredentials.database;
// }

// const con = mysql.createConnection({
//   host: databaseHost,
//   user: databaseUser,
//   password: databasePassword,
//   database: databaseName,
// });

// con.connect(function (err) {
//   if (err) throw err;
//   console.log('Connected!');
// });

user = {
  userId,
  userEmail,
  userPassword,
};

app.use((req, res, next) => {
  res.setHeader('Access-Control-Allow-Origin', '*');
  res.setHeader(
    'Access-Control-Allow-Headers',
    'Origin, X-Requested-With, Content-Type, Accept'
  );
  res.setHeader(
    'Access-Control-Allow-Methods',
    'GET, POST, PATCH, DELETE, OPTIONS'
  );
  next();
});

app.post('/register', bodyParser.json(), (req, res) => {
  console.log(req.body);
  console.log('Hali.');
  return res.send(req.body).sendStatus(200);
});

let notes = [
  {
    id: 1,
    title: 'server-side post',
    content: 'This is coming from the server!',
  },
  {
    id: 2,
    title: ' server-side post',
    content: 'This is coming from the server!',
  },
  {
    id: 3,
    title: ' server-side post',
    content: 'This is coming from the server!',
  },
  {
    id: 4,
    title: ' server-side post',
    content: 'This is coming from the server!',
  },
  {
    id: 5,
    title: ' server-side post',
    content: 'This is coming from the server!',
  },
  {
    id: 6,
    title: ' server-side post',
    content: 'This is coming from the server!',
  },
  {
    id: 7,
    title: ' server-side post',
    content: 'This is coming from the server!',
  },
];

app.get('/public', (req, res, next) => {
  res.status(200).json({
    notes,
  });
});

app.listen(port, () => console.log(`Listening on ${port}.`));
