import { useEffect, useState } from "react";
import { getEvents } from "../api/events.api";
import { NavLink } from "react-router-dom";

export const User=()=>{
    const [events, setevents] = useState<any[]>([]);
    const [searchText,setsearchText]=useState("");
    useEffect(() => {
        getEvents().then((data) => {
            setevents(data);
        }).catch((error) => {
            console.log(error);
        })
    }, []);

    useEffect(() => {
        getEvents().then((data) => {
            setevents(data);
        }).catch((error) => {
            console.log(error);
        })
    }, [])

    useEffect(() => {
        getEvents().then((data) => {
            const filteredData = data.filter(event => event.name.includes(searchText));
            setevents(filteredData);
        }).catch((error) => {
            console.log(error);
        })
    }, [searchText])
    return <div>
        <input type="text" placeholder="search" onChange={(e)=>setsearchText(e.target.value)}/>
        {events.map((e) => <div key={e._id}><NavLink to={`/event/${e._id}`}>{e.name}</NavLink></div>)}
    </div>  
}