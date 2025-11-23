import React, { useState } from "react";
import { TextField, Button } from "@mui/material";
import { useDispatch } from "react-redux";
import { setCurrentUser } from "../redux/Actions";
import { useNavigate } from "react-router-dom";

export default function Login() {
  const dispatch = useDispatch();
  const navigate = useNavigate();

  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  const onSubmit = async (e) => {
    e.preventDefault();

    const response = await fetch("/api/auth/login", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ Email: email, Password: password }),
    });

    if (!response.ok) {
      alert("אימייל או סיסמה שגויים");
      return;
    }

    const user = await response.json(); // זה כולל גם UserRole
    dispatch(setCurrentUser(user));
    sessionStorage.setItem("currentUser", JSON.stringify(user));

    // ניווט לפי תפקיד
    if (user.UserRole === "Admin") navigate("/managerZone/Dashboard");
    else navigate("/UserZone/Dashboard");
  };

  return (
    <form onSubmit={onSubmit} dir="rtl">
      <TextField label="אימייל" fullWidth value={email} onChange={e => setEmail(e.target.value)} />
      <TextField label="סיסמה" type="password" fullWidth value={password} onChange={e => setPassword(e.target.value)} />
      <Button type="submit" variant="contained" style={{ marginTop: "20px" }}>כניסה</Button>
    </form>
  );
}
