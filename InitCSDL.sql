/*
1. Lớp (Mã lớp, Tên lớp, Niên khóa)  
2. Giáo viên (Mã giáo viên, Họ tên, Ngày sinh, Địa chỉ, số điện thoại,ma  monhoc) 
3. Học sinh (Mã học sinh, Họ tên, Ngày sinh, Địa chỉ, số điện thoạiPH, tên phụ huynh,dân tộc, tôn giáo, Mã lớp) 
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
/--Thêm dân tôc, tôn giáo, tên và sdtPH--/

CREATE TABLE HocSinh(
	MaHS VARCHAR(9) NOT NULL PRIMARY KEY,
	HoTen nvarchar(100) NULL,
	NgaySinh date NULL,
	DiaChi nvarchar(200) NULL,
	GioiTinh bit NULL,
	Sdt VARCHAR(15),
	Dantoc nvarchar(15),
	Tongiao nvarchar(15),
	TenPH nvarchar(15) NULL,
	SDTPH varchar(15) NULL,
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
CREATE TABLE Account(
	TaiKhoan VARCHAR(50) NOT NULL PRIMARY KEY,
	MatKhau varchar(50) NULL,
	LinkAvt VARCHAR(100) NULL
)
GO

CREATE TABLE LogUser(
	TaiKhoan VARCHAR(50)  PRIMARY KEY,
	TimeLogin DATETIME DEFAULT GETDATE(),
	ThaoTac TEXT
	FOREIGN KEY(TaiKhoan) REFERENCES dbo.Account(TaiKhoan)
)
GO


insert dbo.PhongLop (MaPhong, MaLop, KipHoc, HocKyNamHoc) values ('P01','L01',N'Sáng', N'Học Kỳ 1')


insert dbo.HocSinh (MaHS, HoTen,GioiTinh,NgaySinh ,Dantoc, Sdt, DiaChi ,Tongiao, MaLop, TenPH, SDTPH)
values ('HS01', N'Cao Xuân Tuấn', 1 , '06-08-1996', N'Kinh', '01667023707', N'Nghệ An', N'Kinh', N'L01', 'Cao Xuan Phuong', '012345789')

insert dbo.HocSinh (MaHS, HoTen,GioiTinh,NgaySinh ,Dantoc, Sdt, DiaChi ,Tongiao, MaLop, TenPH, SDTPH)
values ('HS02', N'Lê Anh Đức', 1 , '01-08-1996', N'Kinh', '0125353707', N'Nghệ An', N'Kinh', N'L02', 'Cao Xuan Bắc', '015323789')

insert dbo.HocSinh (MaHS, HoTen,GioiTinh,NgaySinh ,Dantoc, Sdt, DiaChi ,Tongiao, MaLop, TenPH, SDTPH)
values ('HS03', N'Nguyễn Ngọc Ánh', 0 , '02-05-1996', N'Kinh', '016423407', N'Nghệ An', N'Kinh', N'L02', 'Châu Xuan Luong', '0122343789')

insert dbo.HocSinh (MaHS, HoTen,GioiTinh,NgaySinh ,Dantoc, Sdt, DiaChi ,Tongiao, MaLop, TenPH, SDTPH)
values ('HS04', N'Cao Thị Gấm', 0 , '12-18-1996', N'Kinh', '0124412707', N'Nghệ An', N'Kinh', N'L03', 'Ngo Minh Phuong', '012346789')

insert dbo.HocSinh (MaHS, HoTen,GioiTinh,NgaySinh ,Dantoc, Sdt, DiaChi ,Tongiao, MaLop, TenPH, SDTPH)
values ('HS05', N'Cao Xuân Sươn', 1 , '02-18-1996', N'Kinh', '016612407', N'Nghệ An', N'Kinh', N'L03', 'Cao Minh Phuong', '012233359')

insert dbo.HocSinh (MaHS, HoTen,GioiTinh,NgaySinh ,Dantoc, Sdt, DiaChi ,Tongiao, MaLop, TenPH, SDTPH)
values ('HS06', N'Nguyễn Anh Tuấn', 1 , '06-05-1996', N'Kinh', '0164124707', N'Nghệ An', N'Kinh', N'L04', 'CHu Phuong', '0253556789')

insert dbo.HocSinh (MaHS, HoTen,GioiTinh,NgaySinh ,Dantoc, Sdt, DiaChi ,Tongiao, MaLop, TenPH, SDTPH)
values ('HS07', N'Cao Bá Sơn', 1 , '06-08-1996', N'Kinh', '01667033707', N'Nghệ An', N'Kinh', N'L05', 'Cao Xuan Phuong', '0123446789')

insert dbo.HocSinh (MaHS, HoTen,GioiTinh,NgaySinh ,Dantoc, Sdt, DiaChi ,Tongiao, MaLop, TenPH, SDTPH)
values ('HS08', N'Ngô Thị Thương', 0 , '06-08-1996', N'Kinh', '014342307', N'Nghệ An', N'Kinh', N'L05', 'Ngo Thi Phuong', '0123443789')

insert dbo.HocSinh (MaHS, HoTen,GioiTinh,NgaySinh ,Dantoc, Sdt, DiaChi ,Tongiao, MaLop, TenPH, SDTPH)
values ('HS09', N'Cao Minh Nhật', 1 , '06-08-1996', N'Kinh', '01663432707', N'Nghệ An', N'Kinh', N'L01', 'Chu ba Phuong', '01223489')

insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M01',N'Hóa', 10)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M02',N'Toán', 10)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M03',N'Lý', 10)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M04',N'Văn', 10)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M05',N'Anh', 10)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M06',N'Hóa', 11)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M07',N'Lịch Sử', 12)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M08',N'Địa Lý', 10)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M09',N'Hóa', 12)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M10',N'Anh', 11)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M11',N'Anh', 12)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M12',N'Toán', 11)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M13',N'Toán', 12)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M14',N'Lý', 11)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M15',N'Lý', 12)
insert dbo.MonHoc (MaMon, TenMon, Khoi) values ('M16',N'Văn', 11)

insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L01',N'10A1', '2015-2018')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L02',N'10A2', '2015-2018')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L03',N'10A3', '2015-2018')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L04',N'10A4', '2015-2018')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L05',N'10A5', '2015-2018')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L06',N'10A6', '2015-2018')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L01',N'11A1', '2014-2017')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L02',N'10A2', '2014-2017')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L03',N'10A3', '2014-2017')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L04',N'10A4', '2014-2017')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L05',N'11A5', '2014-2017')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L06',N'11A6', '2014-2017')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L07',N'12A1', '2013-2016')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L08',N'12A2', '2013-2016')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L09',N'12A3', '2013-2016')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L10',N'12A4', '2013-2016')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L11',N'12A5', '2013-2016')
insert dbo.Lop (Malop, TenLop, NiemKhoa) values ('L12',N'12A6', '2013-2016')



insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV01',N'Hồ Nhật Quang', 1 , N'Hà Nội', '06-06-1975', '031234564', 'M01')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV02',N'Trần Minh Sơn', 1 , N'Nghệ An', '06-07-1978', '0419834464', 'M02')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV03',N'Nguyễn Đặng Minh', 1 , N'Yên Bái', '12-02-1980', '09875464', 'M03')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV04',N'Đặng thị Khuê', 0 , N'Nghệ An', '01-06-1979', '0983234564', 'M04')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV05',N'Nguyễn Thị Hà', 0 , N'Hà Nội', '06-06-1987', '031234564', 'M05')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV06',N'Chu THị Hường', 0 , N'Hà Nội', '01-06-1975', '031234564', 'M06')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV07',N'Chu THi Linh', 0 , N'Hà Nội', '06-02-1975', '084534564', 'M07')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV08',N'Mai Bá Hoàng', 1 , N'Đà Nẵng', '06-04-1975', '07834564', 'M08')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV09',N'Đặng Thai Mai ', 0 , N'Hà Nội', '06-04-1975', '0981234564', 'M09')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV10',N'Hồ Quang Anh', 1 , N'Thanh Hóa', '11-06-1975', '0155654', 'M10')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV11',N'Hồ THị Anh', 0 , N'Nghệ An', '04-06-1971', '02345778', 'M11')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV12',N'Nguyễn Trọng Nhân', 1 , N'Hà Nội', '06-05-1987', '0387564', 'M12')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV13',N'Cao Thanh Bảo', 1 , N'Hà Nội', '06-06-1983', '07234564', 'M13')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV14',N'Trần Quang Thăng', 1 , N'Hà Nội', '06-08-1974', '0134564', 'M14')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV15',N'Hồ Nhật Sơn', 1 , N'Hà Nội', '06-08-1972', '08734564', 'M15')
insert dbo.GiaoVien(MaGV, HoTen , GioiTinh, DiaChi ,NgaySinh, Sdt , MaMon) 
values ('GV16',N'Nguyễn Ngọc Mai', 1 , N'Hà Nội', '06-12-1971', '075234564', 'M16')



insert dbo.ChuNhiem(MaGV, MaLop , NamHoc ) 
values ('GV01','L01',  '2015-2016')
insert dbo.ChuNhiem(MaGV, MaLop , NamHoc ) 
values ('GV02','L02', '2015-2016')
insert dbo.ChuNhiem(MaGV, MaLop , NamHoc ) 
values ('GV03','L03',  '2015-2016')
insert dbo.ChuNhiem(MaGV, MaLop , NamHoc ) 
values ('GV04','L04',  '2015-2016')
insert dbo.ChuNhiem(MaGV, MaLop , NamHoc ) 
values ('GV05','L05', '2015-2016')
insert dbo.ChuNhiem(MaGV, MaLop , NamHoc ) 
values ('GV06','L06', '2015-2016')

insert dbo.PhongHoc(MaPhong, SoPhong , SoChoToiDa ) 
values ('P01', '18' , 40)
insert dbo.PhongHoc(MaPhong, SoPhong , SoChoToiDa ) 
values ('P02', '18' , 50)
insert dbo.PhongHoc(MaPhong, SoPhong , SoChoToiDa ) 
values ('P03', '18' , 45)
insert dbo.PhongHoc(MaPhong, SoPhong , SoChoToiDa ) 
values ('P04', '18' , 45)
insert dbo.PhongHoc(MaPhong, SoPhong , SoChoToiDa ) 
values ('P05', '18' , 45)
insert dbo.PhongHoc(MaPhong, SoPhong , SoChoToiDa ) 
values ('P06', '18' , 48)
insert dbo.PhongHoc(MaPhong, SoPhong , SoChoToiDa ) 
values ('P07', '18' , 48)
insert dbo.PhongHoc(MaPhong, SoPhong , SoChoToiDa ) 
values ('P08', '18' , 45)
insert dbo.PhongHoc(MaPhong, SoPhong , SoChoToiDa ) 
values ('P09', '18' , 60)



insert dbo.PhongLop(MaPhong, MaLop , KipHoc,HocKyNamHoc ) 
values ('P01', 'L01' , N'Sáng', 'Học Kỳ 1')
insert dbo.PhongLop(MaPhong, MaLop , KipHoc,HocKyNamHoc ) 
values ('P02', 'L02' , N'Sáng', 'Học Kỳ 1')
insert dbo.PhongLop(MaPhong, MaLop , KipHoc,HocKyNamHoc ) 
values ('P03', 'L03' , N'Sáng', 'Học Kỳ 1')
insert dbo.PhongLop(MaPhong, MaLop , KipHoc,HocKyNamHoc ) 
values ('P04', 'L04' , N'Sáng', 'Học Kỳ 1')
insert dbo.PhongLop(MaPhong, MaLop , KipHoc,HocKyNamHoc ) 
values ('P05', 'L05' , N'Sáng', 'Học Kỳ 1')
insert dbo.PhongLop(MaPhong, MaLop , KipHoc,HocKyNamHoc ) 
values ('P06', 'L06' , N'Sáng', 'Học Kỳ 1')
insert dbo.PhongLop(MaPhong, MaLop , KipHoc,HocKyNamHoc ) 
values ('P01', 'L07' , N'Chiều', 'Học Kỳ 1')
insert dbo.PhongLop(MaPhong, MaLop , KipHoc,HocKyNamHoc ) 
values ('P02', 'L08' , N'Chiều', 'Học Kỳ 1')
insert dbo.PhongLop(MaPhong, MaLop , KipHoc,HocKyNamHoc ) 
values ('P03', 'L09' , N'Chiều', 'Học Kỳ 1')



insert dbo.Diem(MaHS, MaMH , DiemMieng,Diem15p,Diem1h,DiemHK ) 
values ('HS01', 'M01' , 8.0 , 8.5 , 9 , 7.5)
insert dbo.Diem(MaHS, MaMH , DiemMieng,Diem15p,Diem1h,DiemHK ) 
values ('HS02', 'M01' , 8.0 , 8.5 , 9 , 8.5)
insert dbo.Diem(MaHS, MaMH , DiemMieng,Diem15p,Diem1h,DiemHK ) 
values ('HS03', 'M02' , 5.0 , 5.5 , 9 , 9.5)
insert dbo.Diem(MaHS, MaMH , DiemMieng,Diem15p,Diem1h,DiemHK ) 
values ('HS04', 'M02' , 10.0 , 7.5 , 9 , 8.5)
insert dbo.Diem(MaHS, MaMH , DiemMieng,Diem15p,Diem1h,DiemHK ) 
values ('HS05', 'M02' , 7.0 , 9.5 , 7 , 10.0)
insert dbo.Diem(MaHS, MaMH , DiemMieng,Diem15p,Diem1h,DiemHK ) 
values ('HS06', 'M03' , 6.0 , 7.5 , 6 , 7.5)
insert dbo.Diem(MaHS, MaMH , DiemMieng,Diem15p,Diem1h,DiemHK ) 
values ('HS07', 'M04' , 9.0 , 9.5 , 7 , 5.5)
insert dbo.Diem(MaHS, MaMH , DiemMieng,Diem15p,Diem1h,DiemHK ) 
values ('HS08', 'M05' , 8.0 , 6.5 , 8 , 9.5)

