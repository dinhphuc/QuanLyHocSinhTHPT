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

CREATE DATABASE QuanLyHSGVTHPT
GO

USE QuanLyHSGVTHPT
GO

CREATE TABLE MonHoc(
	MaMon varchar(9) NOT NULL PRIMARY KEY,
	TenMon nvarchar(100) NULL,
	Khoi int NULL,
)
GO
CREATE TABLE Lop(
	Malop varchar(9) PRIMARY KEY,
	TenLop nvarchar(50),
	NiemKhoa VARCHAR(10)
)
GO
CREATE TABLE GiaoVien(
	MaGV varchar(9) NOT NULL PRIMARY KEY,
	HoTen nvarchar(100) NULL,
	NgaySinh date NULL,
	GioiTinh bit NULL,
	Sdt varchar(15) NULL,
	DiaChi nvarchar(150) NULL,
	MaMon VARCHAR(9) FOREIGN KEY(MaMon) REFERENCES dbo.MonHoc(MaMon)
)
GO 


CREATE TABLE HocSinh(
	MaHS VARCHAR(9) NOT NULL PRIMARY KEY,
	HoTen nvarchar(100) NULL,
	NgaySinh date NULL,
	DiaChi nvarchar(200) NULL,
	GioiTinh bit NULL,
	Sdt VARCHAR(15),
	TenBo nvarchar(100) NULL,
	TenMe nvarchar(100) NULL,
	MaLop VARCHAR(9) FOREIGN KEY(MaLop) REFERENCES dbo.Lop(Malop),
)  
GO
CREATE TABLE ChuNhiem(
	
	MaGV varchar(9),
	MaLop VARCHAR(9),
	NamHoc VARCHAR(10)
	PRIMARY KEY(MaGV,MaLop)	,
	FOREIGN KEY(MaGV) REFERENCES dbo.GiaoVien(MaGV),
	FOREIGN KEY(MaLop) REFERENCES dbo.Lop(Malop)

)  
GO
CREATE TABLE PhongHoc(
	MaPhong VARCHAR(9) NOT NULL PRIMARY KEY,
	SoPhong NVARCHAR(20),
	SoChoToiDa INT
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
	TenTaiKhoan VARCHAR(50) NOT NULL PRIMARY KEY,
	MatKhau varchar(50) NULL,
	LinkAvt VARCHAR(100) NULL
)
GO
CREATE TABLE LogUser(
	TenTaiKhoan VARCHAR(50)  PRIMARY KEY,
	TimeLogin DATETIME DEFAULT GETDATE(),
	ThaoTac TEXT
	FOREIGN KEY(TenTaiKhoan) REFERENCES dbo.TaiKhoan(TenTaiKhoan)
)
GO
