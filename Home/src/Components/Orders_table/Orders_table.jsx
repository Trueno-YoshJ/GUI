import React, { useState } from 'react';
import './Orders_table.css'

const OrdersTable = () => {
  const [orders, setOrders] = useState([]); // To hold the orders
  const [orderId, setOrderId] = useState('');
  const [productName, setProductName] = useState('');
  const [quantity, setQuantity] = useState('');
  const [date, setDate] = useState('');

  const handleAddOrder = () => {
    if (!orderId || !productName || !quantity || !date) {
      alert('Please fill in all fields');
      return;
    }

    const newOrder = {
      orderId,
      productName,
      quantity,
      date,
    };

    setOrders([...orders, newOrder]);

    // Clear input fields
    setOrderId('');
    setProductName('');
    setQuantity('');
    setDate('');
  };

  return (
    <div className = "Container">
      <h2>Orders Table</h2>

      <div className ="Order-table">
        <input
          type="text"
          placeholder="Order ID"
          value={orderId}
          onChange={(e) => setOrderId(e.target.value)}
        />
        <input
          type="text"
          placeholder="Product Name"
          value={productName}
          onChange={(e) => setProductName(e.target.value)}
        />
        <input
          type="number"
          placeholder="Quantity"
          value={quantity}
          onChange={(e) => setQuantity(e.target.value)}
        />
        <input
          type="date"
          value={date}
          onChange={(e) => setDate(e.target.value)}
        />
        <button onClick={handleAddOrder}>Add Order</button>
      </div>

      <table border="1">
        <thead>
          <tr>
            <th>Order ID</th>
            <th>Product Name</th>
            <th>Quantity</th>
            <th>Date</th>
          </tr>
        </thead>
        <tbody>
          {orders.map((order, index) => (
            <tr key={index}>
              <td>{order.orderId}</td>
              <td>{order.productName}</td>
              <td>{order.quantity}</td>
              <td>{order.date}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default OrdersTable;
