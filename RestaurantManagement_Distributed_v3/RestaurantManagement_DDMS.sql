USE [RestaurantManagement]
GO

CREATE TABLE [dbo].[Branch](
    [ID] [int] IDENTITY(1,1) PRIMARY KEY,
    [Name] [nvarchar](1000) NOT NULL,
    [Address] [nvarchar](1000) NOT NULL,
	[Status] bit NOT NULL
)
CREATE TABLE [dbo].[Table](
    [ID] [int] IDENTITY(1,1) PRIMARY KEY,
    [Name] [nvarchar](100) NOT NULL,
	[Status] [int] NOT NULL,
	[Capacity] [int] NOT NULL,
    [Floor] [int],
    [BranchId] [int] NOT NULL FOREIGN KEY REFERENCES Branch(ID)
)
CREATE TABLE [dbo].[Employee](
    [ID] [int] IDENTITY(1,1) PRIMARY KEY,
    [FirstName][nvarchar](100) NOT NULL,
    [LastName][nvarchar](100) NOT NULL,
    [DateOfBirth] [datetime] NOT NULL,
    [Address] [nvarchar](1000) NOT NULL,
    [Salary] [int] NOT NULL,
    [BranchId] [int] NOT NULL FOREIGN KEY REFERENCES Branch(ID),
	[Status] smallint NOT NULL -- 1: active, 0: inactive, 10: change branch
)
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) PRIMARY KEY,
	[Name] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL)

CREATE TABLE [dbo].[Food](
	[ID] [int] IDENTITY(1,1) PRIMARY KEY,
	[Name] [nvarchar](1000) NOT NULL,
	[Unit] [nvarchar](100) NOT NULL,
	[CategoryID] [int] NOT NULL FOREIGN KEY REFERENCES Category(ID),
	[Price] [int] NOT NULL,
	[Notes] [nvarchar](3000) NULL)

CREATE TABLE [dbo].[Bill](
	[ID] [int] IDENTITY(1,1) PRIMARY KEY,
	[Name] [nvarchar](1000) NOT NULL,
	[TableID] [int] NOT NULL FOREIGN KEY REFERENCES dbo.[Table](ID),
	[Amount] [int] NOT NULL,
	[Discount] [float] NULL,
	[Tax] [float] NULL,
	[Status] [bit] NOT NULL,
	[CheckoutDate] [smalldatetime] NULL,
	[EmployeeID] [int] NOT NULL FOREIGN KEY REFERENCES Employee(ID)
)
CREATE TABLE [dbo].[BillDetail](
	[ID] [int] IDENTITY(1,1) PRIMARY KEY,
	[BillID] [int] NOT NULL FOREIGN KEY REFERENCES Bill(ID),
	[FoodID] [int] NOT NULL FOREIGN KEY REFERENCES Food(ID),
	[Quantity] [int] NOT NULL,
    [CurrentUnitPrice] [int] NOT NULL
)

INSERT INTO Branch(Name, Address, Status) VALUES (N'Chi nhánh Đà Lạt', N'134 Phan Đình Phùng - Phường 2 - Đà Lạt',1)
INSERT INTO Branch(Name, Address, Status) VALUES (N'Chi nhánh Bảo Lộc', N'53 Hùng Vương - Phường 5 - Bảo Lộc', 1)

INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Nga', N'Phan Thanh', '2000-8-23', N'123 Phù Đổng Thiên Vương', 3000000, 1,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Ngan', N'Phạm Thị', '2000-8-23', N'45 Phù Đổng Thiên Vương', 4000000, 1,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Nhàn', N'Trần Thanh', '2000-8-23', N'23/2 Hùng Vương', 5000000, 2,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Huệ', N'Phan Nguyễn', '2000-8-23', N'107 Hai Bà Trưng', 3000000, 2,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Minh', N'Nguyễn Nhật', '2000-8-23', N'23/5 Mai Hắc Đế', 5000000, 1,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Hải', N'Vũ Thanh', '2000-8-23', N'34 Vạn Kiếp', 7000000, 1,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Tài', N'Phan Thái', '2000-8-23', N'111 Nguyễn Thị Minh Khai', 4000000, 2,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Phương', N'Trần Minh', '2000-8-23', N'289 Nguyễn Thiện Thuật', 5000000, 2,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Bảy', N'Nguyễn Thị', '2000-8-23', N'100 Phù Đổng Thiên Vương', 5000000, 2,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Khánh', N'Nguyễn Bảo', '2000-8-23', N'111 Nguyễn Thị Minh Khai', 3000000, 1,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Hoàng', N'Phạm Thanh', '2000-8-23', N'123 107 Hai Bà Trưng', 5000000, 1,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Thanh', N'Phan Thanh', '2000-8-23', N'123 Phù Đổng Thiên Vương', 7000000, 1,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Trang', N'Phạm Thị', '2000-8-23', N'45 Phù Đổng Thiên Vương', 5000000, 1,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Quyết', N'Trần Thanh', '2000-8-23', N'23/2 Hùng Vương', 5000000, 2,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Phương', N'Phan Nguyễn', '2000-8-23', N'107 Hai Bà Trưng', 7000000, 2,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Đăng', N'Nguyễn Nhật', '2000-8-23', N'23/5 Mai Hắc Đế', 5000000, 1,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Thúy', N'Vũ Thanh', '2000-8-23', N'34 Vạn Kiếp', 7000000, 1,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Thịnh', N'Phan Thái', '2000-8-23', N'111 Nguyễn Thị Minh Khai', 3000000, 2,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Quân', N'Trần Minh', '2000-8-23', N'289 Nguyễn Thiện Thuật', 4000000, 2,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Hoa', N'Nguyễn Thị', '2000-8-23', N'100 Phù Đổng Thiên Vương', 4000000, 2,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Ngọc', N'Nguyễn Bảo', '2000-8-23', N'111 Nguyễn Thị Minh Khai', 5000000, 1,1)
INSERT INTO Employee([FirstName], [LastName],[DateOfBirth],[Address],[Salary],[BranchID], [Status])VALUES (N'Thủy', N'Phạm Thanh', '2000-8-23', N'107 Hai Bà Trưng', 5000000, 1,1)

--delete from Employee
--dbcc checkident (Employee, reseed, 0)
--select * from Employee


INSERT [dbo].[Category] ([Name], [Type]) VALUES (N'Khai vị', 1)
INSERT [dbo].[Category] ([Name], [Type]) VALUES (N'Hải sản', 1)
INSERT [dbo].[Category] ([Name], [Type]) VALUES (N'Gà', 1)
INSERT [dbo].[Category] ([Name], [Type]) VALUES (N'Cơm', 1)
INSERT [dbo].[Category] ([Name], [Type]) VALUES (N'Thịt', 1)
INSERT [dbo].[Category] ([Name], [Type]) VALUES (N'Rau', 1)
INSERT [dbo].[Category] ([Name], [Type]) VALUES (N'Canh', 1)
INSERT [dbo].[Category] ([Name], [Type]) VALUES (N'Lẩu', 1)
INSERT [dbo].[Category] ([Name], [Type]) VALUES (N'Bia', 0)
INSERT [dbo].[Category] ([Name], [Type]) VALUES (N'Nước ngọt', 0)
INSERT [dbo].[Category] ([Name], [Type]) VALUES (N'Cà phê', 0)
INSERT [dbo].[Category] ([Name], [Type]) VALUES ( N'Trà đá', 0)

INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Rau muống xào tỏi', N'Đĩa', 6, 20000, NULL)
INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Cơm chiên Dương châu', N'Đĩa nhỏ', 4, 35000, N'3 người ăn')
INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Cơm chiên Dương châu', N'Đĩa lớn', 4, 40000, N'4 người ăn')
INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Ếch thui rơm', N'Đĩa', 2, 70000, NULL)
INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Sò lông nướng mỡ hành', N'Đĩa', 2, 80000, NULL)
INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Càng cua hấp', N'Đĩa', 2, 100000, NULL)
INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Canh cải', N'Tô', 8, 20000, NULL)
INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Gà nướng muối ớt', N'Con', 3, 180000, NULL)
INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Bia 333', N'Chai', 9, 12000, NULL)
INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Bia Heniken', N'Chai', 9, 20000, NULL)
INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Súp cua', N'Tô', 1, 15000, NULL)
INSERT [dbo].[Food] ([Name], [Unit], [CategoryID], [Price], [Notes]) VALUES (N'Thịt kho', N'Đĩa', 5, 25000, N'Theo thời giá')

INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'011', 0, 4,1,1)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'012', 0, 4,1,2)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'021', 0, 4,1,1)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'022', 0, 6,1,2)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'031', 0, 8,1,1)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'032', 0, 8,1,2)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'041', 0, 8,1,1)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'042', 0, 12,2,2)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'051', 0, 12,1,1)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'052', 0, 15,2,2)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'VIP.11', 0, 20,1,1)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'VIP.12', 0, 20,2,2)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'VIP.21', 0, 10,1,1)
INSERT [dbo].[Table] ([Name], [Status], [Capacity], [Floor], [BranchId]) VALUES (N'VIP.22', 0, 10,2,2)

