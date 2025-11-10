import React, { useState, useEffect } from 'react';
import Table from '../components/Table';
import Button from '../components/Button';
import Modal from '../components/Modal';
import { getOrders, createOrder, updateOrder, deleteOrder } from '../api/ordersService';

const OrdersPage = () => {
  const [orders, setOrders] = useState([]);
  const [modalOpen, setModalOpen] = useState(false);
  const [selectedOrder, setSelectedOrder] = useState(null);

  useEffect(() => {
    const fetchOrders = async () => {
      const data = await getOrders();
      setOrders(data);
    };
    fetchOrders();
  }, []);

  const columns = [
    { key: 'id', header: 'ID' },
    { key: 'orderNumber', header: 'Order Number' },
    { key: 'status', header: 'Status' },
    { key: 'requestedDate', header: 'Requested Date' },
    { key: 'finalPrice', header: 'Final Price' },
  ];

  const handleEdit = (order) => {
    setSelectedOrder(order);
    setModalOpen(true);
  };

  const handleDelete = async (order) => {
    await deleteOrder(order.id);
    setOrders(orders.filter(o => o.id !== order.id));
  };

  const handleSave = async (orderData) => {
    if (selectedOrder) {
      const updated = await updateOrder(selectedOrder.id, orderData);
      setOrders(orders.map(o => (o.id === updated.id ? updated : o)));
    } else {
      const created = await createOrder(orderData);
      setOrders([...orders, created]);
    }
    setModalOpen(false);
  };

  const actions = [
    { label: 'Edit', onClick: handleEdit },
    { label: 'Delete', onClick: handleDelete },
  ];

  return (
    <div>
      <h1>Orders</h1>
      <Button onClick={() => { setSelectedOrder(null); setModalOpen(true); }}>Add Order</Button>
      <Table columns={columns} data={orders} actions={actions} />

      {modalOpen && (
        <Modal onClose={() => setModalOpen(false)}>
          <h2>{selectedOrder ? 'Edit Order' : 'Add Order'}</h2>
          {/* כאן ניתן להכניס טופס CRUD */}
          <Button onClick={() => handleSave({ /* form data */ })}>Save</Button>
        </Modal>
      )}
    </div>
  );
};

export default OrdersPage;
