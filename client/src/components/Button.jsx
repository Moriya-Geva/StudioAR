import React from 'react';
import '../AppStyles.css';

const Button = ({ label, onClick, type = 'primary' }) => {
  const className = type === 'primary' 
    ? 'btn btn-primary' 
    : type === 'danger'
      ? 'btn btn-danger'
      : type === 'success'
        ? 'btn btn-success'
        : 'btn';

  return <button className={className} onClick={onClick}>{label}</button>;
};

export default Button;
