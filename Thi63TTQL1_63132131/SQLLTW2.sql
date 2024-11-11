CREATE DATABASE Thi63TTQL1_63132131
GO
USE Thi63TTQL1_63132131
GO
CREATE TABLE BoMon
(
	MaBM nvarchar(10) PRIMARY KEY,
	TenBM nvarchar(50) NOT NULL
)
GO
CREATE TABLE GiangVien
(
	MaGV nvarchar(8) PRIMARY KEY,
	HoGV nvarchar(50) NOT NULL,
	TenGV nvarchar(10) NOT NULL,
	NgaySinh date,
	GioiTinh bit DEFAULT(1),
	Email varchar(100),
	AnhGV nvarchar(50),
	MaBM nvarchar(10) NOT NULL FOREIGN KEY REFERENCES BoMon(MaBM)
	ON UPDATE CASCADE
	ON DELETE CASCADE
)
GO
INSERT INTO BoMon VALUES(N'ABC123',N'thiết kế web 1'),(N'DEF456',N'thiết kế web 2')
GO
	INSERT GiangVien VALUES (N'1111', N'Vũ Tiến', N'Dương', CAST(N'1989-4-22' AS Date), 1,N'vutienduong123@example.com', N'employee.png', N'ABC123')
	GO
	INSERT GiangVien VALUES (N'2222', N'Nguyễn Thùy', N'Kim', CAST(N'1990-11-23' AS Date), 1,N'nguyenthuykim123@example.com', N'employee.png',N'DEF456')
	GO

CREATE PROCEDURE GiangVien_TimKiem
    @MaGV varchar(8)=NULL,
	@HoTen nvarchar(40)=NULL
AS
BEGIN
DECLARE @SqlStr NVARCHAR(4000),
		@ParamList nvarchar(2000)
SELECT @SqlStr = '
       SELECT * 
       FROM GiangVien
       WHERE  (1=1)
       '
IF @MaGV IS NOT NULL
       SELECT @SqlStr = @SqlStr + '
              AND (MaGV LIKE ''%'+@MaGV+'%'')
              '
IF @HoTen IS NOT NULL
       SELECT @SqlStr = @SqlStr + '
              AND (HoGV+'' ''+TenGV LIKE ''%'+@HoTen+'%'')
              '
	EXEC SP_EXECUTESQL @SqlStr
END