let databaseHost, databaseUser, databasePassword, databaseName;
const express = require('express');
const app = express();
const port = process.env.PORT || 5000;
const mysql = require('mysql');
const isLocalEnvironment = true;
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
  public = req.body.isPublic;

  query = `INSERT INTO notes
  (note_id, user_id, title, content, public)
  VALUES (?, ?, ?, ?, ?);`;

  con.query(query, [null, userId, title, content, public], (err, rows) => {
    if (err) throw err;
    console.log('Note added.');
  });
  return res.send(req.body).status(200);
});

app.get('/', (req, res, next) => {
  userId = req.body.userId;
  query = `SELECT * FROM notes WHERE user_id = '2' ORDER BY note_id DESC;`;

  con.query(query, (err, result) => {
    if (err) throw err;
    console.log(result[0]);
    res.status(200).json(result);
  });
  // return res.send(req.body).status(200);
});

app.get('/public', (req, res, next) => {
  query = `SELECT * FROM notes WHERE public = '1' ORDER BY note_id DESC;`;

  con.query(query, (err, result) => {
    if (err) throw err;
    console.log(result[0]);
    res.status(200).json(result);
  });
  // return res.send(req.body).status(200);
});

app.post('/register', bodyParser.json(), (req, res) => {
  email = req.body.email;
  password = req.body.password;
  query = `INSERT INTO users (id, email, password)
  VALUES (null, '${email}', '${password}')`;

  // try {
  //   con.query(query, (err, rows) => {
  //     if (err) throw err;
  //     console.log('User added.');
  //   });
  //   return res.send(req.body).status(201);
  // } catch (error) {
  //   console.error(error);
  // }

  con.query(query, (err, rows) => {
    if (err) throw err;
    console.log('User added.');
  });
  return res.send(req.body).status(201);
});

app.post('/login', bodyParser.json(), (req, res) => {
  console.log((userObject = req.body));
  email = req.body.email;
  password = req.body.password;
  query = `SELECT * FROM users WHERE email = '${email}'`;

  con.query(query, (err, result) => {
    if (err) throw err;
    console.log(result);
    // console.log(result[0].password);
    return res.status(201).json(result[0]);
  });
});

app.listen(port, () => console.log(`Listening on ${port}.`));

// app.get('/login', bodyParser.json(), (req, res) => {
//   console.log('Get request received.');
//   con.connect(function (err) {
//     if (err) throw err;
//     query = `SELECT * FROM users`;
//     con.query(query, [null, email, password], (err, result) => {
//       if (err) throw err;
//       console.log(result);
//     });
//   });

//   console.log((userObject = req.body));
//   email = req.body.email;
//   password = req.body.password;
//   query = `INSERT INTO users
//         (id, email, password) VALUES (?, ?, ?);`;

//   con.query(query, [null, email, password], (err, rows) => {
//     if (err) throw err;
//     console.log('User added.');
//   });
//   return res.send(req.body).status(200);
// });
