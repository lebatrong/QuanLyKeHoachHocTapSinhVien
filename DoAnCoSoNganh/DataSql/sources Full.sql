USE [master]
GO
/****** Object:  Database [SoftQuanLyDiemSinhVien]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  StoredProcedure [dbo].[sp_GetTienTrinh]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  StoredProcedure [dbo].[sp_TienTrinhChiTietMon]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  StoredProcedure [dbo].[spHienThiMonHoc]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  StoredProcedure [dbo].[spHienThiThongTinSV]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  StoredProcedure [dbo].[spInsertDiem]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  StoredProcedure [dbo].[spInsertNote]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  StoredProcedure [dbo].[spInsertSinhVien]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  StoredProcedure [dbo].[spTimMonHoc]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  StoredProcedure [dbo].[spUpdateMH]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  StoredProcedure [dbo].[spUpdateThongtinSinhVien]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  StoredProcedure [dbo].[spXoaMonHoc]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  Table [dbo].[Diem]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  Table [dbo].[MonHoc]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  Table [dbo].[Note]    Script Date: 07/10/2017 12:26:55 CH ******/
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
/****** Object:  Table [dbo].[SinhVien]    Script Date: 07/10/2017 12:26:55 CH ******/
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
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CB1106', N'10', N'7', N'6', N'6,8', N'2,5', N'C+', N'15004116', N'Học kỳ 2 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CB1106', N'10', N'7', N'7', N'7,3', N'3', N'B', N'admin', N'Học kỳ 1 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CB1107', N'1', N'1', N'7', N'4', N'1', N'D', N'1', N'Học kỳ 1 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CB1107', N'10', N'9', N'4', N'6,6', N'2,5', N'C+', N'15004116', N'Học kỳ phụ Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CB1110', N'10', N'10', N'10', N'10', N'4', N'A', N'admin', N'Học kỳ 1 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CB1111', N'10', N'6', N'7', N'6,9', N'2,5', N'C+', N'15004116', N'Học kỳ 2 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CB1112', N'9,5', N'8', N'9', N'8,7', N'4', N'A', N'15004116', N'Học kỳ phụ Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CB1113', N'8,5', N'6', N'7', N'6,8', N'2,5', N'C+', N'15004116', N'Học kỳ 2 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CB1114', N'10', N'7,5', N'6,5', N'7,3', N'3', N'B', N'15004116', N'Học kỳ 2 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CT1101', N'10', N'9', N'7', N'8,1', N'3,5', N'B+', N'15004116', N'Học kỳ 1 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CT1102', N'10', N'9,5', N'6', N'7,8', N'3,5', N'B+', N'15004116', N'Học kỳ phụ Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CT1103', N'10', N'5,5', N'7', N'6,7', N'2,5', N'C+', N'15004116', N'Học kỳ 2 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CT1104', N'9', N'6', N'9', N'7,8', N'3,5', N'B+', N'15004116', N'Học kỳ phụ Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'CT1105', N'8', N'7', N'8,5', N'7,9', N'3,5', N'B+', N'15004116', N'Học kỳ phụ Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'DT1229', N'8', N'6', N'6', N'7', N'3', N'B', N'1', N'học kỳ 2', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'DT1229', N'9', N'7,5', N'8', N'7,9', N'3,5', N'B+', N'15004116', N'Học kỳ 1 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'QP1101', N'0', N'0', N'7', N'7', N'3', N'B', N'15004116', N'Học kỳ 1 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'QP1102', N'0', N'0', N'5', N'5', N'1.5', N'D+', N'15004116', N'Học kỳ 1 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'QP1103', N'0', N'0', N'7', N'7', N'3', N'B', N'15004116', N'Học kỳ 1 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TC1101', N'0', N'0', N'8.5', N'8.5', N'4', N'A', N'15004116', N'Học kỳ 2 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TC111A', N'0', N'0', N'7.5', N'7.5', N'3', N'B', N'15004116', N'Học kỳ 2 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1201', N'7,5', N'4,5', N'5,5', N'5,3', N'1,5', N'D+', N'15004116', N'Học kỳ 2 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1203', N'10', N'5', N'3,5', N'4,8', N'1,5', N'D+', N'15004116', N'Học kỳ 2 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1204', N'10', N'5,5', N'8', N'7,2', N'3', N'B', N'15004116', N'Học kỳ 2 Năm học 2015-2016', N'2015-2016')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1205', N'10', N'7', N'6', N'6,8', N'2,5', N'C+', N'15004116', N'Học kỳ 1 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1206', N'10', N'5,5', N'6', N'6,2', N'2', N'C', N'15004116', N'Học kỳ 1 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1207', N'10', N'8', N'7', N'7,7', N'3', N'B', N'15004116', N'Học kỳ 1 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1208', N'8', N'6', N'6', N'6,2', N'2', N'C', N'15004116', N'Học kỳ 2 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1209', N'10', N'8,5', N'6', N'7,4', N'3', N'B', N'15004116', N'Học kỳ 1 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1210', N'9', N'6,5', N'7,5', N'7,3', N'3', N'B', N'15004116', N'Học kỳ 2 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1212', N'9', N'8,5', N'5,5', N'7,1', N'3', N'B', N'15004116', N'Học kỳ 2 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1213', N'10', N'10', N'7,5', N'8,8', N'4', N'A', N'15004116', N'Học kỳ 2 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1301', N'10', N'10', N'9,5', N'9,8', N'4', N'A', N'15004116', N'Học kỳ 2 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1305', N'7,5', N'7,5', N'7', N'7,3', N'3', N'B', N'15004116', N'Học kỳ 2 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[Diem] ([MaMon], [Diem_10], [Diem_40], [Diem_50], [He_10], [He_4], [DiemChu], [MSSV], [HocKy], [NamHoc]) VALUES (N'TH1307', N'8', N'6,5', N'7,5', N'7,2', N'3', N'B', N'15004116', N'Học kỳ 2 Năm học 2016-2017', N'2016-2017')
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CB1106', N'Toán cao cấp A1', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CB1107', N'Toán cao cấp A2', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CB1108', N'Toán cao cấp A3', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CB1109', N'Xác suất thống kê', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CB1110', N'Toán kinh tế', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CB1111', N'Vật lý đại cương A1', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CB1112', N'Vật lý đại cương A2', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CB1113', N'Hóa đại cương', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CB1114', N'Quản lý kinh tế', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CB1115', N'Quản lý HCNN và quản lý ngành GDĐT', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CT1101', N'Những NLCB của CN Mác Lênin', 5)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CT1102', N'Tư tưởng Hồ Chí Minh', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CT1103', N'Đường lối CM của ĐCSVN', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CT1104', N'Pháp luật đai cương', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CT1105', N'Con người và môi trường', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'CT1106', N'Nhập môn xã hội học', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'DT1229', N'Kỹ thuật Số', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'QP1101', N'Đường lối quân sự của Đảng', 0)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'QP1102', N'Công tác quốc phòng – An ninh', 0)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'QP1103', N'Kỹ thuật bắn súng tiểu liên AK', 0)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TC1101', N'Giáo dục thể chất 1', 0)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TC1102', N'Giáo dục thể chất 2', 0)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TC1103', N'Giáo dục thể chất 3', 0)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TC111A', N'GDTC 2 Điền kinh 1', 0)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TC112A', N'GDTC 3 Điền kinh 2', 0)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1201', N'Tin học cơ sở', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1203', N'Toán rời rạc', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1204', N'Lập trình căn bản', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1205', N'Cấu trúc máy tính', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1206', N'Cấu trúc dữ liệu và giải thuật', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1207', N'Cơ sở dữ liệu', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1208', N'Hệ điều hành', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1209', N'Lập trình hướng đối tượng', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1210', N'Đồ họa máy tính', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1211', N'Lý thuyết ngôn ngữ hình thức & tính toán', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1212', N'PT & TK thuật toán', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1213', N'Web - Internet', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1214', N'Mạng máy tính', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1215', N'Truyền số liệu', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1216', N'Đồ án cơ sở ngành', 1)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1217', N'Xử lý tiếng nói', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1301', N'Lập trình Windows', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1302', N'Trí tuệ nhân tạo', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1303', N'Phát triển phần mềm mã nguồn mở', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1304', N'Ngôn ngữ lập trình', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1305', N'PTTK hệ thống', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1306', N'Xử lý ảnh', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1307', N'Hệ QTCSDL', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1308', N'Lập trình Web', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1309', N'Lập trình Java', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1310', N'Lập trình cơ sở dữ liệu', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1311', N'Quản trị mạng máy tính', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1312', N'Hệ thống phân tán', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1313', N'An toàn hệ thống và an ninh mạng', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1314', N'Lập trình mạng', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1316', N'Thiết kế mạng máy tính', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1317', N'Tương tác người máy', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1319', N'Quản trị dự án công nghệ thông tin', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1321', N'Nhập môn công nghệ phần mềm', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1322', N'Đảm bảo chất lượng phần mềm', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1324', N'Phân tích thiết kế hướng đối tượng', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1325', N'Phát triển phần mềm hướng dịch vụ', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1327', N'Quản trị dự án công nghệ thông tin', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1330', N'Lập trình mạng', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1331', N'Khai phá dữ liệu', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1332', N'Hệ trợ giúp quyết định', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1333', N'Đồ án chuyên ngành', 1)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1334', N'Nguyên lý máy học', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1335', N'Thị giác máy tính', 3)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1336', N'Đồ án công nghệ phần mềm', 1)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1601', N'Thực tập tốt nghiệp', 2)
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinChi]) VALUES (N'TH1602', N'Khóa luận tốt nghiệp', 10)
SET IDENTITY_INSERT [dbo].[Note] ON 

