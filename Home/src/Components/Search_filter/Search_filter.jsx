import React, { useState } from "react";
import "./Search_filter.css";

const SearchFilterBlock = () => {

  const inventory = [
    { name: "Chairs", quantity: 30 },
    { name: "Tables", quantity: 15 },
    { name: "Desks", quantity: 10 },
    { name: "Sofas", quantity: 20 },
    { name: "Cabinets", quantity: 10 },
    { name: "Beds", quantity: 8 },
    { name: "Cupboards", quantity: 7 },
    { name: "Mattresses", quantity: 5 },
  ];

  const [searchQuery, setSearchQuery] = useState("");
  const [filteredItems, setFilteredItems] = useState([]);
  const [isTyping, setIsTyping] = useState(false);

  const handleSearchChange = (event) => {
    const query = event.target.value.toLowerCase();
    setSearchQuery(query);

    if (query.length > 0) {
      setIsTyping(true);
      const filtered = inventory.filter((item) =>
        item.name.toLowerCase().includes(query)
      );
      setFilteredItems(filtered);
    } else {
      setIsTyping(false);
      setFilteredItems([]);
    }
  };

  return (
    <div className="inventory-search">
      <div className="search-bar-container">
        {/* Search icon */}
        <span className="search-icon">🔍</span>

        {/* Search input */}
        <input
          type="text"
          className="search-bar"
          placeholder="Search for an item..."
          value={searchQuery}
          onChange={handleSearchChange}
        />
      </div>

      {/* Display results when typing */}
      {isTyping && filteredItems.length > 0 && (
        <ul className="inventory-list">
          {filteredItems.map((item, index) => (
            <li key={index} className="inventory-item">
              <span className="item-name">{item.name}</span>
              <span className="item-quantity">Quantity: {item.quantity}</span>
            </li>
          ))}
        </ul>
      )}
    </div>
  );
};

export default SearchFilterBlock;
