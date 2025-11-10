import React from 'react';
import '../AppStyles.css';

const Modal = ({ isOpen, title, children, onClose }) => (
  isOpen ? (
    <div className="modal-backdrop">
      <div className="modal">
        <h2>{title}</h2>
        {children}
        <button onClick={onClose}>Close</button>
      </div>
    </div>
  ) : null
);

export default Modal;
