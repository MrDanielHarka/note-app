console.clear();

const express = require('express');
const app = express();
const port = process.env.PORT || 5000;
const bcrypt = require('bcrypt');
const saltRounds = 12;
const cors = require('cors')({ origin: 'https://note-app.harka.com' });
const sqlite3 = require('sqlite3').verbose();
const db = new sqlite3.Database('../database/note_app.db');

app.use(express.json());
app.use(cors);
app.get('/', (req, res) => res.redirect('https://note-app.harka.com'));

app.get('/stats', (req, res) => {
  const query = `SELECT
    (SELECT COUNT(*) FROM users) AS userCount,
    (SELECT COUNT(*) FROM notes) AS noteCount;`;

  db.get(query, (err, row) => {
    if (err) throw err;

    const stats = {
      users: row.userCount,
      notes: row.noteCount,
    };

    res.status(200).json(stats);
  });
});

app.post('/user-notes', (req, res) => {
  userId = req.body.userId;
  query = `SELECT * FROM notes WHERE user_id = ? ORDER BY note_id DESC;`;

  db.all(query, [userId], (err, rows) => {
    if (err) throw err;
    res.status(200).json(rows);
  });
});

app.post('/new-note', (req, res) => {
  userId = req.body.userId;
  title = req.body.title;
  content = req.body.content;
  public = req.body.isPublic;
  shared = 0;

  query = `INSERT INTO notes
  (note_id, user_id, title, content, public, shared)
  VALUES (?, ?, ?, ?, ?, ?);`;

  db.run(query, [null, userId, title, content, public, shared], err => {
    if (err) throw err;
  });

  return res.send(req.body).status(200);
});

app.put('/update-note', (req, res) => {
  noteId = req.body.note_id;
  userId = req.body.user_id;
  title = req.body.title;
  content = req.body.content;
  isPublic = req.body.public;

  query = `
  UPDATE notes
  SET note_id = ?,
      user_id = ?,
      title = ?,
      content = ?,
      public = ?
  WHERE note_id = ?
  `;

  db.run(query, [noteId, userId, title, content, isPublic, noteId], err => {
    if (err) throw err;
    return res.status(201).json('Note saved successfully!');
  });
});

app.put('/delete-note', (req, res) => {
  noteId = req.body.note_id;

  query = `
  DELETE FROM notes
  WHERE note_id = ?
  `;

  db.run(query, [noteId], err => {
    if (err) throw err;
    return res.status(201).json('Note deleted successfully!');
  });
});

app.get('/public-notes', (req, res) => {
  query = `
  SELECT users.last_name, users.first_name, notes.title, notes.content
  FROM users
  INNER JOIN notes
  ON users.id = notes.user_id
  WHERE users.id = notes.user_id AND notes.public = 1
  ORDER BY note_id DESC
  ;`;

  db.all(query, (err, rows) => {
    if (err) throw err;
    res.status(200).json(rows);
  });
});

app.post('/register', async (req, res) => {
  firstName = req.body.firstName;
  lastName = req.body.lastName;
  email = req.body.email;
  password = req.body.password;
  hash = await bcrypt.hash(password, saltRounds);
  query = `
  INSERT INTO users (id, email, password, first_name, last_name)
  VALUES (null, ?, ?, ?, ?)`;

  db.run(query, [email, hash, firstName, lastName], function (err) {
    if (err) {
      if (err.code === 'SQLITE_CONSTRAINT') {
        return res.status(200).send({
          message: 'This email address is already registered!',
        });
      } else throw err;
    }

    return res.status(200).send({
      success: 'Success! You can now log in.',
    });
  });
});

app.post('/login', async (req, res) => {
  try {
    email = req.body.email;
    password = req.body.password;
    query = `SELECT * FROM users WHERE email = ?`;

    db.get(query, [email], async (err, row) => {
      if (err) throw err;
      this.user = row;
      if (this.user) {
        const validPassword = await bcrypt.compare(
          password,
          this.user.password
        );
        if (validPassword) {
          res.status(200).send({
            message: 'Valid email and password!',
            userId: this.user.id,
            email: this.user.email,
            firstName: this.user.first_name,
            lastName: this.user.last_name,
            isLoggedIn: true,
          });
        } else {
          res.status(200).send({
            message:
              'Invalid password! For customer support, an email can be sent to note-app@harka.com from this user email for a temporary recovery password.',
          });
        }
      } else {
        res.status(200).send({
          message: 'Email not registered!',
        });
      }
    });
  } catch (e) {
    res.status(200).send({
      message: 'Something broke!',
    });
  }
});

app.put('/settings', async (req, res) => {
  try {
    userId = req.body.userId;
    email = req.body.email;
    firstName = req.body.firstName;
    lastName = req.body.lastName;
    currentPassword = req.body.currentPassword;
    newPassword = req.body.newPassword;
    newPasswordHash = await bcrypt.hash(newPassword, saltRounds);
    query = `SELECT * FROM users WHERE id = ?`;

    db.get(query, [userId], async (err, row) => {
      if (err) throw err;
      this.user = row;
      if (this.user) {
        const validPassword = await bcrypt.compare(
          currentPassword,
          this.user.password
        );
        if (validPassword) {
          let query;

          if (newPassword === '') {
            query = `
          UPDATE users
          SET id = ?,
              email = ?,
              password = ?,
              first_name = ?,
              last_name = ?
          WHERE id = ?`;
            db.run(
              query,
              [userId, email, this.user.password, firstName, lastName, userId],
              err => {
                if (err) throw err;
                res.status(200).send({
                  success: 'Settings saved successfully!',
                });
              }
            );
          } else {
            query = `
            UPDATE users
            SET id = ?,
                email = ?,
                password = ?,
                first_name = ?,
                last_name = ?
            WHERE id = ?`;
            db.run(
              query,
              [userId, email, newPasswordHash, firstName, lastName, userId],
              err => {
                if (err) throw err;
                res.status(200).send({
                  success: 'Settings saved successfully!',
                });
              }
            );
          }
        } else {
          res.status(200).send({
            message: 'Invalid current password!',
          });
        }
      } else {
        res.status(200).send({
          message: 'User not found!',
        });
      }
    });
  } catch (e) {
    res.status(200).send({
      message: 'Something broke!',
    });
  }
});

app.listen(port, () => console.log(`Running...`));
