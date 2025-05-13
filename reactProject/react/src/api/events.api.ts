import axios from "axios";
import { EventType } from "../types/event";

const server = 'http://localhost:3000'

const EventsServer = axios.create({
    baseURL: server
});

export const getEvents = async (): Promise<EventType[]> => {
    const response = await EventsServer.get<EventType[]>(`/event`);
    return response.data;
}

export const createNewEvent = async (event: EventType): Promise<EventType> => {
    const response = await EventsServer.post('/event', event);
    console.log(response.data); 
    return response.data;
}

export const getEventById=async(id:any):Promise<EventType>=>{
    const response=await EventsServer.get(`/event/${id}`);
    return response.data;
}

export const deleteEvent=async(id:any):Promise<EventType>=>{
    const response=await EventsServer.delete(`/event/${id}`);
    return response.data;
}

export const updateEvent=async(id:any,event:EventType):Promise<EventType>=>{  
    const response=await EventsServer.put(`/event/${id}`,event);
    console.log(response.data);
    return response.data;
}