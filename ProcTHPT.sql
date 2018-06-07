/*
1. Lớp (Mã lớp, Tên lớp, Niên khóa)  
2. Giáo viên (Mã giáo viên, Họ tên, Ngày sinh, Địa chỉ, số điện thoại,ma  monhoc) 
3. Học sinh (Mã học sinh, Họ tên, Ngày sinh, Địa chỉ, số điện thoại  phụ huynh, Mã lớp) 
4. Chủ nhiệm (Mã giáo viên, Mã lớp, Năm học) 
5. Phòng học (Mã phòng, Số phòng, số chỗ tối đa) 
6. Phòng_lớp (Mã phòng, Mã lớp, Học kỳ_năm học, Kíp học) 
7. Môn học (Mã môn học, Tên môn học, Khối)
8. Điểm (Mã học sinh, Mã môn học, Điểm miệng, Điểm 15 phút, Điểm 1 tiết, điểm Học kỳ)   
9. Tài Khoản (Mã Học Sinh or (mã Giáo Viên) , Thời Gian đăng nhập, Quyền, Log, Avt)
*/
--1.lop--
CREATE PROC sp_InsLop(
	@MaLop VARCHAR(9),
	@TenLop NVARCHAR(100),
	@NienKhoa VARCHAR(10)
	)

AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.Lop WHERE Malop=@MaLop
	IF(@CheckID=0)
		INSERT INTO dbo.Lop
		        ( Malop, TenLop, NiemKhoa )
		VALUES  ( 
				@MaLop,
				@TenLop,
				@NienKhoa
		          )
END
GO

