import { produce } from 'immer';
import { Data } from './Data';
import Swal from 'sweetalert2';
export const Reducer = produce((state, action) => {

    switch (action.type) {

        //#region user
        case 'SET_USERS':
            state.Users = action.payload
            break;
        case 'SET_USER_TYPES':
            state.UserTypes = action.payload
            break;
        case 'SET_CURRENT_USER':
            state.CurrentUser = action.payload
            sessionStorage.setItem("currentUser", JSON.stringify(action.payload))
            break;
 }

}, Data)