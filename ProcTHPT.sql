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
ALTER PROC GetPointByID(@MaHS VARCHAR(10))
AS
	BEGIN
	SELECT Diem.MaHS,TenLop,HoTen,MaMH,TenMon,DiemMieng,Diem15p,Diem1h,DiemHK FROM dbo.Diem INNER JOIN dbo.HocSinh ON HocSinh.MaHS = Diem.MaHS
					    INNER JOIN dbo.MonHoc ON MonHoc.MaMon = Diem.MaMH
						INNER JOIN dbo.Lop ON Lop.Malop = HocSinh.MaLop 
						WHERE Diem.MaHS =@MaHS
	END
GO
EXEC dbo.GetPointByID @MaHS = '' -- varchar(10)
GO
CREATE PROC GetDataRoomClass
AS
	SELECT PhongHoc.MaPhong,SoPhong,Lop.Malop,TenLop,KipHoc,HocKyNamHoc FROM dbo.PhongLop INNER JOIN dbo.Lop ON Lop.Malop = PhongLop.MaLop
								INNER JOIN dbo.PhongHoc ON PhongHoc.MaPhong = PhongLop.MaPhong
GO
ALTER PROC InsertRoomClass
(
	@ID VARCHAR(9) ,
	@MaPhong VARCHAR(9) ,
	@MaLop VARCHAR(9) ,
	@KipHoc NVARCHAR(20),
	@HocKyNamHoc NVARCHAR(20) 

)
as
	BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.PhongHoc WHERE MaPhong=@MaPhong
	DECLARE @CheckID2 INT
	SELECT  @CheckID2 = COUNT(*) FROM dbo.Lop WHERE Malop=@MaLop
	DECLARE @CheckID3 INT
	SELECT  @CheckID3 = COUNT(*) FROM dbo.PhongLop WHERE ID=@ID
	IF(@CheckID3=0 AND @CheckID=1 AND @CheckID2=1)
		INSERT INTO dbo.PhongLop
		        (ID, MaPhong, MaLop, KipHoc, HocKyNamHoc )
		VALUES  ( @ID,
				  @MaPhong, -- MaPhong - varchar(9)
		          @MaLop, -- MaLop - varchar(9)
		          @KipHoc, -- KipHoc - nvarchar(20)
		          @HocKyNamHoc  -- HocKyNamHoc - nvarchar(20)
		          )
	ELSE
		RAISERROR('Trùng mã hoặc mã không tồn tại',12,1)
END			
go				
ALTER PROC EditRoomClass
(
	@ID VARCHAR(9) ,
	@MaPhong VARCHAR(9) ,
	@MaLop VARCHAR(9) ,
	@KipHoc NVARCHAR(20),
	@HocKyNamHoc NVARCHAR(20) 

)
as
	BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.PhongHoc WHERE MaPhong=@MaPhong
	DECLARE @CheckID2 INT
	SELECT  @CheckID2 = COUNT(*) FROM dbo.Lop WHERE Malop=@MaLop
	DECLARE @CheckID3 INT
	SELECT  @CheckID3 = COUNT(*) FROM dbo.PhongLop WHERE ID=@ID
	IF(@CheckID3=1 AND @CheckID=1 AND @CheckID2=1)
		UPDATE dbo.PhongLop SET MaPhong=@MaPhong,MaLop=@MaLop,KipHoc=@KipHoc,HocKyNamHoc=@HocKyNamHoc WHERE ID=@ID
	ELSE
		RAISERROR('Trùng mã hoặc mã không tồn tại',12,1)
END							
GO
CREATE PROC DelRoomClass(@ID VARCHAR(9))
AS
	BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.PhongLop WHERE ID=@ID
	IF @CheckID=1
		DELETE dbo.PhongLop WHERE ID=@ID
	ELSE
		RAISERROR('Mã không tồn tại',12,1)
	End



CREATE PROC DelHS(@MaHS VARCHAR(9))
AS
 BEGIN
 DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.HocSinh WHERE MaHS=@MaHS
	IF @CheckID=1
		BEGIN
	    UPDATE dbo.Diem SET MaHS='HSDEL' WHERE MaHS=@MaHS
		DELETE dbo.HocSinh WHERE MaHS=@MaHS
		END
	ELSE
		RAISERROR('Mã không tồn tại',12,1)

 END

