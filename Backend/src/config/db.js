import mysql from 'mysql2';
import dotenv from 'dotenv';

dotenv.config();

const connection = mysql.createConnection({
  host: process.env.DB_HOST,
  database: process.env.DB_NAME,
  user: process.env.DB_USER,
  password: process.env.DB_PASSWORD,
});

connection.connect((err) => {
  if (err) {
    console.error('DATABASE CONNECTION FAILED:', err.message);
    process.exit(1);
  }
  console.log('DATABASE CONNECTED');
});

export default connection;
