import React, { useState } from "react";
import { useDispatch } from "react-redux";
import { loginSuccess } from "../redux/authSlice";
import axios from "axios";
import '../AppStyles.css';


const LoginPage = () => {
  const dispatch = useDispatch();
  const [userName, setUserName] = useState("");
  const [password, setPassword] = useState("");
  
  const handleLogin = async (e) => {
    e.preventDefault();
    try {
      const res = await axios.post("/api/auth/login", { userName, password });
      dispatch(loginSuccess({ user: res.data.user, token: res.data.token }));
      alert("Login successful!");
      // Redirect לדשבורד לפי תפקיד
      if (res.data.user.userRole === "Admin") {
        window.location.href = "/admin/dashboard";
      } else {
        window.location.href = "/dashboard";
      }
    } catch (err) {
      console.error(err);
      alert(err.response?.data?.message || "Login failed!");
    }
  };

  return (
    <div className="login-page">
      <div className="login-container">
        <div className="login-image">
          {/* כאן אפשר לשים תמונת רקע של האולפן */}
          <img src="/studio-background.jpg" alt="Studio" />
        </div>
        <form className="login-form" onSubmit={handleLogin}>
          <h2>Login</h2>
          <input
            type="text"
            placeholder="Username"
            value={userName}
            onChange={(e) => setUserName(e.target.value)}
            required
          />
          <input
            type="password"
            placeholder="Password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
          />
          <button type="submit">Login</button>
        </form>
      </div>
    </div>
  );
};

export default LoginPage;
