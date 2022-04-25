const express = require('express');
const app = express();
const port = process.env.PORT || 5000;
const path = require('path');
const bcrypt = require('bcrypt');
const saltRounds = 12;
const mysql = require('mysql');
const mysqlCredentials = require('./mysql-credentials');
const cors = require('cors');
const corsOptions = { origin: '*' };
const pool = mysql.createPool({
  connectionLimit: 10,
  host: mysqlCredentials.host,
  user: mysqlCredentials.user,
  password: mysqlCredentials.password,
  database: mysqlCredentials.database,
});

app.use(express.json());
app.use(express.static('public'));
app.use(cors(corsOptions));

app.get('/', function (req, res) {
  res.sendFile(path.join(__dirname, '/public/index.html'));
});

app.post('/user-notes', (req, res, next) => {
  console.log(req.body.userId);
  userId = req.body.userId;
  console.log(userId);
  query = `SELECT * FROM notes WHERE user_id = '${req.body.userId}' ORDER BY note_id DESC;`;

  pool.query(query, (err, result) => {
    if (err) throw err;
    console.log(result);
    res.status(200).json(result);
  });
  // return res.send(req.body).status(200);
});

app.post('/new-note', (req, res) => {
  console.log((userObject = req.body));
  userId = req.body.userId;
  title = req.body.title;
  content = req.body.content;
  public = req.body.isPublic;
  shared = 0;

  query = `INSERT INTO notes
  (note_id, user_id, title, content, public, shared)
  VALUES (?, ?, ?, ?, ?, ?);`;

  pool.query(
    query,
    [null, userId, title, content, public, shared],
    (err, rows) => {
      if (err) throw err;
      console.log('Note added.');
    }
  );
  return res.send(req.body).status(200);
});

app.put('/update-note', (req, res) => {
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

  pool.query(query, (err, result) => {
    if (err) throw err;
    console.log(result);
    // console.log(result[0].password);
    return res.status(201).json('Note saved successfully.');
  });
});

app.put('/delete-note', (req, res) => {
  console.log(req.body);
  noteId = req.body.note_id;

  query = `
  DELETE FROM notes
  WHERE note_id = ${noteId}
  `;

  pool.query(query, (err, result) => {
    if (err) throw err;
    console.log(result);
    return res.status(201).json('Note deleted successfully.');
  });
});

app.get('/stats', (req, res, next) => {
  userQuery = `SELECT COUNT(*) FROM users;`;
  noteQuery = `SELECT COUNT(*) FROM notes;`;
  let stats = {
    users: 23,
    notes: 78,
  };

  pool.query(userQuery, (err, result) => {
    if (err) throw err;
    console.log(result[0]['COUNT(*)']);
    stats.users = result[0]['COUNT(*)'];
  });

  pool.query(noteQuery, (err, result) => {
    if (err) throw err;
    console.log(result[0]['COUNT(*)']);
    stats.notes = result[0]['COUNT(*)'];
  });
  // stats.users = 'hali';
  // console.log(stats.users);
  // res.status(200).json(stats);
  // console.log(stats, users, notes);

  setTimeout(() => {
    res.status(200).json(stats);
  }, 1000);
});

app.get('/public-notes', (req, res, next) => {
  query = `SELECT * FROM notes WHERE public = '1' ORDER BY note_id DESC;`;

  pool.query(query, (err, result) => {
    if (err) throw err;
    console.log(result[0]);
    res.status(200).json(result);
  });
  // return res.send(req.body).status(200);
});

app.post('/register', async (req, res) => {
  firstName = req.body.firstName;
  lastName = req.body.lastName;
  email = req.body.email;
  password = req.body.password;
  hash = await bcrypt.hash(password, saltRounds);
  query = `INSERT INTO users (id, email, password, first_name, last_name)
  VALUES (null, '${email}', '${hash}', '${firstName}', '${lastName}')`;

  pool.query(query, (err) => {
    if (err) {
      if (err.code == 'ER_DUP_ENTRY' || err.errno == 1062) {
        res.status(200).send(`{
            "message": "This email address is already registered."
          }`);
      } else {
        console.log('Other error in the query');
        console.log(err);
      }
    } else {
      res.status(200).send(`{
            "success": "Success! You can now log in."
          }`);
    }
  });
});

app.post('/login', async (req, res) => {
  try {
    console.log((userObject = req.body));
    email = req.body.email;
    password = req.body.password;
    let user;
    query = `
  SELECT *
  FROM users
  WHERE email = '${email}'`;

    pool.query(query, async (err, result) => {
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

app.put('/settings', async (req, res) => {
  try {
    console.log((userObject = req.body));
    userId = req.body.userId;
    email = req.body.email;
    firstName = req.body.firstName;
    lastName = req.body.lastName;
    currentPassword = req.body.currentPassword;
    newPassword = req.body.newPassword;
    newPasswordHash = await bcrypt.hash(newPassword, saltRounds);
    let user;
    query = `
  SELECT *
  FROM users
  WHERE id = '${userId}'`;

    pool.query(query, async (err, result) => {
      if (err) throw err;
      // console.log(result);
      // console.log(result[0].password);
      // return res.status(201).json(result[0]);
      this.user = result[0];
      if (this.user) {
        console.log(this.user);
        const validPassword = await bcrypt.compare(
          currentPassword,
          this.user.password
        );
        console.log(newPasswordHash);
        console.log(this.user.password);
        console.log(validPassword);
        if (validPassword) {
          query = `
          UPDATE users
          SET id = ${userId},
              email = '${email}',
              password = '${newPasswordHash}',
              first_name = '${firstName}',
              last_name = '${lastName}'
          WHERE id = ${userId}`;

          pool.query(query, (err, result) => {
            if (err) throw err;
            console.log(result);
            // console.log(result[0].password);
            res.status(200).send(`{
            "success": "Settings saved successfully."
          }`);
          });

          // res.status(200).send(`{
          //   "message": "Valid email and password.",
          //   "userId": "${this.user.id}",
          //   "email": "${this.user.email}",
          //   "firstName": "${this.user.first_name}",
          //   "lastName": "${this.user.last_name}",
          //   "isLoggedIn": "${true}"
          // }`);
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

app.listen(port, () => console.log(`App is running on ${port}`));
