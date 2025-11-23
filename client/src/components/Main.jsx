import { BrowserRouter } from "react-router-dom"
import { Routing } from "./Routing"
import './style.css'

import { Provider } from "react-redux"
import Store from '../redux/store'
export const Main = () => {
  // const { user } = useSelector((state) => state.auth);

return <>
        <Provider store={Store}>
            <BrowserRouter>
                <Routing></Routing>
            </BrowserRouter>
        </Provider>
    </>
    }
