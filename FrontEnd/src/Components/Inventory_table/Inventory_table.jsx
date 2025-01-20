import furnitureData from "./Furniture_data";
import "./Furniture_table.css";

const FurnitureInventory = () => {
  return (
    <div className="table-container">
        <p>Current Inventory</p>
      <table className="inventory-table">
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Category</th>
            <th>Quantity</th>
            <th>Price</th>
            <th>Supplier</th>
            <th>Location</th>
          </tr>
        </thead>
        <tbody>
          {furnitureData.map((item) => (
            <tr key={item.id}>
              <td>{item.id}</td>
              <td>{item.name}</td>
              <td>{item.category}</td>
              <td>{item.quantity}</td>
              <td>${item.price.toFixed(2)}</td>
              <td>{item.supplier}</td>
              <td>{item.location}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default FurnitureInventory;
