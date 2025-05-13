import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { getProducer } from "../api/producers.api";

export const ProducerDetails=()=>{
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
    },[])
    return <div>
        {producerData?(
        <div>
        <h3>name: {producerData.name}</h3>
        <h3>phone: {producerData.phone}</h3>
        <h3>email: {producerData.email}</h3>
        <h3>description:{producerData.description}</h3>
        </div>
         ):
         (
           <h1>No details about the producer</h1>
         )}          
    </div>;
}