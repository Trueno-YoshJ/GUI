import express from 'express';
import { getAllOrders, addOrder } from '../controllers/orders_controllers.js';

const router = express.Router();

router.get('/', getAllOrders);
router.post('/', addOrder);   

export default router;
