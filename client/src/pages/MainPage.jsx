import { useSelector } from "react-redux";
import { Link,Outlet } from "react-router-dom";
import Avatar from "../components/Avatar";

const MainPage = () => {
  const { user } = useSelector((state) => state.auth);

  return (
    <div style={{ display: 'flex' }}>
      {/* Sidebar */}
      <nav style={{ width: '200px', padding: '20px', borderRight: '1px solid #ccc' }}>
        <h2>Menu</h2>
        <ul style={{ listStyle: 'none', padding: 0 }}>
          {user && (
            <>
              <li><Link to="/dashboard">Dashboard</Link></li>
              <li><Link to="/orders">Orders</Link></li>
              <li><Link to="/users">Users</Link></li>
              <li><Link to="/chat">Chat</Link></li>
              <li><Link to="/faqs">FAQ</Link></li>
              <li><Link to="/settings">Settings</Link></li>
            </>
          )}
        </ul>
      </nav>

      {/* Main content */}
      <main style={{ flex: 1, padding: '20px' }}>
        <div style={{ display: 'flex', justifyContent: 'flex-end' }}>
          {user ? (
            <Avatar />
          ) : (
            <Link to="/login">
              <button>Login</button>
            </Link>
          )}
        </div>
        <Outlet />
      </main>
    </div>
  );
};
export default MainPage;
