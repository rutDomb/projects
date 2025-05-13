const Event = require('../model/Event');
const express = require('express');
const router = express.Router();

router.get('/event', async (req, res) => {
    try {
        const events = await Event.find().exec();
        res.send(events);
    } catch (error) {
        res.status(500).send(error);
    }
});


router.get('/event/:id', async (req, res) => {
    try {
        const event = await Event.findById(req.params.id).exec();
        if (!event) return res.status(404).send("Event not found");
        res.send(event);
    } catch (error) {
        res.status(500).send(error);
    }
});

router.post('/event', async (req, res) => {
    try {
        const event = req.body;
        const newEvent = await Event.create({
            name: event.name,
            description: event.description,
            producerEmail: event.producerEmail
        });
        res.send("newEvent " + JSON.stringify(newEvent));
    } catch (error) {
        res.status(500).send(error);
    }
});

router.put('/event/:id', async (req, res) => {
    try {
        const event = await Event.findById(req.params.id);
        if (!event) return res.status(404).send('The event does not exist.');
        
        await Event.updateOne({ _id: req.params.id }, req.body);
        res.send("event updated " + JSON.stringify(req.body));
    } catch (error) {
        res.status(500).send(error);
    }
});

router.delete('/event/:id', async (req, res) => {
    try {
        const event = await Event.findById(req.params.id);
        if (!event) return res.status(404).send('The event does not exist.');
        
        await Event.deleteOne({ _id: req.params.id });
        res.send("event deleted " + JSON.stringify(event));
    } catch (error) {
        res.status(500).send(error);
    }
});

module.exports = router;
