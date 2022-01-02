


create database QLXE

go
use QLXE
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
insert into NHANVIEN values('admin',N'Nguyễn Ngọc Chiến',N'Nhân viên quản lý','2001/09/17',N'Nam',N'HCM',0901499903,'admin')
--chèn bãi xe
insert into BAIXE values('Xe Con','Xe con',20,20,1000)
insert into BAIXE values('Xe Buýt','Xe buýt',20,20,2000)
insert into BAIXE values('Xe Tải','Xe tải',20,20,3000)
insert into BAIXE values('Xe Con','Xe Container',20,20,5000)
-- bản này là bản chuẩn