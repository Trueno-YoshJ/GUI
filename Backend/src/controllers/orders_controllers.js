import connection from '../config/db.js';


export const getAllOrders = (req, res) => {
  const query = 'SELECT * FROM orders';

  connection.query(query, (err, results) => {
    if (err) {
      return res.status(500).json({ error: err.message });
    }
    res.status(200).json(results);
  });
};

export const addOrder = (req, res) => {
  const { Product_name, Quantity, Order_Date } = req.body;

  const query = `INSERT INTO orders (Product_Name, Quantity, Order_Date) VALUES (?, ?, ?)`;
  connection.query(query, [Product_name, Quantity, Order_Date], (err, result) => {
    if (err) {
      return res.status(500).json({ error: err.message });
    }

  
    res.status(201).json({
      Orders_id: result.insertId, 
      Product_name,
      Quantity,
      Order_Date,
    });
  });
};

