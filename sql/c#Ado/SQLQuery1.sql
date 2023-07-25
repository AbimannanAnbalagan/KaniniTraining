use ado;

CREATE TABLE CUSTOMER (cust_id int primary key , cust_name nvarchar(50), phone bigint , points int)

Create Table Product (prod_id int primary key ,prod_type nvarchar(30), prod_name nvarchar(50) , cost money , stock int)

Create Table "Order" (ord_id int primary key , cust_id int, "Product*Quantity" nvarchar(50) ,
TotalCost money , "Date" date
Foreign Key(cust_id) References Customer (cust_id))

Insert into CUSTOMER  values (1003 , 'Ramprakash' , 9874784875 , 879);

select * from customer
select * from Product
select * from "Order"

drop table "Order"
drop table CUSTOMER

Create table Customer (cust_id int Identity(1 , 1)  primary key , cust_name nvarchar(50), 
"password" nvarchar(50) not null, phone bigint, "address" nvarchar(40) , points bigint);

select count(cust_id) from customer where cust_id = 1 and password = 'abi0908';

Create table sales (ord_id int not null Default 1 , prod_name nvarchar(50) , cost money);
select * from sales;
Insert into sales(prod_name,cost) values('soap',50)
delete from sales

Select prod_name , cost from product where prod_id = 3;

update Product set stock = (select stock from Product where prod_id = 3 ) - 2 where prod_id = 3;

