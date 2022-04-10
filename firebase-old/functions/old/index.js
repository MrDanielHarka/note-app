const functions = require('firebase-functions');
const express = require('express');
const port = 4200;
const app = express();

app.get('/', (req, res, next) => {
  res.send('The Simple Notes.');
});

app.listen(port, () => {
  console.log(`Server is running on port ${port}.`);
});

exports.app = functions.https.onRequest(app);

// // Create and Deploy Your First Cloud Functions
// // https://firebase.google.com/docs/functions/write-firebase-functions
//
// exports.helloWorld = functions.https.onRequest((request, response) => {
//   functions.logger.info("Hello logs!", {structuredData: true});
//   response.send("Hello from Firebase!");
// });
