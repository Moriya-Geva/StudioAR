import React, { useEffect, useState } from 'react';
import { getDashboardData } from '../api/dashboardService';
import Graph from '../components/Graph';
import Table from '../components/Table';

const DashboardPage = () => {
  const [stats, setStats] = useState({ orders: [], messages: [] });

  useEffect(() => {
    const fetchData = async () => {
      const data = await getDashboardData();
      setStats(data);
    };
    fetchData();
  }, []);

  const columns = [
    { key: 'id', header: 'ID' },
    { key: 'orderNumber', header: 'Order Number' },
    { key: 'status', header: 'Status' },
    { key: 'requestedDate', header: 'Requested Date' },
  ];

  return (
    <div>
      <h1>Dashboard</h1>
      <div style={{ display: 'flex', justifyContent: 'space-between' }}>
        <Graph title="Orders Overview" data={stats.orders} />
        <Graph title="Unread Messages" data={stats.messages} />
      </div>

      <h2>Recent Orders</h2>
      <Table columns={columns} data={stats.orders} />
    </div>
  );
};

export default DashboardPage;
