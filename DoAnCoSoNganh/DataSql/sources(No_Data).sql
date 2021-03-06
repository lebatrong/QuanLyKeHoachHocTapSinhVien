USE [master]
GO
/****** Object:  Database [SoftQuanLyDiemSinhVien]    Script Date: 07/10/2017 12:26:14 CH ******/
CREATE DATABASE [SoftQuanLyDiemSinhVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SoftQuanLyDiemSinhVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SoftQuanLyDiemSinhVien.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SoftQuanLyDiemSinhVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SoftQuanLyDiemSinhVien_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SoftQuanLyDiemSinhVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET  MULTI_USER 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SoftQuanLyDiemSinhVien]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetTienTrinh]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_GetTienTrinh] (@ms varchar(8))
as
BEGIN
   SELECT MaMon,Diem_10,Diem_40,Diem_50,DiemChu FROM diem where MSSV=@ms;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_TienTrinhChiTietMon]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_TienTrinhChiTietMon] (@ms varchar(8) , @mm varchar(6))
as

   BEGIN
	SELECT Diem.MaMon,TenMon,Diem_10,Diem_40,Diem_50,DiemChu from diem,MonHoc WHERE MSSV=@ms and Diem.MaMon=@mm and Diem.mamon=MonHoc.mamon;
