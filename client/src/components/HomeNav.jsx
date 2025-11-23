import { useDispatch, useSelector } from "react-redux"
import { NavLink } from "react-router-dom"
// import { setUserTypes } from "../redux/Actions"
// import { useEffect } from "react"

export const HomeNav = () => {
const user = useSelector(state => state.CurrentUser);
    // const userTypes = useSelector(x => x.UserTypes)
    // let userType = user && userTypes.length > 0 ? userTypes.find(t => t.id == user.userTypeId).description : ''
    
    // let dis = useDispatch()

    // useEffect(() => {
    //     dis(setUserTypes())
    // }, []);

    return <nav className="homeNav">
        <img className="logo" src={`${process.env.PUBLIC_URL}/images/logo.png`}></img>
        <div className="links">
            <NavLink></NavLink>
             {!user && (
        <>
            <NavLink to="/Login">התחברות</NavLink>
            <NavLink to="/Register">הרשמה</NavLink>
        </>
    )}
    {user && (
        <>
            <button>אזור אישי</button>
            {/* <button onClick={logout}>התנתקות</button> */}
        </>
    )}
            {/* <NavLink to={"/LoginOrRegister/Login"}>התחברות/הרשמה</NavLink> */}
        </div>
    </nav>
}