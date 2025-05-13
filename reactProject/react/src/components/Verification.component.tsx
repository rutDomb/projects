import { useState } from "react";
import { getProducer } from "../api/producers.api"
import { ProducerType } from "../types/producer";
import { Producer } from "./producer.component"
import { NavLink, Navigate, useNavigate } from "react-router-dom"

export const Verification = () => {
    const [email, setemail] = useState("");
    const [isNext, setisNext] = useState(false);
    const [inputValue, setinputValue] = useState();
    const navigate = useNavigate();
    const change = (event: any) => {
        setemail(event.target.value);
    }
    const sending = (event: any) => {
        event.preventDefault();
        navigate(`/producer/${email}`);
    }
    return (
        <form onSubmit={sending}>
            <label htmlFor="">Enter email address</label><br />
            <input type="email" placeholder="email" name="email" onChange={change} /><br />
            <button>next</button>
        </form>
    );
}