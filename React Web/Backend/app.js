import express from 'express';
import inventoryRoutes from './src/routes/inventory.js';
import dotenv from 'dotenv';
import cors from 'cors';
import OrdersRoutes from './src/routes/orders.js';

dotenv.config();
const app = express();
const PORT = process.env.PORT || 5000;

app.use(cors());
app.use(express.json());

app.use('/api/orders', OrdersRoutes);
app.use('/api/inventory', inventoryRoutes);

app.use((err, req, res, next) => {
  console.error('Error:', err.message);
  res.status(500).json({ error: 'Something went wrong!' });
});

app.listen(PORT, () => {
  console.log(`SERVER: http://localhost:${PORT}`);
});

