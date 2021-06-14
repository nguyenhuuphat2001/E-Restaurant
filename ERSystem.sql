Create database ERSystem
go
USE ERSystem
GO

set dateformat dmy
CREATE TABLE Staff
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL,
	sex NVARCHAR(5) NOT NULL,
	email NVARCHAR(100) UNIQUE,
	phone VARCHAR(10) UNIQUE,
	salary int NOT NULL,
	position INT NOT NULL  DEFAULT 0 -- 0: manager && 1: waiter && 2: chef
)
GO

CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	idStaff INT NOT NULL UNIQUE,
	userName VARCHAR(100) UNIQUE,	
	passWord VARCHAR(1000) NOT NULL DEFAULT '123456',

	FOREIGN KEY (idStaff) REFERENCES dbo.Staff(id)
)
GO


CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name VARCHAR(100) NOT NULL DEFAULT 'No name',
	status VARCHAR(100) NOT NULL DEFAULT 'Empty'	-- Empty || Using
)
GO
SET IDENTITY_INSERT TableFood On
INSERT TableFood (id,name,status) VALUES (1,'Năm','Trống')
INSERT TableFood (id,name,status) VALUES (2,'BA','Full')


CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'No name'
)
GO

Insert into FoodCategory values ('avc')
select * from FoodCategory
select * from FoodCategory fc where fc.name like N'%ả%'

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'No name',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
)

SELECT * FROM Food
SELECT * FROM FoodCategory

	ALTER TABLE Food 
	ADD CONSTRAINT FK_idCategory
	FOREIGN KEY (idCategory) 
	REFERENCES FoodCategory (id)


select FoodCategory.id from FoodCategory where FoodCategory.name = N'Nước'


INSERT dbo.Food ( name, idCategory, price )
VALUES  ( N'Mojt', 9, 12000)

set IDENTITY_INSERT Food OFF
 
CREATE TABLE Book
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	phone NVARCHAR(10) NOT NULL DEFAULT N'0123456789',
	dateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	idTable INT NOT NULL,
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

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
GO

--Thêm NV
INSERT INTO dbo.Staff
(
    name,
    sex,
    email,
    phone,
    salary,
    position
)
VALUES
(   N'Duy Phúc',  -- name - nvarchar(100)
    1, -- sex - bit
    '19522038@gm.uit.edu.vn',   -- email - varchar(100)
    '1234',   -- phone - varchar(100)
    10000,    -- salary - int
    0     -- position - int
    )
GO

INSERT INTO dbo.Staff
(
    name,
    sex,
    email,
    phone,
    salary,
    position
)
VALUES
(   N'Doãn Thịnh',  -- name - nvarchar(100)
    1, -- sex - bit
    '1952@gm.uit.edu.vn',   -- email - varchar(100)
    '1351351',   -- phone - varchar(100)
    10000,    -- salary - int
    1     -- position - int
    )
GO

INSERT INTO dbo.Staff
(
    name,
    sex,
    email,
    phone,
    salary,
    position
)
VALUES
(   N'Xuân Thái',  -- name - nvarchar(100)
    1, -- sex - bit
    '19wr23r52@gm.uit.edu.vn',   -- email - varchar(100)
    '1232342',   -- phone - varchar(100)
    10000,    -- salary - int
    2     -- position - int
    )
GO

INSERT INTO dbo.Staff
(
    name,
    sex,
    email,
    phone,
    salary,
    position
)
VALUES
(   N'Hữu Phát',  -- name - nvarchar(100)
    1, -- sex - bit
    '195r3r2@gm.uit.edu.vn',   -- email - varchar(100)
    '122342334',   -- phone - varchar(100)
    10000,    -- salary - int
    1     -- position - int
    )
GO

--Thêm TK
INSERT INTO dbo.Account
(
	idStaff, 
	UserName 
)
VALUES  
(
	13,
	'manager'
)
GO

INSERT INTO dbo.Account
(
	idStaff, 
	UserName 
)
VALUES  
(
	14,
	'waiter'
)
GO

INSERT INTO dbo.Account
(
	idStaff, 
	UserName 
)
VALUES  
(
	15,
	'chef'
)
GO


-- thêm category
INSERT dbo.FoodCategory ( name )
VALUES  ( N'Hải sản')  
INSERT dbo.FoodCategory ( name )
VALUES  ( N'Nông sản' )
INSERT dbo.FoodCategory ( name )
VALUES  ( N'Lâm sản' )
INSERT dbo.FoodCategory ( name )
VALUES  ( N'Nước' )
GO




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
GO

Select food.id from Food where food.name = 'Cafe'
Delete from Food where food.id = 17

INSERT TableFood (name,id,status)

--Thêm bàn
DECLARE @i INT = 1
WHILE @i <= 10
BEGIN
	INSERT dbo.TableFood (name) VALUES  ( 'Table ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO

-- thêm bill
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          3 , -- idTable - int
          0  -- status - int
        )        
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          4, -- idTable - int
          0  -- status - int
        )
INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() , -- DateCheckIn - date
          GETDATE() , -- DateCheckOut - date
          5 , -- idTable - int
          1  -- status - int
        )
GO 

-- thêm bill info
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          3, -- idFood - int
          4  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, -- idBill - int
          5, -- idFood - int
          1  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 6, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 2, -- idBill - int
          6, -- idFood - int
          2  -- count - int
          )
INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 3, -- idBill - int
          5, -- idFood - int
          2  -- count - int
          )   
GO

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