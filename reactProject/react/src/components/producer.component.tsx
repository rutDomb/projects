import { useEffect, useState } from "react";
import { ProducerType } from "../types/producer"
import { getProducer } from "../api/producers.api";
import { useParams } from "react-router-dom";
import { UpdateProducer } from "./updateProducer.component";
import { getEvents } from "../api/events.api";
import { EventOfProducer } from "./eventOfProducer.component";


export const Producer=()=>{
    const { email } = useParams();
    const[producerData,setproducerData]=useState<any|null>(null);
    const [producerUpdate,setproducerUpdate]=useState(false)
    useEffect(()=>{
        getProducer(email).then(p=>{
            setproducerData(p);
            console.log(producerData);  
        }).catch((error)=>{
            console.log(error);         
        })
    },[producerData])

    const producerUpdateClick=()=>{
        setproducerUpdate(!producerUpdate)
    }
    return <div>
        {producerData?(
        <div>
        <h3>name: {producerData.name}</h3>
        <h3>phone: {producerData.phone}</h3>
        <h3>email: {producerData.email}</h3>
        <h3>description: {producerData.description}</h3>
        <button onClick={producerUpdateClick}>edit</button>
        {producerUpdate?<UpdateProducer producerU={producerData} producerSaveClick={producerUpdateClick}/>:""}
        <p>List of events</p>
        <EventOfProducer producerEmail={producerData.email}/>
        </div>
         ):
         (
           <h1>No details about the producer</h1>
         )}          
    </div>;
}