INSERT INTO Bill([Name], [TableID], [Amount], [Status], [CheckoutDate], [EmployeeId]) VALUES (N'Chị Hà', 1, 250000, 1, '2021-02-03', 1)
INSERT INTO Bill([Name], [TableID], [Amount], [Status], [CheckoutDate], [EmployeeId]) VALUES (N'Chị Hương', 2, 120000, 1, '2021-03-23', 3)
INSERT INTO Bill([Name], [TableID], [Amount], [Status], [CheckoutDate], [EmployeeId]) VALUES (N'Chị Trà', 13, 120000, 1, '2021-02-16', 5)
INSERT INTO Bill([Name], [TableID], [Amount], [Status], [CheckoutDate], [EmployeeId]) VALUES (N'Anh Thành', 10, 240000, 1, '2021-01-08', 4)

INSERT INTO BillDetail([BillID], [FoodID], [Quantity], [CurrentUnitPrice]) VALUES (1, 1, 2, 20000)
INSERT INTO BillDetail([BillID], [FoodID], [Quantity], [CurrentUnitPrice]) VALUES (1, 2, 2, 35000)
INSERT INTO BillDetail([BillID], [FoodID], [Quantity], [CurrentUnitPrice]) VALUES (1, 4, 2, 70000)
INSERT INTO BillDetail([BillID], [FoodID], [Quantity], [CurrentUnitPrice]) VALUES (2, 6, 1, 100000)
INSERT INTO BillDetail([BillID], [FoodID], [Quantity], [CurrentUnitPrice]) VALUES (2, 7, 1, 20000)
INSERT INTO BillDetail([BillID], [FoodID], [Quantity], [CurrentUnitPrice]) VALUES (3, 3, 3, 40000)
INSERT INTO BillDetail([BillID], [FoodID], [Quantity], [CurrentUnitPrice]) VALUES (4, 9, 5, 12000)
INSERT INTO BillDetail([BillID], [FoodID], [Quantity], [CurrentUnitPrice]) VALUES (4, 8, 1, 180000)
INSERT INTO BillDetail([BillID], [FoodID], [Quantity], [CurrentUnitPrice]) VALUES (1, 2013, 12, 180000)
INSERT INTO BillDetail([BillID], [FoodID], [Quantity], [CurrentUnitPrice]) VALUES (1, 2014, 25, 180000)

-- Tao view lay thong tin cac phan manh
CREATE VIEW [dbo].View_DS_PHANMANH
AS
	SELECT TenCN=PUBS.description, Tenserver=SUBS.subscriber_server
	FROM dbo.sysmergepublications as PUBS, dbo.sysmergesubscriptions as SUBS
	WHERE PUBS.pubid = SUBS.pubid and PUBS.publisher <> SUBS.subscriber_server
GO

CREATE PROC sp_TaoTaiKhoan
	@LGNAME NVARCHAR(50),
	@PASS NVARCHAR(50),
	@USERNAME NVARCHAR(50),
	@ROLE NVARCHAR(50)
AS
BEGIN
	DECLARE @RET INT
	EXEC @RET = SP_ADDLOGIN @LGNAME, @PASS, 'RestaurantManagement'

	IF (@RET = 1) -- LGNAME BỊ TRÙNG
		RETURN 1

	EXEC @RET = SP_GRANTDBACCESS @LGNAME, @USERNAME
	IF (@RET = 1) -- USERNAME BI TRUNG
	BEGIN
		EXEC SP_DROPLOGIN @LGNAME
		RETURN 2
	END
	EXEC sp_addrolemember @ROLE, @USERNAME

	IF @ROLE = 'GIAMDOC'
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'

	END

	IF @ROLE = 'QLCHINHANH'
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
		  
	END
	IF @ROLE = 'NHANVIEN'
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

END
GO

CREATE PROC SP_LOGIN
@TenLogin nvarchar(50)
AS
BEGIN
	DECLARE @TenUser nvarchar(50)
	SELECT @TenUser = Name FROM sys.sysusers where sid = SUSER_SID(@TenLogin)
		SELECT MANV=@TenUser, ROLENAME = NAME
		FROM sys.sysusers 
		WHERE UID = (SELECT groupuid
						FROM sys.sysmembers
							WHERE memberuid = (SELECT UID FROM sys.sysusers
												WHERE Name = @TenUser))

END

CREATE PROC [dbo].[sp_GetAllEmployee]
AS
BEGIN
	Select * from Employee
END
GO