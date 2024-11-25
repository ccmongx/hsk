create database HSK223
go
use HSK223
go 
ALTER VIEW vw_HienSach
AS
	SELECT *
	FROM tblSach

SELECT* FROM vw_HienSach

CREATE PROC sp_ThemSach
@masach nvarchar(50),
@tieude nvarchar(50),
@soluong int, @dongia float
AS
	IF EXISTS (SELECT* FROM tblSach WHERE sMaSach= @masach)
		PRINT 'Ma sach da ton tai. Vui long nhap ma sach khac!'
	IF EXISTS (SELECT* FROM tblSach WHERE sTieuDe= @tieude)
		PRINT 'Tieu de da ton tai. Vui long nhap tieu de khac!'
	ELSE
		INSERT INTO tblSach(sMaSach, sTieuDe, fDonGia, iSoLuong)
		VALUES (@masach, @tieude, @dongia, @soluong)

EXEC sp_ThemSach D1, 'Tin hoc', 6, 38000
SELECT * FROM tblSach

--Sua thong tin don gia
CREATE PROC sp_SuaDonGia
@masach nvarchar(50),
@tieude nvarchar(50),
@soluong int, @dongia float
AS
	IF EXISTS (SELECT * FROM tblSach WHERE sMaSach= @masach )
		BEGIN	
			
			UPDATE tblSach
			SET sMaSach= @masach, sTieuDe= @tieude, iSoLuong= @soluong, fDonGia= @dongia
			WHERE sMaSach= @masach
		END
	ELSE PRINT 'Khong ton tai ma sach ' + @masach	

EXEC sp_SuaDonGia N'D1'
SELECT *  FROM tblSach


--Xoa
CREATE PROC sp_Xoa
@masach nvarchar(50),
@tieude nvarchar(50),
@soluong int, @dongia float
AS
	DELETE tblSach
	WHERE sMaSach= @masach