INSERT [dbo].[Note] ([Id], [MSSV], [TieuDe], [GhiChu], [NgayLap], [NgayThongBao], [LanThongBao]) VALUES (9, N'1', N'aaa', N'aa', CAST(0x0000A7F700F0F6F5 AS DateTime), CAST(0x0000A7F800F84A80 AS DateTime), 1)
INSERT [dbo].[Note] ([Id], [MSSV], [TieuDe], [GhiChu], [NgayLap], [NgayThongBao], [LanThongBao]) VALUES (10, N'1', N'qqq', N'qqq', CAST(0x0000A7F700F13BCA AS DateTime), CAST(0x0000A7F700F7BDE0 AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Note] OFF
INSERT [dbo].[SinhVien] ([MSSV], [Pass], [HoTenSV], [NgaySinh], [Lop], [Nganh], [HeDT], [khoaHoc]) VALUES (N'1', N'', N'Tester', N'27/09/1997', N'1OTO15A', N'Công nghệ kỹ thuật ô tô', N'Đại học', 2015)
INSERT [dbo].[SinhVien] ([MSSV], [Pass], [HoTenSV], [NgaySinh], [Lop], [Nganh], [HeDT], [khoaHoc]) VALUES (N'15004116', N'1', N'Lê Bá Trọng', N'27/09/1997', N'1CTT15A', N'Công nghệ thông tin', N'Đại học', 2015)
INSERT [dbo].[SinhVien] ([MSSV], [Pass], [HoTenSV], [NgaySinh], [Lop], [Nganh], [HeDT], [khoaHoc]) VALUES (N'admin', N'admin', N'Admin', N'27/09/1997', N'1CTT15A', N'Công nghệ thông tin', N'Đại học', 2015)
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
