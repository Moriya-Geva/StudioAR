import axios from "./BasicUrl"

export const getUsers = async () => {
    return await axios.get(`User`)
}

export const addNewUser = async (user, password) => {
    try {
        console.log('user api', user);
        const response = await axios.post(`User?password=${password}`, user);
        return response.data;
    } catch (error) {
        console.error("Error adding user:", error);
        throw error;
    }
};
