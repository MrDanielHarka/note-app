let databaseHost, databaseUser, databasePassword, databaseName;
const express = require('express');
const app = express();
const port = process.env.PORT || 5000;
const mysql = require('mysql');
const bodyParser = require('body-parser');
const bcrypt = require('bcrypt');
const saltRounds = 12;
const isLocalEnvironment = true;
const cors = require('cors');
const corsOptions = {
  origin: '*',
};

// app.use(express.json());
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
  console.log('Connected to database.');
});

app.post('/user-notes', bodyParser.json(), (req, res, next) => {
  console.log(req.body.userId);
  userId = req.body.userId;
  console.log(userId);
  query = `SELECT * FROM notes WHERE user_id = '${req.body.userId}' ORDER BY note_id DESC;`;

  con.query(query, (err, result) => {
    if (err) throw err;
    console.log(result);
    res.status(200).json(result);
  });
  // return res.send(req.body).status(200);
});

app.post('/new-note', bodyParser.json(), (req, res) => {
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

app.put('/update-note', bodyParser.json(), (req, res) => {
  console.log(req.body);
  noteId = req.body.note_id;
  userId = req.body.user_id;
  title = req.body.title;
  content = req.body.content;
  isPublic = req.body.public;

  query = `
  UPDATE notes
  SET note_id = ${noteId},
      user_id = ${userId},
      title = '${title}',
      content = '${content}',
      public = ${isPublic}
  WHERE note_id = ${noteId}
  `;

  con.query(query, (err, result) => {
    if (err) throw err;
    console.log(result);
    // console.log(result[0].password);
    return res.status(201).json('Note saved successfully.');
  });
});

app.put('/delete-note', bodyParser.json(), (req, res) => {
  console.log(req.body);
  noteId = req.body.note_id;

  query = `
  DELETE FROM notes
  WHERE note_id = ${noteId}
  `;

  con.query(query, (err, result) => {
    if (err) throw err;
    console.log(result);
    return res.status(201).json('Note deleted successfully.');
  });
});

app.get('/public-notes', (req, res, next) => {
  query = `SELECT * FROM notes WHERE public = '1' ORDER BY note_id DESC;`;

  con.query(query, (err, result) => {
    if (err) throw err;
    console.log(result[0]);
    res.status(200).json(result);
  });
  // return res.send(req.body).status(200);
});

app.post('/register', bodyParser.json(), async (req, res) => {
  firstName = req.body.firstName;
  lastName = req.body.lastName;
  email = req.body.email;
  password = req.body.password;
  hash = await bcrypt.hash(password, saltRounds);
  query = `INSERT INTO users (id, email, password, first_name, last_name)
  VALUES (null, '${email}', '${hash}', '${firstName}', '${lastName}')`;

  con.query(query, (err) => {
    if (err) {
      if (err.code == 'ER_DUP_ENTRY' || err.errno == 1062) {
        res.status(200).send(`{
            "message": "This email address is already registered."
          }`);
      } else {
        console.log('Other error in the query');
      }
    } else {
      res.status(200).send(`{
            "success": "Success! You can now log in."
          }`);
    }
  });
});

app.post('/login', bodyParser.json(), async (req, res) => {
  try {
    console.log((userObject = req.body));
    email = req.body.email;
    password = req.body.password;
    let user;
    query = `
  SELECT *
  FROM users
  WHERE email = '${email}'`;

    con.query(query, async (err, result) => {
      if (err) throw err;
      // console.log(result);
      // console.log(result[0].password);
      // return res.status(201).json(result[0]);
      this.user = result[0];
      if (this.user) {
        console.log(this.user);
        const validPassword = await bcrypt.compare(
          password,
          this.user.password
        );
        console.log(password);
        console.log(this.user.password);
        console.log(validPassword);
        if (validPassword) {
          res.status(200).send(`{
            "message": "Valid email and password.",
            "userId": "${this.user.id}",
            "email": "${this.user.email}",
            "firstName": "${this.user.first_name}",
            "lastName": "${this.user.last_name}",
            "isLoggedIn": "${true}"
          }`);
        } else {
          res.status(200).send(`{
            "message": "Invalid password."
          }`);
        }
      } else {
        console.log(this.user);
        res.status(200).send(`{
            "message": "Invalid email."
          }`);
      }
    });
  } catch (e) {
    console.log(e);
    res.status(200).send(`{
            "message": "Something broke."
          }`);
  }
});

app.put('/settings', bodyParser.json(), async (req, res) => {
  userId = req.body.userId;
  email = req.body.email;
  password = req.body.password;
  firstName = req.body.firstName;
  lastName = req.body.lastName;
  hash = await bcrypt.hash(password, saltRounds);

  query = `
  UPDATE users
  SET id = ${userId},
      email = '${email}',
      password = '${password}',
      first_name = '${firstName}',
      last_name = '${lastName}'
  WHERE id = ${userId}`;

  con.query(query, (err, result) => {
    if (err) throw err;
    console.log(result);
    // console.log(result[0].password);
    return res.status(201).json('Settings saved successfully.');
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

// app.post('/login', bodyParser.json(), (req, res) => {
//   console.log((userObject = req.body));
//   email = req.body.email;
//   password = req.body.password;
//   query = `
//   SELECT *
//   FROM users
//   WHERE email = '${email}'`;

//   con.query(query, (err, result) => {
//     if (err) throw err;
//     console.log(result);
//     // console.log(result[0].password);
//     return res.status(201).json(result[0]);
//   });
// });

// app.post('/register', bodyParser.json(), (req, res) => {
//   firstName = req.body.firstName;
//   lastName = req.body.lastName;
//   email = req.body.email;
//   password = req.body.password;
//   query = `INSERT INTO users (id, email, password, first_name, last_name)
//   VALUES (null, '${email}', '${password}', '${firstName}', '${lastName}')`;

//   // try {
//   //   con.query(query, (err, rows) => {
//   //     if (err) throw err;
//   //     console.log('User added.');
//   //   });
//   //   return res.send(req.body).status(201);
//   // } catch (error) {
//   //   console.error(error);
//   // }

//   con.query(query, (err) => {
//     if (err) throw err;
//     console.log('User added.');
//   });
//   return res.send(req.body).status(201);
// });

// app.post('/register', bodyParser.json(), async (req, res) => {
//   try {
//     firstName = req.body.firstName;
//     lastName = req.body.lastName;
//     email = req.body.email;
//     password = req.body.password;
//     hash = await bcrypt.hash(password, saltRounds);
//     query = `INSERT INTO users (id, email, password, first_name, last_name)
//   VALUES (null, '${email}', '${hash}', '${firstName}', '${lastName}')`;

//     con.query(query, (err) => {
//       if (err) throw err;
//       console.log('User added.');
//     });
//     return res.send(req.body).status(201);
//   } catch (e) {
//     console.log(e);
//     res.status(500).send('Something broke.');
//   }
// });

// app.put('/settings', bodyParser.json(), (req, res) => {
//   console.log(req.body);
//   userId = req.body.userId;
//   email = req.body.email;
//   password = req.body.password;
//   firstName = req.body.firstName;
//   lastName = req.body.lastName;

//   query = `
//   UPDATE users
//   SET id = ${userId},
//       email = '${email}',
//       password = '${password}',
//       first_name = '${firstName}',
//       last_name = '${lastName}'
//   WHERE id = ${userId}`;

//   con.query(query, (err, result) => {
//     if (err) throw err;
//     console.log(result);
//     // console.log(result[0].password);
//     return res.status(201).json('Settings saved successfully.');
//   });
// });
