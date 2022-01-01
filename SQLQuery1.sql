


create database QuanLyXeOK
ON
	(NAME= QuanLyXeOK,filename='D:\Study\BTLwin\QuanLyXeOK.mdf ', SIZE=50,MAXSIZE=200,FILEGROWTH=10)
LOG ON
	(NAME='QuanLyXeOKlog',
	FILENAME='D:\Study\BTLwin\QuanLyXeOK.ldf ', SIZE=10,FILEGROWTH=5)
go
use QuanLyXeOK
go
--nhân viên
--xe
--vé
--bãi xe
--phi?u thanh toán
--qu?n lý xe
create table NHANVIEN
(
	maNV nvarchar(20) primary key,
	tenHienthi nvarchar(100),
	loaiNV nvarchar(30),
	ngaySinh date,
	gt nvarchar(10),
	diaChi nvarchar(200),
	sdt nvarchar(20),
	matKhau nvarchar(30),
	
)
go
create table XE
(
	maSoVe nvarchar(10), 
	bienSo nvarchar(20) primary key,
	loaiXe nvarchar(20) not null,
	tenxe nvarchar(100),
	mauxe nvarchar(10),
	loaiVe nvarchar(10), 	tgvaoben datetime,
	tgxuatben datetime,
	ngayDangky datetime,
	ngayHetHan datetime

)
go
create table VE
(
	loaiXe nvarchar(20) ,
	maSoVe nvarchar(10) primary key,
	giaVe nvarchar(20),
	bienSo nvarchar(20),

)
go
create table BAIXE
(
	khuVuc nvarchar(10),
	loaiXe nvarchar(20)primary key,
	tongSoCho int,
	soChoTrong int,
	soTienThuVe int

)
go
create table THONGKE
(
	id int identity primary key,
	maSoVe nvarchar(10), 
	bienSo nvarchar(20) not null,
	loaiXe nvarchar(20) not null,
	tenxe nvarchar(200),
	mauxe nvarchar(10), 
	loaiVe nvarchar(20),
	giaVe nvarchar(20), 
	tgvaoben datetime,
	tgxuatben datetime,
	ngayDangky datetime,
	ngayHetHan datetime
)
go
alter table XE
add foreign key (loaiXe) references BAIXE(loaiXe)
go
alter table XE
add foreign key (maSoVe) references VE(maSoVe)
go
alter table THONGKE
add foreign key (maSoVe) references VE(maSoVe)
go
--vé tháng
insert VE values(null,N'Vé tháng', null,null)
-- chèn 400 vé ô tô vào danh sách
declare @i int, @so0 NVARCHAR(10), @ma nvarchar(10)
set @i=1;
while(@i<=400)
begin
	IF (@i<10) 
		SET @so0='000';
	ELSE if(@i<100)
		SET @so0='00';
	ELSE if(@i<1000)
		SET @so0='0';
	ELSE
		SET @so0='';
	set @ma=CONCAT('VE',@so0,@i);
	insert into VE values(null,@ma,null,null)
	SET @i=@i+1;
end
go
--chèn nhân viên
insert into NHANVIEN values('admin2',N'Bùi Thị XYZ',N'Nhân viên thường','1997/05/01',N'Nữ',N'Phú Thọ',0971555654,'admin')
insert into NHANVIEN values('admin',N'Nguyễn Ngọc Trịnh',N'Nhân viên quản lý','1996/05/20',N'Nam',N'phu tho',0971555654,'admin')
--chèn bãi xe
insert into BAIXE values('Xe máy','Xe máy',200,200,0)
insert into BAIXE values('Ô tô','Ô tô',200,200,0)

-- bản này là bản chuẩn