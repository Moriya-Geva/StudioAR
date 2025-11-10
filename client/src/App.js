import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import MainPage from './pages/MainPage';
import OrdersPage from './pages/OrdersPage';

function App() {
  return (
    <Router>
      <Routes>
        {/* MainPage הוא הדף הראשי עם ה-Sidebar */}
        <Route path="/" element={<MainPage />}>
          <Route path="orders" element={<OrdersPage />} />
        </Route>
      </Routes>
    </Router>
  );
}

export default App;

