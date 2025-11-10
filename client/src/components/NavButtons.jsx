import { Link } from 'react-router-dom';

const NavButtons = () => (
  <div className="nav-buttons">
    <Link to="/orders"><button className="btn primary">Go to Orders</button></Link>
    <Link to="/messages"><button className="btn primary">Go to Messages</button></Link>
    <button className="btn danger" style={{ marginLeft: 'auto' }}>Logout</button>
  </div>
);

export default NavButtons;
