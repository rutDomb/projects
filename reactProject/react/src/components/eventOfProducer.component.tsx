import { NavLink } from "react-router-dom";
import { getEvents } from "../api/events.api"
import { useEffect, useState } from "react";
import { EventType } from "../types/event";
import { AddEvent } from "./addEvent.component";

export const EventOfProducer = (props: { producerEmail: any }) => {
    const { producerEmail } = props;
    const [events, setevents] = useState<any[]>([]);
    const [isAdd, setisAdd] = useState(false);
    useEffect(() => {
        getEvents().then((data) => {
            const filteredData = data.filter(event => event.producerEmail === producerEmail);
            setevents(filteredData);
        }).catch((error) => {
            console.log(error);
        })
    }, [events])

    const change = () => {
        setisAdd(!isAdd);
    }

    const changeEvents = (events: any) => {
        getEvents().then((data) => {
            const filteredData = data.filter(event => event.producerEmail === producerEmail);
            setevents(filteredData);
        }).catch((error) => {
            console.log(error);
        })
    }
    return <div>
        {events.map((e) => <div key={e._id}><NavLink to={`/eventOfProducer/${e._id}`}>{e.name}</NavLink></div>)} <br />
        <button onClick={change}>add event</button>
        {isAdd ? <AddEvent func={change} changeEventsF={changeEvents} /> : ""}
    </div>
}