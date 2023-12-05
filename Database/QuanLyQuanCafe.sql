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
	discount INT,
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

-- ngay 2
CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT Bill(DateCheckIn, DateCheckOut, idTable, status, discount) VALUES
	(GETDATE(), NULL, @idTable, 0, 0)
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	INSERT BillInfo(idBill, idFood, count) VALUES
	(@idBill, @idFood, @count)
END
GO

ALTER PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1

	SELECT @isExitsBillInfo = id, @foodCount = b.count FROM BillInfo AS b WHERE idBill = @idBill AND idFood = @idFood
	IF(@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount >0)
			UPDATE BillInfo SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT BillInfo(idBill, idFood, count) VALUES
		(@idBill, @idFood, @count)
	END

	
END
GO

UPDATE Bill SET status = 1 WHERE id = 1

CREATE TRIGGER UTG_UpdateBillInfo
ON BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = idBill FROM Inserted

	DECLARE @idTable INT
	SELECT @idTable = idTable FROM Bill WHERE id = @idBill AND status = 0		
	UPDATE TableFood SET status = N'Có người' WHERE id = @idTable
	
END
GO




CREATE TRIGGER UTG_UpdateBill
ON Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = id FROM Inserted
		
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM Bill WHERE id = @idBill 

	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM Bill WHERE idTable = @idTable AND status = 0

	IF(@count = 0)
		UPDATE TableFood SET status = N'Trống'
END
GO

ALTER TRIGGER UTG_UpdateBill
ON Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = id FROM Inserted
		
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM Bill WHERE id = @idBill 

	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM Bill WHERE idTable = @idTable AND status = 0

	IF(@count = 0)
		UPDATE TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

DELETE BillInfo
DELETE Bill

UPDATE Bill SET discount = 0;

SELECT * FROM Bill


--chuyen ban

--DECLARE @idBillNew INT = 19
--SELECT id INTO IDBillInfoTable FROM BillInfo WHERE idBill = @idBillNew

--DECLARE @idBillOld INT = 10

--UPDATE BillInfo SET idBill = @idBillOld WHERE id IN (SELECT * FROM IDBillInfoTable)

ALTER PROC USP_SwitchTable
@idTable1 INT, @idTable2 INT 
AS BEGIN
	DECLARE @idFirstBill INT
	DECLARE @idSeconrdBill INT
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	--first
	IF(@idFirstBill IS NULL)
	BEGIN
		INSERT Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES
		(GETDATE(), NULL, @idTable1, 0)

		SELECT @idFirstBill = MAX(id) FROM Bill WHERE idTable = @idTable1 AND status = 0
	END
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	--second
	IF(@idSeconrdBill IS NULL)
	BEGIN
		INSERT Bill(DateCheckIn, DateCheckOut, idTable, status) VALUES
		(GETDATE(), NULL, @idTable2, 0)

		SELECT @idSeconrdBill = MAX(id) FROM Bill WHERE idTable = @idTable2 AND status = 0
	END
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable

	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO

UPDATE TableFood SET status = N'Trống'

ALTER TABLE Bill ADD totalPrice FLOAT
DELETE Bill


alter PROC USP_GetListBillByDate
@checkIn DATE, @checkOut DATE
AS
BEGIN
	SELECT t.name as [Tên bàn], b.totalPrice as [Tổng tiền], DateCheckIn as [Ngày vào], DateCheckOut as [Ngày ra], discount as [Giảm giá] 
	FROM Bill as b, TableFood as t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1 AND t.id = b.idTable 
END
GO

Select * from Account

--fix bai 18 them sua xoa
CREATE TRIGGER UTG_DeleteBillInfo
ON BillInfo FOR DELETE
AS
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted

	DECLARE @idTable INT
	SELECT @idTable = idTable FROM Bill WHERE id = @idBill
	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM BillInfo AS bi, Bill as b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0

	IF(@count = 0)
		UPDATE TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

Select UserName, DisplayName, Type from Account