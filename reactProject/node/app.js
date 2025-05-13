const express = require('express');
const cors = require('cors');
const mongoose = require('mongoose');
const event =require('./controllers/eventController');
const eventProducer = require('./controllers/eventProducerController');
const bodyParser = require('body-parser');

const app = express();
const PORT = 3000;


app.use(cors());
app.use((req, res, next) => {
    console.log(`${req.method} request for '${req.url}'`);
    next();
});

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

app.use('/',event);
app.use('/',eventProducer);

mongoose.connection.once('open',()=>{
    console.log('connected to MongoDB');
    app.listen(PORT, () => console.log(`Server running on port ${PORT}`))
});





