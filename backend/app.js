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

app.get('/', (req, res, next) => {
  res.status(200).json({
    notes,
  });
});

app.listen(port, () => console.log('Listening on 5000.'));
