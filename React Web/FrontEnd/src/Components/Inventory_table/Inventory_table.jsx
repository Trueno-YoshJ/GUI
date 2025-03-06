import React, { useEffect, useState } from "react";
import axios from "axios";
import "./Furniture_table.css";

const FurnitureInventory = () => {
  const [furnitureData, setFurnitureData] = useState([]);
  const [formData, setFormData] = useState({
    Product_Name: "",
    Type: "",
    Quantity: "",
    Price: "",
  });
  const [updateData, setUpdateData] = useState({
    Product_Id: "",
    Product_Name: "",
    Type: "",
    Quantity: "",
    Price: "",
  });
  const [deleteId, setDeleteId] = useState("");

  useEffect(() => {
    const fetchFurnitureData = async () => {
      try {
        const response = await axios.get("http://localhost:5000/api/inventory");
        setFurnitureData(response.data);
      } catch (error) {
        console.error("Error fetching inventory data:", error);
      }
    };

    fetchFurnitureData();
  }, []);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleUpdateChange = (e) => {
    const { name, value } = e.target;
    setUpdateData({ ...updateData, [name]: value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      await axios.post("http://localhost:5000/api/inventory", formData);
      alert("Item added successfully!");

      setFormData({
        Product_Name: "",
        Type: "",
        Quantity: "",
        Price: "",
      });

      const response = await axios.get("http://localhost:5000/api/inventory");
      setFurnitureData(response.data);
    } catch (error) {
      console.error("Error adding item:", error);
      alert("Failed to add item.");
    }
  };

  const handleUpdateSubmit = async (e) => {
    e.preventDefault();
    try {
      await axios.put(
        `http://localhost:5000/api/inventory/${updateData.Product_Id}`,
        updateData
      );
      alert("Item updated successfully!");

      setUpdateData({
        Product_Id: "",
        Product_Name: "",
        Type: "",
        Quantity: "",
        Price: "",
      });

      const response = await axios.get("http://localhost:5000/api/inventory");
      setFurnitureData(response.data);
    } catch (error) {
      console.error("Error updating item:", error);
      alert("Failed to update item.");
    }
  };

  const handleDeleteSubmit = async (e) => {
    e.preventDefault();
    try {
      await axios.delete(`http://localhost:5000/api/inventory/${deleteId}`);
      alert("Item deleted successfully!");

      setDeleteId("");

      const response = await axios.get("http://localhost:5000/api/inventory");
      setFurnitureData(response.data);
    } catch (error) {
      console.error("Error deleting item:", error);
      alert("Failed to delete item.");
    }
  };

  return (
    <div className="table-container1">
      <p>Current Inventory</p>

      <table className="inventory-table">
        <thead>
          <tr>
            <th>Product ID</th>
            <th>Product Name</th>
            <th>Type</th>
            <th>Quantity</th>
            <th>Price</th>
          </tr>
        </thead>
        <tbody>
          {furnitureData.map((item) => (
            <tr key={item.Product_Id}>
              <td>{item.Product_Id}</td>
              <td>{item.Product_Name}</td>
              <td>{item.Type}</td>
              <td>{item.Quantity}</td>
              <td>{item.Price}</td>
            </tr>
          ))}
        </tbody>
      </table>

      <div className="form-container">
        <h2>Add New Item</h2>
        <form onSubmit={handleSubmit} className="form-horizontal">
          <div className="form-group">
            <label>Product Name:</label>
            <input
              type="text"
              name="Product_Name"
              value={formData.Product_Name}
              onChange={handleChange}
              required
            />
          </div>
          <div className="form-group">
            <label>Type:</label>
            <input
              type="text"
              name="Type"
              value={formData.Type}
              onChange={handleChange}
              required
            />
          </div>
          <div className="form-group">
            <label>Quantity:</label>
            <input
              type="number"
              name="Quantity"
              value={formData.Quantity}
              onChange={handleChange}
              required
            />
          </div>
          <div className="form-group">
            <label>Price:</label>
            <input
              type="number"
              name="Price"
              value={formData.Price}
              onChange={handleChange}
              required
            />
          </div>
          <button type="submit" className="submit-button">
            Add Item
          </button>
        </form>
      </div>
      <div className="form-container3">
        <h2>Delete Item</h2>
        <form onSubmit={handleDeleteSubmit} className="form-horizontal">
          <div className="form-group">
            <label>Product ID:</label>
            <input
              type="number"
              value={deleteId}
              onChange={(e) => setDeleteId(e.target.value)}
              required
            />
          </div>
          <button type="submit" className="submit-button delete-button">
            Delete Item
          </button>
        </form>
      </div>

      <div className="form-container2">
        <h2>Update Item</h2>
        <form onSubmit={handleUpdateSubmit} className="form-horizontal">
          <div className="form-group">
            <label>Product ID:</label>
            <input
              type="number"
              name="Product_Id"
              value={updateData.Product_Id}
              onChange={handleUpdateChange}
              required
            />
          </div>
          <div className="form-group">
            <label>Product Name:</label>
            <input
              type="text"
              name="Product_Name"
              value={updateData.Product_Name}
              onChange={handleUpdateChange}
              required
            />
          </div>
          <div className="form-group">
            <label>Type:</label>
            <input
              type="text"
              name="Type"
              value={updateData.Type}
              onChange={handleUpdateChange}
              required
            />
          </div>
          <div className="form-group">
            <label>Quantity:</label>
            <input
              type="number"
              name="Quantity"
              value={updateData.Quantity}
              onChange={handleUpdateChange}
              required
            />
          </div>
          <div className="form-group">
            <label>Price:</label>
            <input
              type="number"
              name="Price"
              value={updateData.Price}
              onChange={handleUpdateChange}
              required
            />
          </div>
          <button type="submit" className="submit-button">
            Update Item
          </button>
        </form>
      </div>
      
    </div>
  );
};

export default FurnitureInventory;
