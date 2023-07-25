Use [ADO Assessment];


!--1 product prod_id(pk) cost 
!--2 custid(pk) name address 
!--3 salesid(pk) custid(fk) prod_id(fk) cost date

Create table menu 
(product_id nvarchar(10) primary key,product_name nvarchar(15) not null,cost money not null);

create table members
(member_id nvarchar(10) primary key,name nvarchar(40),address nvarchar(40));

create table sales
(
sales_id nvarchar(10) primary key,member_id nvarchar(10), product_id nvarchar(10)
FOREIGN KEY(member_id) REFERENCES members(member_id),
FOREIGN KEY(product_id) REFERENCES menu(product_id),
)

ALTER TABLE Sales ADD Date date ;

Alter table Sales alter Column Date date not null;

--1
Select Me.name,sum(m.cost) from 
sales S join menu M ON S.product_id = M.product_id join members Me on Me.member_id = S.member_id
group by Me.name;

--2
Select M.name,count(distinct(date)) AS "No of days visited" from sales S join members M On S.member_id =M.member_id group by M.name ;

--3
Select top 1 Me.product_name , count(Me.product_name) As Count  from sales S join menu Me On S.product_id = Me.product_id
group by Me.product_name  order by me.product_name desc;

--4
Select S.member_id , count(S.product_id) "No of products", SUM(M.cost) As "Amount" from Sales S join Menu M ON S.product_id = M.product_id group by member_id;

--5
Select S.member_id , sum(cost)*10 As Points  from sales S join menu M on S.product_id = M.product_id
group by S.member_id;