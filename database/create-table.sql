use master;
DROP DATABASE OnlineShopping;
CREATE DATABASE OnlineShopping;
go 
use OnlineShopping
--DROP TABLE users ;
go 
CREATE TABLE users (
	user_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	firstname nvarchar(255) NOT NULL,
	lastname nvarchar(255) NOT NULL,
	email nvarchar(255) NOT NULL,
	password nvarchar(255) NOT NULL,
	phone nvarchar(255) NOT NULL,
	type nvarchar(255) NOT NULL,
	created_at datetime NOT NULL,
)
go
CREATE TABLE categories (
	category_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	name nvarchar(255) NOT NULL,
	created_at datetime NOT NULL
)
go
CREATE TABLE products (
	product_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	name nvarchar(255) NOT NULL,
	description ntext NOT NULL,
	image nvarchar(255) NOT NULL,
	category_id int NOT NULL,
	quantity int NOT NULL,
	price int NOT NULL,
	created_at datetime NOT NULL,

	CONSTRAINT fk_categories_products FOREIGN KEY (category_id)
	REFERENCES categories(category_id)
)
go
CREATE TABLE orders (
	order_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	user_id int NOT NULL,
	shiping_address nvarchar(255) NOT NULL,
	created_at datetime NOT NULL,

	CONSTRAINT fk_user_order FOREIGN KEY (user_id)
	REFERENCES users(user_id)
)
go
CREATE TABLE order_details (
	order_details_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	order_id int NOT NULL,
	product_id int NOT NULL,
	quantity nvarchar(255) NOT NULL,

	CONSTRAINT fk_orders_order_details FOREIGN KEY (order_id)
	REFERENCES orders(order_id),

	CONSTRAINT fk_products_order_details FOREIGN KEY (product_id)
	REFERENCES products(product_id)
)
go
CREATE TABLE sales (
	sales_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	order_id int NOT NULL,
	sales_amount nvarchar(255) NOT NULL,
	created_at datetime NOT NULL,

	CONSTRAINT fk_orders_sales FOREIGN KEY (order_id)
	REFERENCES orders(order_id),
)
go
CREATE TABLE contact (
	contact_id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	email nvarchar(255) NOT NULL,
	message text NOT NULL,
	created_at datetime NOT NULL
)
go
insert into categories (name,created_at) values(N'THỰC PHẨM',GETDATE());
insert into categories (name,created_at) values(N'Điện thoại - Máy tính bảng',GETDATE());
insert into categories (name,created_at) values(N'Điện máy - Điện lạnh - Điện gia dụng',GETDATE());
insert into categories (name,created_at) values(N'ĐIỆN MÁY & CÔNG NGHỆ',GETDATE());
insert into categories (name,created_at) values(N'Thời trang nam',GETDATE());
insert into categories (name,created_at) values(N'NHÀ CỬA & ĐỜI SỐNG',GETDATE());
insert into categories (name,created_at) values(N'Sách, VPP & Âm nhạc',GETDATE());
insert into categories (name,created_at) values(N'Dụng cụ thể thao',GETDATE());
insert into categories (name,created_at) values(N'Ô tô - Xe máy',GETDATE());

select * from products