CREATE PROC sp_UpdateLop(
	@MaLop VARCHAR(9),
	@TenLop NVARCHAR(100),
	@NienKhoa VARCHAR(10)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.Lop WHERE Malop=@MaLop
	IF(@CheckID=1)
		UPDATE dbo.Lop SET Malop=@MaLop,TenLop=@TenLop,NiemKhoa=@NienKhoa WHERE Malop=@MaLop
	UPDATE dbo.HocSinh SET MaLop=@MaLop WHERE MaLop=@MaLop
END
GO
CREATE PROC sp_DelLop(@maLop VARCHAR(9))
AS
BEGIN
	DELETE dbo.Lop WHERE Malop=@maLop
	UPDATE dbo.HocSinh
	SET MaLop=NULL
	WHERE MaLop=@maLop
END
GO
--2.mon hoc
CREATE PROC sp_InsMonHoc(
	@MaMon varchar(9),
	@TenMon nvarchar(100),
	@Khoi int 
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.MonHoc WHERE MaMon=@MaMon
	IF(@CheckID=0)
	INSERT INTO dbo.MonHoc
	        ( MaMon, TenMon, Khoi )
	VALUES  ( 
			@MaMon,
			@TenMon,
			@Khoi
	          )
END
GO
CREATE PROC sp_UpdateMonHoc(
	@MaMon varchar(9),
	@TenMon nvarchar(100),
	@Khoi int
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.MonHoc WHERE MaMon=@MaMon
	IF(@CheckID=1)
	UPDATE dbo.MonHoc SET MaMon=@MaMon,TenMon=@TenMon,Khoi=@Khoi WHERE MaMon=@MaMon
END
GO
CREATE PROC sp_DelMonHoc(@maMon VARCHAR(9))
AS
BEGIN
	DELETE dbo.MonHoc WHERE MaMon=@maMon
	UPDATE dbo.GiaoVien
	SET MaMon=NULL
	WHERE MaMon=@maMon
END
GO
--3.phong hoc---
CREATE PROC sp_InsPhongHoc(
	@MaPhong VARCHAR(9) ,
	@SoPhong NVARCHAR(20),
	@SoChoToiDa INT)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.PhongHoc WHERE MaPhong=@MaPhong
	IF(@CheckID=0)
	INSERT INTO dbo.PhongHoc
	        ( MaPhong, SoPhong, SoChoToiDa )
	VALUES  ( @MaPhong,
			@SoPhong,
			@SoChoToiDa
	          )
END
GO
CREATE PROC sp_UpdatePhongHoc(
	@MaPhong VARCHAR(9) ,
	@SoPhong NVARCHAR(20),
	@SoChoToiDa INT
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.PhongHoc WHERE MaPhong=@MaPhong
	IF(@CheckID=1)
	UPDATE dbo.PhongHoc SET MaPhong=@MaPhong,SoPhong=@SoPhong,SoChoToiDa=@SoChoToiDa WHERE MaPhong=@MaPhong
END
GO
CREATE PROC sp_DelPhongHoc(@maPhong VARCHAR(9))
AS
BEGIN
	DELETE dbo.PhongHoc WHERE MaPhong=@maPhong
	UPDATE dbo.PhongLop
	SET MaPhong=NULL
	WHERE MaPhong=@maPhong
END
GO

--4.giao vien
CREATE PROC sp_InsGiaoVien(
	@MaGV varchar(9) ,
	@HoTen nvarchar(100) ,
	@NgaySinh date ,
	@GioiTinh bit ,
	@Sdt varchar(15),
	@DiaChi nvarchar(150) ,
	@MaMon VARCHAR(9) 
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.MonHoc WHERE MaMon=@MaMon
	IF(@CheckID=1)
		INSERT INTO dbo.GiaoVien
		        ( MaGV ,
		          HoTen ,
		          NgaySinh ,
		          GioiTinh ,
		          Sdt ,
		          DiaChi ,
		          MaMon
		        )
		VALUES  ( 
				@MaGV,
				@HoTen,
				@NgaySinh,
				@GioiTinh,
				@Sdt,
				@MaMon
		        )

END
GO
CREATE PROC sp_UpdateGiaoVien(
	@MaGV varchar(9) ,
	@HoTen nvarchar(100) ,
	@NgaySinh date ,
	@GioiTinh bit ,
	@Sdt varchar(15),
	@DiaChi nvarchar(150) ,
	@MaMon VARCHAR(9) 
)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.GiaoVien WHERE MaGV =@MaGV
	IF(@CheckID=1)
		UPDATE dbo.GiaoVien 
		SET MaGV =@MaGV,HoTen=@HoTen,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,Sdt=@Sdt,MaMon=@MaMon 
		WHERE MaGV=@MaGV
END
GO

CREATE PROC sp_DelGiaoVien(@maGV VARCHAR(9))
AS
BEGIN
	DELETE dbo.GiaoVien
	 WHERE MaGV=@maGV
END
GO

--5.hoc sinh
CREATE PROC sp_InsHocSinh(
	@MaHS VARCHAR(9) ,
	@HoTen nvarchar(100) ,
	@NgaySinh date ,
	@DiaChi nvarchar(200) ,
	@GioiTinh bit ,
	@Sdt VARCHAR(15),
	@TenBo nvarchar(100) ,
	@TenMe nvarchar(100),
	@MaLop VARCHAR(9)
	)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.Lop WHERE Malop=@MaLop
	IF(@CheckID=1)
		INSERT INTO dbo.HocSinh
		        ( MaHS ,
		          HoTen ,
		          NgaySinh ,
		          DiaChi ,
		          GioiTinh ,
		          Sdt ,
		          TenBo ,
		          TenMe ,
		          MaLop
		        )
		VALUES  ( 
		@MaHS ,
		@HoTen,
		@NgaySinh ,
		@DiaChi  ,
		@GioiTinh ,
		@Sdt ,
		@TenBo ,
		@TenMe ,
		@MaLop
)
END
GO
CREATE PROC sp_UpdateHocSinh(
	@MaHS VARCHAR(9) ,
	@HoTen nvarchar(100) ,
	@NgaySinh date ,
	@DiaChi nvarchar(200) ,
	@GioiTinh bit ,
	@Sdt VARCHAR(15),
	@TenBo nvarchar(100) ,
	@TenMe nvarchar(100),
	@MaLop VARCHAR(9)
)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.HocSinh WHERE MaHS=@MaHS
	IF(@CheckID=1)
	UPDATE dbo.HocSinh
	SET MaHS=@MaHS,HoTen=@HoTen,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,Sdt=@sdt,TenBo=@TenBo,TenMe=@TenMe
	WHERE MaHS=@MaHS
END
GO

CREATE PROC sp_DelHocSinh(@MaHS varchar(9))
AS
BEGIN
	DELETE dbo.HocSinh
	WHERE MaHS=@MaHS
END
GO

--6.chu nhiem--
CREATE PROC sp_InsChuNhiem(
	@MaGV varchar(9),
	@MaLop VARCHAR(9),
	@NamHoc varchar(10)
)
AS
BEGIN
	DECLARE @CheckID INT
	DECLARE @check INT 
	SELECT  @CheckID = COUNT(*) FROM dbo.Lop WHERE Malop=@MaLop
	SELECT @check =COUNT(*) FROM dbo.GiaoVien WHERE MaGV=@MaGV
	IF(@CheckID=1)
	INSERT INTO dbo.ChuNhiem
	( MaGV, MaLop, NamHoc )
	VALUES  ( 
	@MaGV,
	@MaLop,
	@NamHoc
	          )
END
GO

--7.diem

--tai khoan
CREATE PROC sp_InsTaiKhoan(
	@TenTaiKhoan VARCHAR(50) ,
	@MatKhau varchar(50) ,
	@LinkAvt VARCHAR(100)
	) 
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.TaiKhoan WHERE TenTaiKhoan=@TenTaiKhoan
	IF(@CheckID=0)
	INSERT INTO dbo.TaiKhoan
	        ( TenTaiKhoan, MatKhau, LinkAvt )
	VALUES  ( @TenTaiKhoan,
			@MatKhau,
			@LinkAvt
	          )
END
GO

CREATE PROC sp_UpdateTaiKhoan(
	@TenTaiKhoan VARCHAR(50) ,
	@MatKhau varchar(50) ,
	@LinkAvt VARCHAR(100)
	) 
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.TaiKhoan WHERE TenTaiKhoan=@TenTaiKhoan
	IF(@CheckID=1)
	UPDATE dbo.TaiKhoan SET TenTaiKhoan=@TenTaiKhoan,MatKhau=@MatKhau,LinkAvt=@LinkAvt
	WHERE TenTaiKhoan=@TenTaiKhoan
	UPDATE dbo.LogUser SET TenTaiKhoan=@TenTaiKhoan WHERE TenTaiKhoan=@TenTaiKhoan
END
--loguser
