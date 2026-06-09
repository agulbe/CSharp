CREATE TABLE clients (
	id INT PRIMARY KEY IDENTITY,
	name NVARCHAR(100) NOT NULL,
	email NVARCHAR(100) UNIQUE NOT NULL,
	phone NVARCHAR(20) NULL,
	address NVARCHAR(100) NULL,
	created_at DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL
);

INSERT INTO clients (name, email, phone, address) VALUES
('Bill Gates', 'bill.gates@microsoft.com', '+123-456-7890', '1 Microsoft Way, Redmond, WA'),
('Elon Musk', 'elon.musk@tesla.com', '+987-654-3210', '3500 Deer Creek Road, Palo Alto, CA'),
('Will Smith', 'will.smith@gmail.com', '+111-222-3333', '123 Hollywood Blvd, Los Angeles, CA'),
('Bob Marley', 'bob.marley@gmail.com', '+444-555-6666', '56 Reggae St, Kingston, Jamaica'),
('Cristiano Ronaldo', 'cristiano.ronaldo@gmail.com', '+777-888-9999', '123 Football St, Lisbon, Portugal'),
('Boris Johnson', 'boris.johnson@gmail.com', '+000-111-2222', '10 Downing St, London, UK');