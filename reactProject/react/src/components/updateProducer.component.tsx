import { useEffect, useState } from "react";
import { ProducerType } from "../types/producer";
import { getProducer, updateProducer } from "../api/producers.api";

export const UpdateProducer = (props: { producerU: ProducerType, producerSaveClick: Function }) => {
    const { producerU } = props;
    const { producerSaveClick } = props;
    const [keep,setkeep]=useState(false);
    const [pr,setpr]=useState(producerU);
    const [nameP, setnameP] = useState(pr.name);
    const [emailP, setemailP] = useState(pr.email);
    const [phoneP, setphoneP] = useState(pr.phone);
    const [descriptionP, setdescriptionP] = useState(pr.description);

    const updateProducerF =async (event: any) => {
        event.preventDefault();
        const Updateproducerr = {
            name: nameP,
            email: emailP,
            phone: phoneP,
            description: descriptionP
        };
        // setkeep(!keep);
        await updateProducer(Updateproducerr).then((p) => {
            setpr(p);
        }).catch((e) => {
            console.log(e);
        })
        producerSaveClick();
        
    }

    // useEffect(() => {
    //     getProducer(emailP).then((data) => {
    //         console.log(data);
    //         setpr(data);
    //     }).catch((error) => {
    //         console.log(error);
    //     })
    // }, [pr])
    

    return <div id="edit-producer">
        <form action="updateProducer" onSubmit={updateProducerF}>
            <input type="text" onChange={e => setnameP(e.target.value)} value={nameP} /><br />
            <input type="text" onChange={e => setemailP(e.target.value)} value={emailP} /><br />
            <input type="text" onChange={e => setphoneP(e.target.value)} value={phoneP} /><br />
            <input type="text" onChange={e => setdescriptionP(e.target.value)} value={descriptionP} /><br />
            <button type="submit">keep</button>
        </form>
    </div>
}