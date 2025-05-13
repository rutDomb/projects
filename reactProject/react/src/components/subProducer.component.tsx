import { useState } from "react"
import { Verification } from "./Verification.component"
import { AddProducer } from "./addProucer.component"
import { Producer } from "./producer.component"
import { NavLink, Navigate, useNavigate } from "react-router-dom"

export const SubProducer=()=>{
    const [addProducer,setaddProducer]=useState(true);
    const [existsProducer,setexistsProducer]=useState(true);
    const navigate = useNavigate();
    const add=()=>{
        setaddProducer(!addProducer);
        navigate('/addProducer');
        
    }
    const exists=()=>{
        setexistsProducer(!existsProducer);
        navigate('/verification');
    }
    return <div>
        <button onClick={add}>Add producer</button><br />
        <button onClick={exists}>Exist producer</button>
    </div>
}