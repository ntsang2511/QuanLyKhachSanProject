USE QuanLyKhachSan
GO

alter table PHONG
ADD TINHTRANGDICHVU bit


alter table PHONG 
ADD MADV VARCHAR(50)

alter table PHONG 
ADD FOREIGN KEY (MADV)
REFERENCES DICHVU (MADV);
CREATE TABLE BOPHAN(
	MABP VARCHAR(50) PRIMARY KEY,
	TENBP NVARCHAR(50),
	CONGVIEC NVARCHAR(50)
)

create table DICHVU(
	MADV VARCHAR(50) PRIMARY KEY,
	TENDV NVARCHAR(100),
	DONGIA FLOAT
)

create table NHANVIEN(
	MANV VARCHAR(50) PRIMARY KEY,
	TENNV NVARCHAR(100),
	CHUCVU NVARCHAR(100),
	MABP VARCHAR(50),
	MADV VARCHAR(50),
	FOREIGN KEY (MABP) REFERENCES BOPHAN (MABP),
)

CREATE TABLE PHONG(
	MAPHONG VARCHAR(50) PRIMARY KEY,
	LOAIPHONG NVARCHAR(50),
	GIAPHONG FLOAT,
	SONGUOI int,
	TINHTRANG BIT,
)

CREATE TABLE COQUAN (
	MACQ VARCHAR(50) PRIMARY KEY,
	TENCQ NVARCHAR(200),
	DIACHI NVARCHAR(200),
	SODIENTHOAI VARCHAR(20),
)

CREATE TABLE KHACHHANG(
	MAKH VARCHAR(50) PRIMARY KEY,
	TENKH NVARCHAR(100),
	CMND VARCHAR(50),
	GIOITINH BIT,
	DIENTHOAILIENHE VARCHAR(20),
	DIACHI NVARCHAR(200),
)

CREATE TABLE DATPHONG (
	MADP VARCHAR(50) PRIMARY KEY,
	MAKH VARCHAR(50),
	MAPHONG VARCHAR(50),
	NGAYDEN DATE,
	NGAYTRA DATE,
	SONGUOI INT,
	TRANGTHAI BIT,
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH),
	FOREIGN KEY (MAPHONG) REFERENCES PHONG (MAPHONG),
)

CREATE TABLE HOADON(
	MAHD VARCHAR(50) PRIMARY KEY,
	MADP VARCHAR(50),
	MANV VARCHAR(50),
	NGAYLAP DATE,
	TONGTIEN FLOAT,
	FOREIGN KEY (MADP) REFERENCES DATPHONG (MADP),
	FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV),
)

CREATE TABLE THANHTOAN(
	MATT VARCHAR(50) PRIMARY KEY,
	MADP VARCHAR(50),
	MADV VARCHAR(50),
	SOTIEN FLOAT,
	HINHTHUCTHANHTOAN NVARCHAR(50),
	NGAYTHANHTOAN DATE,
	FOREIGN KEY (MADP) REFERENCES DATPHONG (MADP),
	FOREIGN KEY (MADV) REFERENCES DICHVU (MADV)
)