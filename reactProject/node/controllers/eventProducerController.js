const EventProducer = require('../model/Event_Producer');
const express = require('express');
const router = express.Router();


router.get('/eventProducer', async (req, res) => {
    try {
        const eventProducers = await EventProducer.find().exec();
        res.send(eventProducers);
    } catch (error) {
        res.status(500).send(error);
    }
});

router.get('/eventProducer/:email', async (req, res) => {
    try {
        const eventProducer = await EventProducer.findOne({email:req.params.email}).lean().exec();
        if (!eventProducer) return res.status(404).send("eventProducer not found");
        res.send(eventProducer);
    } catch (error) {
        res.status(500).send(error);
    }
});

router.post('/eventProducer', async (req, res) => {
    try {
        const eventProducer = req.body;
        console.log(eventProducer);
        const newEventProducer = await EventProducer.create({           
            name: eventProducer.name,
            email: eventProducer.email,
            phone: eventProducer.phone,
            description:eventProducer.description
        });
        res.send("newEventProducer " + JSON.stringify(newEventProducer));
    } catch (error) {
        res.status(500).send(error);
    }
});

router.put('/eventProducer/:email', async (req, res) => {
    try {
        const eventProducer = await EventProducer.find({email:req.params.email}).exec();
        if (!eventProducer) return res.status(404).send('The eventProducer does not exist.');
        
        await EventProducer.updateOne({ email:req.params.email }, req.body);
        res.send("eventProducer updated " + JSON.stringify(req.body));
    } catch (error) {
        res.status(500).send(error);
    }
});


module.exports = router;