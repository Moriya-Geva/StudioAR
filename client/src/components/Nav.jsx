import { NavLink } from "react-router-dom"

export const Nav = () => {

    return <>
        <div className="nav">
            <NavLink to={"/Login"}>to login</NavLink>
            <NavLink to={"/Register"}>to register</NavLink>
            <NavLink to={"/About"}>about</NavLink>
            <NavLink to={"/Category"} >Category</NavLink>

        </div>
    </>
}