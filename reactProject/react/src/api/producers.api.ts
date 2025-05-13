import { Producer } from "../components/producer.component";
import { ProducerType } from "../types/producer";
import axios from 'axios';

const server = 'http://localhost:3000'

const ProducerServer = axios.create({
    baseURL: server
});

export const createNewProducer =async (producer:ProducerType) :Promise<ProducerType>=> {
   const response=await ProducerServer.post('/eventProducer',producer);
   return response.data;
}

export const updateProducer=async(producer:ProducerType):Promise<ProducerType>=>{  
    const email=producer.email;
    const response=await ProducerServer.put(`/eventProducer/${email}`,producer);
    console.log(response.data);
    return response.data;
}

export const getProducer=async(email:any):Promise<ProducerType>=>{
    const response=await ProducerServer.get(`/eventProducer/${email}`);
    console.log(response.data);
    return response.data;
}

