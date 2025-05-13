import { createNewEvent } from "../api/events.api";
import { EventType } from "../types/event";

export const AddEvent=(props:{func:any,changeEventsF:Function})=>{
    const {func}=props;
    const {changeEventsF}=props;
    const add=(event:any)=>{
        event.preventDefault();
        const newEvent:EventType = {
            name:event.target.name.value,
            description: event.target.description.value,
            producerEmail: event.target.producerEmail.value,
        }
        createNewEvent(newEvent);  
        event.target.reset(); 
        changeEventsF();
        func();
    }
    return <form onSubmit={add}>
        <input type="text" placeholder="name" name="name"/><br />
        <input type="text" placeholder="description" name="description"/><br />
        <input type="text" placeholder="producerEmail" name="producerEmail"/><br />
        <button type="submit">add</button>
    </form>

    
}