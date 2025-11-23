import React from 'react';
import { Route, Routes } from "react-router"
import { Home } from "./Home"
export const Routing = () => {
  return (
      <Routes>
        <Route path="" element={<Home></Home>}></Route>
        <Route path="Home" element={<Home></Home>}></Route>
      </Routes>
  );
}
