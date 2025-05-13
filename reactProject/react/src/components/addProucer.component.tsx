import { createNewProducer } from "../api/producers.api"
import { ProducerType } from "../types/producer";

export const AddProducer=()=>{
    
    const add=(event:any)=>{
        event.preventDefault();
        console.log(event.target.name.value);
        
        const pro:ProducerType = {
            name:event.target.name.value,
            email: event.target.email.value,
            phone: event.target.phone.value,
            description: event.target.description.value
        }
        createNewProducer(pro); 
        event.target.reset();   
    }
    return <form onSubmit={add}>
        <input type="text" placeholder="name" name="name"/><br />       
        <input type="email" placeholder="email" name="email"/><br />
        <input type="text" placeholder="phone" name="phone"/><br />
        <input type="text" placeholder="description" name="description"/><br />
        <button type="submit">add</button>
    </form>
}