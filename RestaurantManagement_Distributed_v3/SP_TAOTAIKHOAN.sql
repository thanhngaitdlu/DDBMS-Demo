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
		SELECT MANV=@TenUser, HoTen = (SELECT Ho, ' ', Ten FROM Employee where ID = @TenUser),
		ROLENAME = NAME
		FROM sys.sysusers 
		WHERE UID = (SELECT groupuid
						FROM sys.sysmembers
							WHERE memberuid = (SELECT UID FROM sys.sysusers
												WHERE Name = @TenUser))

END
-- SinhVien(masv, hoten, ngaysinh, malop)
-- Lop(ma lop, tenlop, malt, tenkhoa)
-- Monhoc(mamh, tenmh)
-- Hoc(masv, mamh, diem)
--SELECT DISTINCT MaMH
--FROM SinhVien, Hoc
--WHERE SinhVien.MaSV = Hoc.MaSV and malop = 'MT'

--SELECT DISTINCT MaMH
--FROM (SELECT MaSV from SinhVien WHERE MaLop = ‘MT)  Sv ,
---(SELECT MASV, MAMH FROM HOC ) hoc
--where sv.masv = hoc.masv
select * from sys.sysusers