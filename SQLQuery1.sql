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
10.
*/
USE master
DROP DATABASE QuanLyHSGVTHPT

CREATE DATABASE QuanLyHSGVTHPT
GO
USE QuanLyHSGVTHPT
GO

CREATE TABLE MonHoc(
	MaMon varchar(9),
	TenMon nvarchar(100) NULL,
	Khoi int NULL,
	CONSTRAINT PK_MonHoc PRIMARY KEY(MaMon),
)
GO
CREATE TABLE Lop(
	Malop varchar(9),
	TenLop nvarchar(50),
	NiemKhoa VARCHAR(10),
	CONSTRAINT PK_Lop PRIMARY KEY(Malop),
)
GO
CREATE TABLE GiaoVien(
	MaGV varchar(9),
	HoTen nvarchar(100) NULL,
	MaMon VARCHAR(9),
	NgaySinh date NULL,
	GioiTinh bit NULL,
	Sdt varchar(15) NULL,
	DiaChi nvarchar(150) NULL,
	CONSTRAINT PK_GiaoVien PRIMARY KEY(MaGV),
	CONSTRAINT FK_GiangDay FOREIGN KEY(MaMon) REFERENCES dbo.MonHoc(MaMon)
)
GO 


CREATE TABLE HocSinh(
	MaHS VARCHAR(9) NOT NULL,
	HoTen nvarchar(100) NULL,
	NgaySinh date NULL,
	DiaChi nvarchar(200) NULL,
	GioiTinh bit NULL,
	Sdt VARCHAR(15),
	TenPhuHuynh NVARCHAR(100) NOT NULL,
	SDTPhuHuynh VARCHAR(12),
	MaLop VARCHAR(9),
	CONSTRAINT PK_MaHS PRIMARY KEY(MaHS),
	CONSTRAINT FK_MaLop FOREIGN KEY(MaLop) REFERENCES dbo.Lop(Malop),
)  
GO
CREATE TABLE ChuNhiem(
	MaGV varchar(9),
	MaLop VARCHAR(9),
	NamHoc VARCHAR(10)
	PRIMARY KEY(MaGV,MaLop)	,
	CONSTRAINT FK_GiaoVien FOREIGN KEY(MaGV) REFERENCES dbo.GiaoVien(MaGV),
	CONSTRAINT FK_MaLop_Lop FOREIGN KEY(MaLop) REFERENCES dbo.Lop(Malop)
)  
GO
CREATE TABLE PhongHoc(
	MaPhong VARCHAR(9),
	SoPhong NVARCHAR(20),
	SoChoToiDa INT,
	CONSTRAINT PK_PhongHoc PRIMARY KEY(MaPhong),
	)
GO
    
CREATE TABLE PhongLop(
	MaPhong VARCHAR(9),
	MaLop VARCHAR(9),
	KipHoc NVARCHAR(20),
	HocKyNamHoc NVARCHAR(20),
	PRIMARY KEY(MaPhong,MaLop),
	FOREIGN KEY(MaPhong) REFERENCES dbo.PhongHoc(MaPhong),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(Malop)
	)
GO 
CREATE TABLE Diem(  
	MaHS varchar(9),
	MaMH VARCHAR(9) ,
	DiemMieng float NULL,
	Diem15p float NULL,
	Diem1h float NULL,
	DiemHK float NULL,
	PRIMARY KEY(MaHS,MaMH),
	FOREIGN KEY(MaHS) REFERENCES dbo.HocSinh(MaHS),
	FOREIGN KEY(MaMH) REFERENCES dbo.MonHoc(MaMon)
	
) 
GO

----------------------
CREATE TABLE TaiKhoan(
	TenTaiKhoan VARCHAR(50),
	MatKhau varchar(50) NOT NULL,
	Quyen INT NOT NULL,
	CONSTRAINT PK_Account PRIMARY KEY(TenTaiKhoan),
)
GO

CREATE TABLE LogUser(
	TaiKhoan VARCHAR(50)  PRIMARY KEY,
	TimeLogin DATETIME DEFAULT GETDATE(),
	ThaoTac TEXT
	FOREIGN KEY(TaiKhoan) REFERENCES dbo.TaiKhoan(TenTaiKhoan)
)
GO
USE QuanLyHSGVTHPT
INSERT INTO dbo.TaiKhoan
        ( TenTaiKhoan, MatKhau, Quyen )
VALUES  ( 'adm', -- TenTaiKhoan - varchar(50)
          '1', -- MatKhau - varchar(50)
          1  -- Quyen - int
          )
GO
SELECT * FROM dbo.TaiKhoan