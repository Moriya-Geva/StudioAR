import axios from "axios";

const API_URL = "https://localhost:7015/api"; 

export const loginUser = async (credentials) => {
  const res = await axios.post(`${API_URL}/auth/login`, credentials);
  return res.data; // { token, user }
};

export const registerUser = async (data) => {
  const res = await axios.post(`${API_URL}/auth/register`, data);
  return res.data;
};
