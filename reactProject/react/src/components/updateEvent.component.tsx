import { useState } from "react";
import { EventType } from "../types/event";
import { updateEvent } from "../api/events.api";

export const UpdateEvent = (props: { eventU: any, eventSaveClick: Function }) => {
    const { eventU } = props;
    const [ev,setev]=useState(eventU);
    const { eventSaveClick } = props;
    const [name, setname] = useState(ev.name);
    const [description, setdescription] = useState(ev.description);
    const [producerEmail, setproducerEmail] = useState(ev.producerEmail);
    const updateEventF=(event:any)=>{
        event.preventDefault();
        const updateEventt={
           name:name,
           description:description,
           producerEmail:producerEmail
        }  
        updateEvent(eventU._id,updateEventt).then((e) => {
            console.log(e);
            
            setev(e);
        }).catch((e) => {
            console.log(e);
        })
        eventSaveClick();
    }

    return <form action="updateProducer" onSubmit={updateEventF}>
        <input type="text" onChange={(e) => setname(e.target.value)} value={name} /> <br />
        <input type="text" onChange={(e) => setdescription(e.target.value)} value={description} /> <br />
        <input type="text" onChange={(e) => setproducerEmail(e.target.value)} value={producerEmail} /> <br />
        <button type="submit">שמירה</button>
    </form>
}