GO
CREATE PROC InsDiem(
	@MaHS VARCHAR(9),
	@MaMH VARCHAR(9),
	@DiemMieng FLOAT ,
	@Diem15p FLOAT ,
	@Diem1h FLOAT ,
	@DiemHK FLOAT 
)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.HocSinh WHERE MaHS=@MaHS
	DECLARE @CheckID2 INT
	SELECT  @CheckID2 = COUNT(*) FROM dbo.MonHoc WHERE MaMon=@MaMH
	IF (@CheckID=1 AND @CheckID2=1)
		BEGIN
			INSERT INTO dbo.Diem
			        ( MaHS ,
			          MaMH ,
			          DiemMieng ,
			          Diem15p ,
			          Diem1h ,
			          DiemHK
			        )
			VALUES  ( @MaHS , -- MaHS - varchar(9)
			          @MaMH , -- MaMH - varchar(9)
			          @DiemMieng , -- DiemMieng - float
			          @Diem15p , -- Diem15p - float
			          @Diem1h , -- Diem1h - float
			          @DiemHK  -- DiemHK - float
			        )
		END
	ELSE
		RAISERROR('Mã không tồn tại',12,1)

 END

 GO
 
 CREATE PROC EditDiem(
	@MaHS VARCHAR(9),
	@MaMH VARCHAR(9),
	@DiemMieng FLOAT ,
	@Diem15p FLOAT ,
	@Diem1h FLOAT ,
	@DiemHK FLOAT 
)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.HocSinh WHERE MaHS=@MaHS
	DECLARE @CheckID2 INT
	SELECT  @CheckID2 = COUNT(*) FROM dbo.MonHoc WHERE MaMon=@MaMH
	IF (@CheckID=1 AND @CheckID2=1)
		BEGIN
			UPDATE Diem SET 
			          DiemMieng = @DiemMieng,
			          Diem15p = @Diem15p,
			          Diem1h = @Diem1h,
			          DiemHK= @DiemHK
			       WHERE MaHS=@MaHS AND MaMH=@MaMH
		END
	ELSE
		RAISERROR('Mã không tồn tại',12,1)

 END

GO

CREATE PROC DelDiem(
	@MaHS VARCHAR(9),
	@MaMH VARCHAR(9)
)
AS
BEGIN
	DECLARE @CheckID INT
	SELECT  @CheckID = COUNT(*) FROM dbo.HocSinh WHERE MaHS=@MaHS
	DECLARE @CheckID2 INT
	SELECT  @CheckID2 = COUNT(*) FROM dbo.MonHoc WHERE MaMon=@MaMH
	IF (@CheckID=1 AND @CheckID2=1)
		BEGIN
			DELETE dbo.Diem WHERE MaHS=@MaHS AND MaMH =@MaMH
		END
	ELSE
		RAISERROR('Mã không tồn tại',12,1)

 END
USE [QuanLyHSGVTHPT]
GO
/****** Object:  StoredProcedure [dbo].[sp_insChuNhiem]    Script Date: 06/10/2018 2:45:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_insChuNhiem](
@MaGV varchar(9),
@MaLop varchar(9),
@NamHoc varchar(10)
)
AS 
BEGIN 
	DECLARE @CheckID INT 
	DECLARE @CheckID1 INT 
	SELECT @CheckID =count (*) FROM dbo.GiaoVien WHERE MaGV=@MaGV
	SELECT @CheckID1=COUNT(*) FROM lop WHERE Malop=@MaLop
	IF (@CheckID=1 AND @CheckID1=1)
	INSERT INTO dbo.ChuNhiem
	        ( MaGV, MaLop, NamHoc )
	VALUES  ( @MaGV, -- MaGV - varchar(9)
	          @MaLop, -- MaLop - varchar(9)
	          @NamHoc  -- NamHoc - varchar(10)
	          )
END
GO
USE [QuanLyHSGVTHPT]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateChuNhiem]    Script Date: 06/10/2018 2:46:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateChuNhiem](
@MaGV varchar(9),
@MaLop varchar(9),
@NamHoc varchar(10))
AS 
BEGIN 
	DECLARE @CheckID INT 
	DECLARE @CheckID1 INT 
	SELECT @CheckID =count (*) FROM dbo.GiaoVien WHERE MaGV=@MaGV
	SELECT @CheckID1=COUNT(*) FROM dbo.Lop WHERE Malop=@MaLop
	IF (@CheckID=1 AND @CheckID1=1)
	UPDATE dbo.ChuNhiem 
	SET MaGV=@MaGV, MaLop=@MaLop,NamHoc=@NamHoc
	WHERE  MaGV=@MaGV AND  MaLop=@MaLop
END 
GO
USE [QuanLyHSGVTHPT]
GO
/****** Object:  StoredProcedure [dbo].[sp_DelChuNhiem]    Script Date: 06/10/2018 2:44:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DelChuNhiem]
(
@MaGV varchar(9),
@MaLop varchar(9)
)
AS 
BEGIN
	DECLARE @CheckID INT 
	DECLARE @CheckID1 INT 
	SELECT @CheckID =count (*) FROM dbo.GiaoVien WHERE MaGV=@MaGV
	SELECT @CheckID1=COUNT(*) FROM dbo.Lop WHERE Malop=@MaLop
	IF (@CheckID=1 AND @CheckID1=1)
	DELETE dbo.ChuNhiem 
	WHERE MaGV=@MaGV AND MaLop=@MaLop
END 
