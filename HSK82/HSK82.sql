create database HSK82
use HSK82

create table tblMatHang( 
iMaH int primary key not null,
sTenhang nvarchar(50),
iSoluong int,
fDongia float)
go

create table tblLoaiHang(
iMaLH int primary key,
sTenLoai nvarchar(50))
go

alter table tblMatHang
add
CONSTRAINT fk_malh
FOREIGN KEY (iMaLH)
references tblLoaiHang (iMaLH)

SELECT * FROM tblMatHang