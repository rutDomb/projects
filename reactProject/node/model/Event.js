const mongoose=require('mongoose');
const Schema=mongoose.Schema;


mongoose.connect('mongodb://localhost:27017/Event_production')
.then(()=>console.log("connect to mongodb"))
.catch((err)=>console.error("Could not connect to mongodb",err));

const EventsSchema=new Schema({
    name:{
        type:String,
    },
    description:String,
    producerEmail:{
        type:String
    }
});



module.exports=mongoose.model('Event',EventsSchema);