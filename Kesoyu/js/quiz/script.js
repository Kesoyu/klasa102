const express = require('express');
const app = express();

const host = '127.0.0.1';
const port = 5555;
const www = __dirname + '\\public';

app.listen(port, ()=>{console.log(`listening on port ${host}:${port}`);});

app.use(express.static(www));