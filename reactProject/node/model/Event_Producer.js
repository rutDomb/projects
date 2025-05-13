const mongoose=require('mongoose');
const Schema=mongoose.Schema;


mongoose.connect('mongodb://localhost:27017/Event_production',{
    useNewUrlParser: true,
    useUnifiedTopology: true
})
.then(()=>console.log("connect to mongodb"))
.catch((err)=>console.error("Could not connect to mongodb",err));

const Event_ProducersSchema=new Schema({
    name:{
        type:String,
    },
    email:{
        type:String
    },
    phone:{
        type:String,
    },
    description:String
});


module.exports=mongoose.model('Event_Producer',Event_ProducersSchema);


