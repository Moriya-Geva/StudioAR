import { addNewUser, getUsers } from "../Functions/ApiRequests/User"
import { getUserTypes } from "../Functions/ApiRequests/UserType"

//#region user

    export const setUsers = () => async (dis) => {
        try {
            const response = await getUsers()
            dis({ type: 'SET_USERS', payload: response.data })
        } catch (error) {
            console.error("Error fetching users:", error);
        }
    }

    export const setUserTypes = () => async (dis) => {
        try {
            const response = await getUserTypes()
            dis({ type: 'SET_USER_TYPES', payload: response.data })
        } catch (error) {
            console.error("Error fetching user types:", error);
        }
    }

    export const addUser = (user) => async (dis) => {
        try {
            const response = await addNewUser(user)
            dis({ type: 'SET_USERS', payload: response.data })
        } catch (error) {
            console.error("Error post user:", error);
        }

    }

    export const setCurrentUser = (user) => {
        return { type: 'SET_CURRENT_USER', payload: user }
    }