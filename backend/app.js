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
let databaseHost;
let databaseUser;
let databasePassword;
let databaseName;
const express = require('express');
const app = express();
const port = process.env.PORT || 5000;
const mysql = require('mysql');
const isLocalEnvironment = false;
const bodyParser = require('body-parser');
const cors = require('cors');
const corsOptions = {
  origin: '*',
};
app.use(cors(corsOptions));

if (isLocalEnvironment) {
  databaseHost = 'localhost';
  databaseUser = 'root';
  databasePassword = '';
  databaseName = 'note_app';
} else {
  const mysqlCredentials = require('./mysql-credentials');
  databaseHost = mysqlCredentials.host;
  databaseUser = mysqlCredentials.user;
  databasePassword = mysqlCredentials.password;
  databaseName = mysqlCredentials.database;
}

const con = mysql.createConnection({
  host: databaseHost,
  user: databaseUser,
  password: databasePassword,
  database: databaseName,
});

con.connect(function (err) {
  if (err) throw err;
  console.log('Connected!');
});

app.post('/', bodyParser.json(), (req, res) => {
  console.log((userObject = req.body));
  userId = req.body.userId;
  title = req.body.title;
  content = req.body.content;

  query = `INSERT INTO notes 
        (note_id, user_id, title, content, public, shared, creation_date, last_saved) VALUES (?, ?, ?, ?, ?, ?, ?, ?);`;

  con.query(
    query,
    [null, userId, title, content, 0, 0, null, null],
    (err, rows) => {
      if (err) throw err;
      console.log('Note added.');
    }
  );
  return res.send(req.body).status(200);
});

app.get('/public', (req, res, next) => {
  res.status(200).json({
    notes,
  });
});

app.get('/login', bodyParser.json(), (req, res) => {
  con.connect(function (err) {
    if (err) throw err;
    query = `SELECT * FROM customers`;
    con.query(query, [null, email, password], (err, result) => {
      if (err) throw err;
      console.log(result);
    });
  });

  console.log((userObject = req.body));
  email = req.body.email;
  password = req.body.password;
  query = `INSERT INTO users 
        (id, mail_address, password) VALUES (?, ?, ?);`;

  con.query(query, [null, email, password], (err, rows) => {
    if (err) throw err;
    console.log('User added.');
  });
  return res.send(req.body).status(200);
});

app.post('/register', bodyParser.json(), (req, res) => {
  console.log((userObject = req.body));
  email = req.body.email;
  password = req.body.password;
  query = `INSERT INTO users 
        (id, mail_address, password) VALUES (?, ?, ?);`;

  con.query(query, [null, email, password], (err, rows) => {
    if (err) throw err;
    console.log('User added.');
  });
  return res.send(req.body).status(200);
});

app.get('/public', (req, res, next) => {
  res.status(200).json({
    notes,
  });
});

app.listen(port, () => console.log(`Listening on ${port}.`));
