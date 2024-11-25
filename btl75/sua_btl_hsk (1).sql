create view tongTien (maDatHang, tongTien)
as
select tbl_Chitietdathang.sMadathang, sum(iSoluong * iGiaban) as tongTien
from tbl_Chitietdathang
inner join tbl_DatHang
on tbl_Chitietdathang.sMadathang = tbl_DatHang.sMadathang
group by tbl_Chitietdathang.sMadathang

update tbl_DatHang
set iTongtien = tongTien.tongTien
from tongTien
where tbl_DatHang.sMadathang = tongTien.maDatHang

create trigger tongTienHang
on tbl_Chitietdathang
for insert
as
declare @madh varchar(10), @sotien float
begin
	select @madh = sMadathang from inserted
	select @sotien = sum(iSoluong * iGiaban) from inserted
	update tbl_DatHang
	set iTongtien = iTongtien + @sotien
	where sMadathang = @madh
end

alter table tbl_Chitietdathang
drop column sMactdh

alter table tbl_Chitietdathang
alter column sMadathang varchar(10) not null

alter table tbl_Chitietdathang
alter column sMaDT varchar(10) not null

alter table tbl_Chitietdathang
add constraint PK_ctdh primary key (sMadathang, sMaDT)

create proc sp_giatrongkhoang
@giaA float,
@giaB float
as
begin
     select tbl_Dienthoai.sMaDT,tbl_Dienthoai.sTenDT from tbl_Dienthoai inner join
	 tbl_Chitietdathang on tbl_Dienthoai.sMaDT=tbl_Chitietdathang.sMaDT 
	 where tbl_Dienthoai.iGiaban>@giaA and tbl_Dienthoai.iGiaban<@giaB
end
exec sp_giatrongkhoang @giaA=21000000 ,@giaB=23500000
create proc sp_DSHD
@thang int,
@nam int
as 
begin 
   select tbl_DatHang.sMadathang,tbl_Dienthoai.sMaDT,tbl_Dienthoai.sTenDT,tbl_DatHang.sMaKH,tbl_DatHang.iMaNV,tbl_DatHang.dNgaydat 
   from tbl_DatHang
inner join tbl_Chitietdathang on tbl_DatHang.sMadathang=tbl_Chitietdathang.sMadathang 
inner join tbl_Dienthoai on tbl_Chitietdathang.sMaDT=tbl_Dienthoai.sMaDT 
   where month(tbl_DatHang.dNgaydat) =@thang and year(tbl_DatHang.dNgaydat)=@nam
end
exec sp_DSHD @thang=4,@nam=2023

create proc sp_DSDTtheomahang
@sTenhangDT nvarchar(50)
as
begin
  select tbl_Dienthoai.sMaDT,tbl_Dienthoai.sTenDT,tbl_Dienthoai.iSoluong,tbl_Dienthoai.iGiaban from tbl_Dienthoai
  inner join tbl_HangDT on tbl_Dienthoai.iMahangDT=tbl_HangDT.iMahangDT
  where tbl_HangDT.sTenhangDT=@sTenhangDT
end
exec sp_DSDTtheomahang @sTenhangDT="Xiaomi"
create view tongsoluong
as
select tbl_Dienthoai.iMahangDT,sum(tbl_Dienthoai.iSoluong)  as[Tổng số lượng]
from tbl_Dienthoai
group by tbl_Dienthoai.iMahangDT 
USE [btl_hsk]
GO
/****** Object:  Trigger [dbo].[tongTienHang]    Script Date: 05/04/2023 3:20:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[tongTienHang]
on [dbo].[tbl_Chitietdathang] 
for insert 
as 
declare @madh varchar(10), @sotien float
begin 
	select @madh = sMadathang from inserted
	select @sotien = sum(inserted.iSoluong*tbl_Dienthoai.iGiaban) from inserted inner join tbl_Dienthoai
	on tbl_Dienthoai.sMaDT = inserted.sMaDT
	update tbl_DatHang
	set iTongtien = iTongtien+@sotien
	where sMadathang = @madh
end

ALTER TABLE tbl_Chitietdathang
DROP COLUMN iGiaBan

create table tblusers(
Userid int primary key,
Username nvarchar(50),
Userpassword nvarchar(50)
);
create proc sp_login @Username nvarchar(50), @Userpassword nvarchar(50) 
as
begin
	select * from tblusers
	where Username = @Username and Userpassword = @Userpassword
end