END
GO
/****** Object:  StoredProcedure [dbo].[spHienThiMonHoc]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----HIỂN THI THÔNG TIN MÔN HỌC-----
CREATE PROC [dbo].[spHienThiMonHoc]
as
	begin
		select * from MonHoc
	end



GO
/****** Object:  StoredProcedure [dbo].[spHienThiThongTinSV]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


----HIỂN THỊ THÔNG TIN SINH VIÊN-------
create proc [dbo].[spHienThiThongTinSV](@mssv varchar(8))
as
	begin
		select HoTenSV,NgaySinh,Lop,Nganh,HeDT,khoaHoc from SinhVien where MSSV=@mssv
	end



GO
/****** Object:  StoredProcedure [dbo].[spInsertDiem]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---exec spHienThiMonHoc

-----INSERT THÔNG TIN MÔN HỌC------
CREATE procedure [dbo].[spInsertDiem](@mamon varchar(6), @diem10 VARCHAR(5), @diem40 VARCHAR(5), @diem50 VARCHAR(5), @he10 VARCHAR(5), @he4 VARCHAR(5), @diemchu varchar(2), @mssv varchar(8),@hocky nvarchar(30), @namhoc VARCHAR(20))
as 
	Begin
		if exists( select MaMon from Diem where MSSV=@mssv and MaMon=@mamon)
			begin
				print N'Đã có môn học'
			end
		else
			begin
				insert into Diem (MaMon,Diem_10,Diem_40,Diem_50,He_10,He_4,DiemChu,MSSV,HocKy,NamHoc)
					values(@mamon,@diem10,@diem40,@diem50,@he10,@he4,@diemchu,@mssv,@hocky,@namhoc)
			end
	End



GO
/****** Object:  StoredProcedure [dbo].[spInsertNote]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spInsertNote](@mssv varchar(8), @tieude nvarchar(500), @ghichu nvarchar(2000), @ngaythongbao varchar(50))
as
begin
	insert into Note(mssv,tieude,ghichu,ngaylap,ngaythongbao,lanthongbao)
		values (@mssv,@tieude,@ghichu,getdate(),Convert(datetime,@ngaythongbao,103),0)
end

GO
/****** Object:  StoredProcedure [dbo].[spInsertSinhVien]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--exec spTimMonHoc 'web'

----THÊM SINH VIÊN-----
create proc [dbo].[spInsertSinhVien]
(
	@MSSV varchar(8),
	@Pass varchar(20),
	@HoTenSV nvarchar(50),
	@NgaySinh datetime,
	@Lop varchar(10),
	@Nganh nvarchar(100),
	@HeDT nvarchar(50),
	@khoaHoc int
)
as
	begin
		insert into SinhVien (MSSV,Pass,HoTenSV,NgaySinh,Lop,Nganh,HeDT,khoaHoc)
		values(@MSSV,@Pass,@HoTenSV,@NgaySinh,@Lop,@Nganh,@HeDT,@khoaHoc)
	end



GO
/****** Object:  StoredProcedure [dbo].[spTimMonHoc]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---exec spUpdateThongtinSinhVien '15004116','1','Admin','09-27-1997','1CTT15A','CNTT',N'Đại học',2015

-----TÌM MÔN HỌC-----
create proc [dbo].[spTimMonHoc]
(

	@tukhoa nvarchar(50)
)
as
	begin
		select * from MonHoc where MaMon like '%'+@tukhoa+'%' or TenMon like N'%'+@tukhoa+'%'
	end



GO
/****** Object:  StoredProcedure [dbo].[spUpdateMH]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spUpdateMH] (@mamon varchar(6), @tenmon nvarchar(100), @tc int)
as
begin
			
				update MonHoc 
				set MaMon=@mamon,
				TenMon =@tenmon,
				SoTinChi =@tc
				where MaMon =@mamon
			
end

GO
/****** Object:  StoredProcedure [dbo].[spUpdateThongtinSinhVien]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----exec spXoaMonHoc 'CT1101','15004116'

----CHỈNH SỬA THÔNG TIN SINH VIÊN----
create proc [dbo].[spUpdateThongtinSinhVien]
(
	@mssv varchar(8),
	@pass varchar(20),
	@hoten nvarchar(50),
	@ngaysinh datetime,
	@lop varchar(10),
	@nganh nvarchar(100),
	@hedt nvarchar(50),
	@khoahoc int
)
as
	begin
		update SinhVien
		set Pass=@pass,
			HoTenSV=@hoten,
			NgaySinh=@ngaysinh,
			Lop=@lop,
			HeDT=@hedt,
			khoaHoc=@khoahoc
		where MSSV=@mssv
	end



GO
/****** Object:  StoredProcedure [dbo].[spXoaMonHoc]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec spUpdateMonHoc 'CT1101',7.5,7.3,8.0,8.0,3.5,'B','15004116',N'Học kỳ 2'

-----XÓA MÔN HỌC------
create proc [dbo].[spXoaMonHoc]
(
	@mamon varchar(6),
	@mssv varchar(8)
)
as
	begin
		if exists(select * from Diem where MaMon=@mamon and MSSV=@mssv)
			begin
				delete from Diem
				where MaMon=@mamon and MSSV=@mssv
				print N'Xóa thành công'
			end
		else
			begin
				print N'Xóa không thành công'
			end
	end



GO
/****** Object:  Table [dbo].[Diem]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diem](
	[MaMon] [varchar](6) NOT NULL,
	[Diem_10] [varchar](5) NULL,
	[Diem_40] [varchar](5) NULL,
	[Diem_50] [varchar](5) NULL,
	[He_10] [varchar](5) NULL,
	[He_4] [varchar](5) NULL,
	[DiemChu] [varchar](2) NULL,
	[MSSV] [varchar](8) NOT NULL,
	[HocKy] [nvarchar](100) NOT NULL,
	[NamHoc] [varchar](20) NOT NULL,
 CONSTRAINT [PK__Diem__3A5B29A869D79D91] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC,
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMon] [varchar](6) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
	[SoTinChi] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Note]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Note](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MSSV] [varchar](8) NULL,
	[TieuDe] [nvarchar](500) NULL,
	[GhiChu] [nvarchar](2000) NULL,
	[NgayLap] [datetime] NULL,
	[NgayThongBao] [datetime] NULL,
	[LanThongBao] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 07/10/2017 12:26:15 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MSSV] [varchar](8) NOT NULL,
	[Pass] [varchar](20) NOT NULL,
	[HoTenSV] [nvarchar](50) NOT NULL,
	[NgaySinh] [varchar](20) NOT NULL,
	[Lop] [varchar](10) NOT NULL,
	[Nganh] [nvarchar](100) NOT NULL,
	[HeDT] [nvarchar](50) NOT NULL,
	[khoaHoc] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonHoc] ([MaMon])
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([MSSV])
REFERENCES [dbo].[SinhVien] ([MSSV])
GO
ALTER TABLE [dbo].[Note]  WITH CHECK ADD FOREIGN KEY([MSSV])
REFERENCES [dbo].[SinhVien] ([MSSV])
GO
USE [master]
GO
ALTER DATABASE [SoftQuanLyDiemSinhVien] SET  READ_WRITE 
GO
