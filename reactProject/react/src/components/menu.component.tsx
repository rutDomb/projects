import { NavLink } from "react-router";

export const Menu=()=>{
    return <nav>
        {/* יצירה של כפתור קישור, לחיצה על הקישור משנה את שורת ה url ללא ריענון של העמוד */}
        {/* <NavLink to="/">EVENTS</NavLink> <br/> */}
        <NavLink to="/SubProducer">Producer</NavLink> <br/>
        <NavLink to="/user"> User </NavLink>
    </nav>
}