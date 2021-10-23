--011_I Ketut Muliana_Assigment2

CREATE DATABASE db_assignment2;
use db_assignment2;

CREATE table tbl_productlines(
	productLine int not null primary key identity(1,1),
	textDescription varchar(500),
	htmlDescription varchar(500),
	imageUrl varchar(250)
);

CREATE table tbl_products(
	productCode int not null primary key identity(1,1),
	productName varchar(250),
	productScale varchar(250),
	productVendor varchar(250),
	productDescription varchar(500),
	quantityInStock int,
	buyPrice bigint,
	MSRP bigint,
	productLine int foreign key references tbl_productLines(productLine)
);

CREATE table tbl_offices(
	officeCode int not null primary key identity(1,1),
	city varchar(100),
	phone varchar(15),
	addressLine1 varchar(250),
	addressLine2 varchar(250),
	state varchar(100),
	country varchar(100),
	postalCode int,
	territory varchar(100)
);

CREATE table tbl_employees(
	employeeNumber int not null primary key identity(1,1),
	lastName varchar(100),
	firstName varchar(100),
	extension varchar(100),
	email varchar(100),
	reportsTo varchar(100),
	jobTitle varchar(100),
	officeCode int foreign key references tbl_offices(officeCode)
);

CREATE table tbl_customers(
	customerNumber int not null primary key identity(1,1),
	customerName varchar(100),
	contactLastName varchar(100),
	contactFirstName varchar(100),
	phone varchar(15),
	addressLine1 varchar(250),
	addressLine2 varchar(250),
	city varchar(100),
	state varchar(100),
	country varchar(100),
	postalCode int,
	creditLimit bigint,
	salesRepEmployeeNumber int foreign key references tbl_employees(employeeNumber)
);

CREATE table tbl_payments(
	checkNumber int not null primary key identity(1,1),
	paymentDate date,
	amount bigint,
	customerNumber int foreign key references tbl_customers(customerNumber)
);

CREATE table tbl_orders(
	orderNumber int not null primary key identity(1,1),
	orderDate date,
	requiredDate date,
	shippedDate date,
	status varchar(50),
	comments varchar(500),
	customerNumber int foreign key references tbl_customers(customerNumber)
);

CREATE table tbl_order_details(
	orderLineNumber int not null primary key identity(1,1),
	quantityOrdered int,
	priceEach bigint,
	orderNumber int foreign key references tbl_orders(orderNumber),
	productCode int foreign key references tbl_products(productCode)
);

INSERT INTO tbl_productlines(textDescription, htmlDescription, imageUrl)
VALUES('text description1','html description1','images url1'),
('text description2','html description2','images url2'),
('text description3','html description3','images url3'),
('text description4','html description4','images url4'),
('text description5','html description5','images url5')
;

SELECT tp.* FROM tbl_productlines tp order by tp.productLine desc;

INSERT INTO tbl_products(productName, productScale, productVendor, productDescription, quantityInStock, buyPrice, MSRP, productLine)
VALUES('product name1','product scale1','product vendor1','product description1',100,900000,1150000,1),
('product name2','product scale2','product vendor2','product description2',50,2000000,2250000,2),
('product name3','product scale3','product vendor3','product description3',10,1000000,1250000,3),
('product name4','product scale4','product vendor4','product description4',20,800000,1050000,4),
('product name5','product scale5','product vendor5','product description5',35,1200000,1450000,5)
;

SELECT tp.* FROM tbl_products tp order by tp.quantityInStock asc;

INSERT INTO tbl_offices(city, phone, addressLine1, addressLine2, state, country, postalCode, territory)
VALUES('Surabaya','082255889966','address line1','address line2','Indonesia','country1',113,'territory1'),
('Jakarta','082255889955','address line1','address line2','Indonesia','country2',113,'territory2'),
('Semarang','082255889944','address line1','address line2','Indonesia','countr3',113,'territory3'),
('Bandung','082255889933','address line1','address line2','Indonesia','countr4',113,'territory4'),
('Jogja','082255889922','address line1','address line2','Indonesia','country5',113,'territory5')
;

SELECT * FROM tbl_offices;

INSERT INTO tbl_employees(lastName, firstName, extension, email, reportsTo, jobTitle, officeCode)
VALUES('last name1','first name1','extension1','email1','report to1','job title1',1),
('last name2','first name2','extension2','email2','report to2','job title2',2),
('last name3','first name3','extension3','email3','report to3','job title3',3),
('last name4','first name4','extension4','email4','report to4','job title4',4),
('last name5','first name5','extension5','email5','report to5','job title5',5)
;

SELECT * FROM tbl_employees;

INSERT INTO tbl_customers(customerName, contactLastName, contactFirstName, phone, addressLine1, addressLine2, city, state, country, postalCode, creditLimit, salesRepEmployeeNumber)
VALUES('customer name1','contact last name1','contact first name1','082233445566','address line1','address line2','Surabaya','Indonesia','country1',113,5000000,1),
('customer name2','contact last name2','contact first name2','082233445577','address line1','address line2','Jakarta','Indonesia','country2',112,4500000,2),
('customer name3','contact last name3','contact first name3','082233445588','address line1','address line2','Bandung','Indonesia','country3',145,4000000,3),
('customer name4','contact last name4','contact first name4','082233445599','address line1','address line2','Semarang','Indonesia','country4',152,4500000,4),
('customer name5','contact last name5','contact first name5','082233445500','address line1','address line2','Bali','Indonesia','country5',131,3500000,5)
;

SELECT * FROM tbl_customers;

INSERT INTO tbl_payments(paymentDate, amount, customerNumber)
VALUES('2020-01-01 12:00:00',5000000,1),
('2020-02-01 11:3:00',5000000,2),
('2020-03-01 10:10:00',5000000,3),
('2020-02-01 11:10:00',5000000,4),
('2021-01-01 10:10:00',5000000,1)
;

SELECT * FROM tbl_payments;

INSERT INTO tbl_orders(orderDate, requiredDate, shippedDate, status, comments, customerNumber)
VALUES('2020-01-01 11:00:00','2020-01-02 11:00:00','2020-01-03 11:00:00','status1','comment1',1),
('2020-02-01 10:3:00','2020-02-02 10:3:00','2020-02-03 10:3:00','status2','comment2',2),
('2020-03-01 10:00:00','2020-03-02 10:00:00','2020-03-03 10:00:00','status3','comment3',3),
('2020-02-01 10:30:00','2020-02-02 10:30:00','2020-02-03 10:30:00','status4','comment4',4),
('2021-01-01 10:00:00','2021-01-02 10:00:00','2021-01-03 10:00:00','status1','comment1',1)
;

SELECT * FROM tbl_orders;

INSERT INTO tbl_order_details(quantityOrdered, priceEach, orderNumber, productCode)
VALUES(5,1000000,1,1),
(2,2500000,2,2),
(5,1000000,3,3),
(3,1000000,4,4),
(4,1000000,5,5)
;

SELECT * FROM tbl_order_details;

--store order sales oleh customer
SELECT to2.* FROM tbl_orders to2
WHERE to2.customerNumber = 1;

--store Item Order sales dalam setiap order sales
SELECT tod.* FROM tbl_order_details tod 
WHERE tod.orderNumber =1;

--store Pembayaran oleh customer sesuai dengan akun pembayaran
SELECT tp.* FROM tbl_payments tp
WHERE tp.customerNumber =1;

--store informasi karyawan dalam sebuah organisasi struktur
SELECT te.* FROM tbl_employees te 
WHERE te.officeCode = 1;

--store data sales office
SELECT * FROM tbl_offices;

