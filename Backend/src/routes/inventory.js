import express from 'express';
import {
  getAllFurniture,
  addFurniture,
  updateFurniture,
  deleteFurniture,
} from '../controllers/inventory_controllers.js';

const router = express.Router();

router.get('/', getAllFurniture);

router.post('/', addFurniture);

router.put('/:id', updateFurniture);

router.delete('/:id', deleteFurniture);

export default router;
