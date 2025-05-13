import { useParams } from "react-router-dom";
import { deleteEvent, getEventById } from "../api/events.api"
import { useEffect, useState } from "react";
import { UpdateEvent } from "./updateEvent.component";

export const ShowEventOfProducer = () => {
    const { id } = useParams();
    const [eventData, seteventData] = useState<any | null>(null);
    const [eventUpdate,seteventUpdate]=useState(false);
    useEffect(()=>{
        getEventById(id).then(e=>{
            seteventData(e);
            console.log(eventData);  
        }).catch((error)=>{
            console.log(error);         
        })
    },[eventData]);

   
    

    const eventUpdateClick=()=>{
        seteventUpdate(!eventUpdate);
    }

    const remove=(event:any)=>{
        seteventData("");
        deleteEvent(event._id);
        return <div>The event was successfully deleted.</div>
    }

    return <div>
        {eventData?
            (<div>
            <h4>name: {eventData.name}</h4>
            <h4>description: {eventData.description}</h4>
            <h4>producerEmail: {eventData.producerEmail}</h4>
            <button onClick={eventUpdateClick}>edit</button>
            <button onClick={()=>remove(eventData)}>delete</button>
            {eventUpdate?<UpdateEvent eventU={eventData} eventSaveClick={eventUpdateClick}/>:""}
        </div>):<div>The event was successfully deleted.</div>}
        </div>
        
}