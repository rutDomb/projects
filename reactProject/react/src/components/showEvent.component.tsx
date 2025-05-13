import { useEffect, useState } from "react";
import { NavLink, useParams } from "react-router-dom";
import { getEventById } from "../api/events.api";
import { ProducerDetails } from "./producerDetails.component";

export const ShowEvent = () => {
    const { id } = useParams();
    const [eventData, seteventData] = useState<any | null>(null);
    const [eventUpdate, seteventUpdate] = useState(false);
    const [producerDetails, setproducerDetails] = useState(false);
    useEffect(() => {
        getEventById(id).then(e => {
            seteventData(e);
            console.log(eventData);
        }).catch((error) => {
            console.log(error);
        })
    }, [id]);

    if (!eventData) {
        return <div>Loading...</div>;
    }

    return <div>
        <h4>name: {eventData.name}</h4>
        <h4>description: {eventData.description}</h4>
        <h4>producerEmail: {eventData.producerEmail}</h4>
        <div key={eventData.producerEmail}><NavLink to={`/producerDetails/${eventData.producerEmail}`}>Producer details</NavLink></div>
    </div>
}