CREATE TABLE clients(
	id INT NOT NULL PRIMARY KEY IDENTITY,
	pname VARCHAR(45) NOT NULL,
	ptype VARCHAR(45) NOT NULL,
	qty INT NOT NULL,
	price INT NOT NULL,
);

INSERT INTO clients(pname,ptype,qty,price)
VALUES
('Rattan Chair','Chair','16','250'),
('Office Table','Table','8','350') 