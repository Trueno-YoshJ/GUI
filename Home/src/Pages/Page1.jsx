import logo from "../images/toplogo.png";
import top_image from "../images/inventory.png";
import SearchFilterBlock from "../Components/Search_filter/Search_filter";
import FurnitureInventory from "../Components/Inventory_table/Inventory_table";
import OrdersTable from "../Components/Orders_table/Orders_table";
import "./page1.css"

export function Page1() {
  return (
    <>
      <img src={logo} id="logo1" alt="logo" />
      <img src={top_image} id="top_image" alt="top_image" />

      <SearchFilterBlock />
      <div className="vertical-container">
        <div className="table-container">
          <FurnitureInventory />
        </div>
        <div className="Container">
          <OrdersTable />
        </div>
      </div>
    </>
  );
}
