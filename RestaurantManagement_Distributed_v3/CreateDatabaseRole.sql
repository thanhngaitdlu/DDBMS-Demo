USE [RestaurantManagement]
GO
CREATE ROLE [GIAMDOC]
GO
CREATE ROLE [QLCHINHANH]
GO
CREATE ROLE [NHANVIEN]
GO

ALTER ROLE [db_datareader] ADD MEMBER [GIAMDOC]
GO

ALTER ROLE [db_datareader] ADD MEMBER [NHANVIEN]
GO

ALTER ROLE [db_datawriter] ADD MEMBER [NHANVIEN]
GO

ALTER ROLE [db_owner] ADD MEMBER [QLCHINHANH]
GO