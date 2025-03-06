import React, { useState, useEffect } from 'react';
import axios from 'axios';
import './Orders_table.css';

const OrdersTable = () => {
  const [orders, setOrders] = useState([]);
  const [productName, setProductName] = useState('');
  const [quantity, setQuantity] = useState('');
  const [date, setDate] = useState('');

  // Fetch all orders from the backend
  useEffect(() => {
    const fetchOrders = async () => {
      try {
        const response = await axios.get('http://localhost:5000/api/orders');
        console.log(response.data); // Log the data to verify the structure
        setOrders(response.data);
      } catch (error) {
        console.error('Error fetching orders:', error);
        alert('Failed to fetch orders. Please check your backend server.');
      }
    };

    fetchOrders();
  }, []);

  const handleAddOrder = async () => {
    if (!productName || !quantity || !date) {
      alert('Please fill in all fields');
      return;
    }

    const newOrder = {
      Product_name: productName, // Match database naming convention
      Quantity: parseInt(quantity, 10),
      Order_Date: date,
    };

    try {
      // Send the new order to the backend
      const response = await axios.post('http://localhost:5000/api/orders', newOrder);

      // Get the newly created order with its full details
      const createdOrder = response.data;

      // Update the orders state in real time with the full details
      setOrders([...orders, createdOrder]);

      // Clear the form fields
      setProductName('');
      setQuantity('');
      setDate('');
    } catch (error) {
      console.error('Error adding order:', error);
      alert('Failed to add order. Please check your backend server.');
    }
  };

  return (
    <div className="top-left-container">
      <h2>Orders Table</h2>

      <div className="order-form">
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
            <th>Order Date</th>
          </tr>
        </thead>
        <tbody>
          {orders.map((order) => (
            <tr key={order.Orders_id}>
              <td>{order.Orders_id}</td>
              <td>{order.Product_name}</td>
              <td>{order.Quantity}</td>
              <td>{new Date(order.Order_Date).toLocaleDateString()}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default OrdersTable;
