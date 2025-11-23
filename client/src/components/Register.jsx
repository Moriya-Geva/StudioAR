import React, { useState } from "react";
import { TextField, Button } from "@mui/material";
import { useNavigate } from "react-router-dom";

export default function Register() {
  const navigate = useNavigate();
  const [userName, setUserName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  const onSubmit = async (e) => {
    e.preventDefault();

    const response = await fetch("/api/auth/register", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ UserName: userName, Email: email, Password: password }),
    });

    if (!response.ok) {
      alert("משהו השתבש בהרשמה");
      return;
    }

    alert("נרשמת בהצלחה! עכשיו התחבר/י");
    navigate("/Login");
  };

  return (
    <form onSubmit={onSubmit} dir="rtl">
      <TextField label="שם משתמש" fullWidth value={userName} onChange={e => setUserName(e.target.value)} />
      <TextField label="אימייל" fullWidth value={email} onChange={e => setEmail(e.target.value)} />
      <TextField label="סיסמה" type="password" fullWidth value={password} onChange={e => setPassword(e.target.value)} />
      <Button type="submit" variant="contained" style={{ marginTop: "20px" }}>הרשמה</Button>
    </form>
  );
}
