import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import MainPage from './pages/MainPage';
import DashboardPage from './pages/DashboardPage';
import OrdersPage from './pages/OrdersPage';
import UsersPage from './pages/UsersPage';
import ChatPage from './pages/ChatPage';
import FAQPage from './pages/FAQPage';
import SettingsPage from './pages/SettingsPage';
import LoginPage from './pages/LoginPage';

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/login" element={<LoginPage />} />
        
        <Route path="" element={<LoginPage />} />
        <Route path="/" element={<MainPage />}>
         <Route path="/login" element={<Login />} />
          <Route path="/register" element={<Register />} />
        {/* <Route path="/admin/dashboard" element={<AdminDashboard />} />
        <Route path="/dashboard" element={<Dashboard />} /> */}
          <Route index element={<DashboardPage />} />
          <Route path="orders" element={<OrdersPage />} />
          <Route path="users" element={<UsersPage />} />
          <Route path="chat" element={<ChatPage />} />
          <Route path="faqs" element={<FAQPage />} />
          <Route path="settings" element={<SettingsPage />} />
        </Route>
      </Routes>
    </Router>
  );
}

export default App;
