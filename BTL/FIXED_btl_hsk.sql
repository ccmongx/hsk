use btl_hsk
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
alter column sMadathang varchar(10) not null

alter table tbl_Chitietdathang
alter column sMaDT varchar(10) not null

alter table tbl_Chitietdathang
add constraint PK_ctdh primary key (sMadathang, sMaDT)



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