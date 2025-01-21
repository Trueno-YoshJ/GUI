import connection from '../config/db.js';

export const getAllFurniture = (req, res) => {
  const query = 'SELECT * FROM inventory';

  connection.query(query, (err, results) => {
    if (err) {
      return res.status(500).send({ error: err.message });
    }
    res.status(200).json(results);
  });
};
//Add item-->
export const addFurniture = (req, res) => {
  const { Product_Name, Type, Quantity, Price } = req.body;

  const query = `INSERT INTO inventory (Product_Name, Type, Quantity, Price) VALUES (?, ?, ?, ?)`;
  connection.query(query, [Product_Name, Type, Quantity, Price], (err, result) => {
    if (err) {
      return res.status(500).send({ error: err.message });
    }
    res.status(201).json({ id: result.insertId, Product_Name, Type, Quantity, Price });
  });
};

//update item-->
export const updateFurniture = (req, res) => {
  const { id } = req.params;
  const { Product_Name, Type, Quantity, Price } = req.body;

  const query = `UPDATE inventory SET Product_Name = ?, Type = ?, Quantity = ?, Price = ? WHERE Product_Id = ?`;
  connection.query(query, [Product_Name, Type, Quantity, Price, id], (err, result) => {
    if (err) {
      return res.status(500).send({ error: err.message });
    }
    if (result.affectedRows === 0) {
      return res.status(404).send({ error: 'Item not found' });
    }
    res.status(200).send({ message: 'Item updated successfully' });
  });
};

// Delete item-->
export const deleteFurniture = (req, res) => {
  const { id } = req.params;

  const query = `DELETE FROM inventory WHERE Product_Id = ?`;
  connection.query(query, [id], (err, result) => {
    if (err) {
      return res.status(500).send({ error: err.message });
    }
    if (result.affectedRows === 0) {
      return res.status(404).send({ error: 'Item not found' });
    }
    res.status(200).send({ message: 'Item deleted successfully' });
  });
};
