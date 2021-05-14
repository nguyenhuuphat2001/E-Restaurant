Create database ERSystem
go
USE ERSystem
go

CREATE TABLE Staff
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	sex NVARCHAR(5) NOT NULL,
	email NVARCHAR(100),
	salary int NOT NULL,
	position INT NOT NULL  DEFAULT 0 -- 0: manager && 1: waiter && 2: chef
)

CREATE TABLE Account
(
id INT IDENTITY PRIMARY KEY,
idStaff INT NOT NULL,
userName NVARCHAR(100),	
passWord NVARCHAR(1000) NOT NULL DEFAULT 123456,

FOREIGN KEY (idStaff) REFERENCES dbo.Staff(id)
)

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	Type INT NOT NULL  DEFAULT 0 -- 0: Trống && 1: Có người 
)

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
 
CREATE TABLE Book
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	phone NVARCHAR(10) NOT NULL DEFAULT N'0123456789',
	dateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	idTable INT NOT NULL,
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán	

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)

--Thêm NV
INSERT INTO dbo.Staff
(
name,
email,
salary,
work_time
)
VALUES
('Huu Phat',
'nguyenhuuphat',
10000000,
'17:00:00')

INSERT INTO dbo.Staff
(
name,
email,
salary,
work_time
)
VALUES
('Duy Phuc',
'nguyenduyphuc',
99999999,
'7:00:00')

--Thêm TK
INSERT INTO dbo.Account
(
idStaff, 
UserName ,
PassWord ,
Type
)
VALUES  
(
1,
'huuphat' , 
'123456', 
1
)

INSERT INTO dbo.Account
(
idStaff, 
UserName ,
PassWord ,
Type
)
VALUES  
(
3,
'duyphuc' , 
'0123', 
0
)

-- thêm category
INSERT dbo.FoodCategory ( name )
VALUES  ( N'Hải sản')  
INSERT dbo.FoodCategory ( name )
VALUES  ( N'Nông sản' )
INSERT dbo.FoodCategory ( name )
VALUES  ( N'Lâm sản' )
INSERT dbo.FoodCategory ( name )
VALUES  ( N'Nước' )

-- thêm món ăn
INSERT dbo.Food ( name, idCategory, price )
VALUES  ( N'Mực một nắng nước sa tế', 1 , 120000)
INSERT dbo.Food ( name, idCategory, price )
VALUES  ( N'Nghêu hấp xả', 1, 50000)
INSERT dbo.Food ( name, idCategory, price )
VALUES  ( N'Dú dê nướng sữa', 2, 60000)
INSERT dbo.Food ( name, idCategory, price )
VALUES  ( N'Heo rừng nướng muối ớt', 3, 75000)
INSERT dbo.Food ( name, idCategory, price )
VALUES  ( N'Cơm chiên mushi', 2, 999999)
INSERT dbo.Food ( name, idCategory, price )
VALUES  ( N'7Up', 4, 15000)
INSERT dbo.Food ( name, idCategory, price )
VALUES  ( N'Cafe', 4, 12000)

--Procedure
CREATE PROC USP_Login
@userName varchar(100), @passWord varchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account
	WHERE UserName = @userName COLLATE SQL_Latin1_General_CP1_CS_AS
    AND PassWord = @passWord COLLATE SQL_Latin1_General_CP1_CS_AS
END
GO

CREATE PROC USP_GetPositionByUserName
@userName varchar(100)
AS 
BEGIN
	SELECT position FROM dbo.Account INNER JOIN dbo.Staff ON Staff.id = Account.idStaff
	WHERE UserName = @userName COLLATE SQL_Latin1_General_CP1_CS_AS
END
GO