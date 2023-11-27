CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống' --Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	DisplayName	NVARCHAR(100) NOT NULL DEFAULT N'Phuc team',
	Type INT NOT NULL DEFAULT 0 --1: ad || 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY(idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0

	FOREIGN KEY(idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY(idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY(idFood) REFERENCES dbo.Food(id)
)
GO

INSERT INTO Account VALUES
('phuc', '180103', 'admin', 1),
('staff', '1', 'staff', 0)

SELECT UserName, DisplayName FROM Account
GO


--login && fix-injection
CREATE PROC USP_GetAccountByUserName
@userName NVARCHAR(100)
AS
BEGIN 
	SELECT * FROM dbo.Account WHERE UserName = @userName
End

EXEC dbo.USP_GetAccountByUserName @userName = N'phuc'


CREATE PROC USP_Login
@userName NVARCHAR(100), @passWord NVARCHAR(100)
AS
BEGIN 
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO


-- tableFood

DECLARE @i INT = 0

WHILE @i <= 20
BEGIN
	INSERT dbo.TableFood (name) VALUES (N'Bàn ' + CAST(@i AS NVARCHAR(100))) -- EP KIEU
	SET @i = @i + 1
END


SELECT * FROM TableFood


SELECT * FROM Account WHERE UserName = 'phuc' AND PassWord = '180103'


CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

UPDATE dbo.TableFood SET status = N'Có người' WHERE id = 6

EXEC dbo.USP_GetTableList

--THEM CATEGORY
INSERT INTO FoodCategory(name) VALUES
(N'Rang đậm'),
(N'Rang nâu'),
(N'Rang vừa'),
(N'Rang nhạt')

--THEM MON AN
INSERT INTO Food(name, idCategory, price) VALUES
(N'Cà phê Arabica', 1, 25000),
(N'Cà phê Typica', 2, 30000),
(N'Cà phê Cherry', 3, 25000),
(N'Cà phê Moka', 3, 40000),
(N'Cà phê Catimor', 3, 40000),
(N'Cà phê Ca Cao', 4, 40000),
(N'Cà phê Ý', 4, 40000)

--THEM BILL
INSERT INTO Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES
(GETDATE(), NULL, 1, 0),
(GETDATE(), NULL, 2, 0),
(GETDATE(), GETDATE(), 2, 1)


-- THEM BILL INFO
INSERT INTO BillInfo(idBill, idFood, count) VALUES
(1, 1, 2),
(1, 2, 4),
(2, 6, 4),
(2, 2, 4),
(3, 2, 4),
(3, 2, 4)



SELECT * FROM Bill WHERE idTable = 2 AND status = 1

SELECT * FROM BillInfo WHERE idBill =5

SELECT * FROM Bill
SELECT * FROM BillInfo
SELECT * FROM Food
SELECT * FROM FoodCategory



SELECT f.name, bi.count, f.price, f.price * bi.count AS totalPrice FROM BillInfo AS bi, Bill as b, Food as f
WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.idTable = 2