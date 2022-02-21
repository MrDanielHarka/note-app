import express from 'express';
const app = express();
const port = process.env.PORT || 5000;

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

const notes = [
  {
    id: 'fadf12421l',
    title: 'First server-side post',
    content: 'This is coming from the server',
  },
  {
    id: 'ksajflaj132',
    title: 'Second server-side post',
    content: 'This is coming from the server!',
  },
];

app.get('/', (req, res, next) => {
  res.status(200).json({
    notes,
  });
});

app.listen(port, () => console.log('Listening on 5000.'));
