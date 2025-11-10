import React from 'react';
import '../AppStyles.css';

const Table = ({ columns, data, actions }) => (
  <table className="table">
    <thead>
      <tr>
        {columns.map((col) => <th key={col.key}>{col.header}</th>)}
        {actions && <th>Actions</th>}
      </tr>
    </thead>
    <tbody>
      {data.map((item) => (
        <tr key={item.id}>
          {columns.map((col) => <td key={col.key}>{item[col.key]}</td>)}
          {actions && (
            <td>
              {actions.map((action) => (
                <button key={action.label} onClick={() => action.onClick(item)}>
                  {action.label}
                </button>
              ))}
            </td>
          )}
        </tr>
      ))}
    </tbody>
  </table>
);
export default Table;
