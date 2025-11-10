// components/Avatar.jsx
import React, { useState } from 'react';
import Modal from './Modal';
import { useSelector, useDispatch } from 'react-redux';
import { logout, updateUser } from '../redux/slices/usersSlice';
const Avatar = () => {
  const user = useSelector(state => state.user.user);
  const dispatch = useDispatch();
  const [open, setOpen] = useState(false);

  const handleLogout = () => dispatch(logout());

  return (
    <div className="avatar-container">
      <div className="avatar" onClick={() => setOpen(true)}>
        {user?.name[0].toUpperCase()}
      </div>

      {open && (
        <Modal onClose={() => setOpen(false)}>
          <h3>{user.name}</h3>
          <button onClick={handleLogout}>Logout</button>
          <button>Edit Profile</button>
          <button>Delete Account</button>
          <button>View Status / History</button>
        </Modal>
      )}
    </div>
  );
};

export default Avatar;
