// api/authService.js
import axios from 'axios';

export const login = async ({ userName, password }) => {
  return await axios.post('/api/auth/login', { userName, password });
};

export const getProfile = async () => {
  const token = JSON.parse(localStorage.getItem('user'))?.token;
  return await axios.get('/api/user/profile', {
    headers: { Authorization: `Bearer ${token}` }
  });
};
