USE [master]
GO
/****** Object:  Database [CoffeeShop]    Script Date: 4/17/2018 12:34:47 PM ******/
CREATE DATABASE [CoffeeShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoffeeShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CoffeeShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CoffeeShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CoffeeShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CoffeeShop] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoffeeShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoffeeShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoffeeShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoffeeShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoffeeShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoffeeShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoffeeShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoffeeShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoffeeShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoffeeShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoffeeShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CoffeeShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoffeeShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoffeeShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoffeeShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoffeeShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoffeeShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoffeeShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoffeeShop] SET RECOVERY FULL 
GO
ALTER DATABASE [CoffeeShop] SET  MULTI_USER 
GO
ALTER DATABASE [CoffeeShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoffeeShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoffeeShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoffeeShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CoffeeShop] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CoffeeShop', N'ON'
GO
ALTER DATABASE [CoffeeShop] SET QUERY_STORE = OFF
GO
USE [CoffeeShop]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CoffeeShop]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 4/17/2018 12:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[SoBan] [int] Identity NOT NULL,
	[TenBan] [nvarchar](100) NOT NULL DEFAULT N'Chưa đặt tên',
	[STTus] [nvarchar](100) NOT NULL DEFAULT N'Trống',
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[SoBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 4/17/2018 12:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[Id] [int] Identity NOT NULL,
	[SoHoaDon] [int]  NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[SoLuong] [int] NOT NULL DEFAULT 0
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Account]    Script Date: 4/17/2018 12:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100)  PRIMARY KEY,
	[DisplayName] [nvarchar](100) NOT NULL DEFAULT N'Huấn Hoàng',
	[Password] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL DEFAULT 0 --1 admin, 0 staff
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[DanhMuc]   Script Date: 4/17/2018 12:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[Id] [int] Identity primary key,
	[Name] [nvarchar](100) NOT NULL DEFAULT N'Chưa đặt tên',
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[HoaDon]    Script Date: 4/17/2018 12:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[SoHoaDon] [int] Identity NOT NULL,
	[NgayXuat] [date] NOT NULL  DEFAULT GETDATE(),
	[SoBan] [int] NOT NULL,
	[STTus] [nvarchar](100) NOT NULL DEFAULT 0, --2 đặt, 1 có, 0 trống
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 4/17/2018 12:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [int] Identity PRIMARY KEY ,
	[TenSanPham] [nvarchar](50) NOT NULL DEFAULT N'Chưa đặt tên',
	[DonGia] [float] NOT NULL  DEFAULT 0,
	[IdDanhMuc] [int] NOT NULL,
	foreign key (IdDanhMuc) References dbo.DanhMuc(Id)
 )
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([SoHoaDon])
REFERENCES [dbo].[HoaDon] ([SoHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Ban] FOREIGN KEY([SoBan])
REFERENCES [dbo].[Ban] ([SoBan])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Ban]
GO
USE [master]
GO
ALTER DATABASE [CoffeeShop] SET  READ_WRITE 
GO
USE [CoffeeShop]
go 

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(1000)
as
begin
	Select * From dbo.Account where UserName = @userName and Password = @passWord
end 
go

declare @i int = 1

while @i <= 10

begin
	insert dbo.Ban (TenBan) Values (N'Bàn ' +CAST(@i as nvarchar(100)))
	set @i = @i+1
end 

go 

create proc USP_GetTableList
as
begin
	Select * From dbo.Ban
end 
go

insert dbo.Account(UserName,DisplayName,Password,Type) Values (N'Huan', N'Huấn', N'Password:1', 0)
insert dbo.Account(UserName,DisplayName,Password,Type) Values (N'Admin', N'Admin', N'123', 1)
go
insert dbo.DanhMuc (Name) Values (N'SoDa')
insert dbo.DanhMuc (Name) Values (N'Nước giải khát')
insert dbo.DanhMuc (Name) Values (N'Ăn vặt')
insert dbo.DanhMuc (Name) Values (N'Bánh ngọt')
go	
insert dbo.SanPham(TenSanPham,IdDanhMuc,DonGia) Values (N'Mực một nắng', 1, 200000)
insert dbo.SanPham(TenSanPham,IdDanhMuc,DonGia) Values (N'Trìa hấp sả', 1, 50000)
insert dbo.SanPham(TenSanPham,IdDanhMuc,DonGia) Values (N'Càng ghẹ rang me', 1, 100000)
insert dbo.SanPham(TenSanPham,IdDanhMuc,DonGia) Values (N'Cocacola', 2, 10000)
insert dbo.SanPham(TenSanPham,IdDanhMuc,DonGia) Values (N'Pepsi', 2, 10000)
insert dbo.SanPham(TenSanPham,IdDanhMuc,DonGia) Values (N'Beer', 2, 10000)
insert dbo.SanPham(TenSanPham,IdDanhMuc,DonGia) Values (N'Bò bía', 3, 15000)
insert dbo.SanPham(TenSanPham,IdDanhMuc,DonGia) Values (N'Bánh kem', 4, 100000)
go

insert dbo.HoaDon(NgayXuat,SoBan,STTus) Values (GETDATE(), 1, 1)
insert dbo.HoaDon(NgayXuat,SoBan,STTus) Values (GETDATE(), 2, 1)
insert dbo.HoaDon(NgayXuat,SoBan,STTus) Values (GETDATE(), 3, 1)
insert dbo.HoaDon(NgayXuat,SoBan,STTus) Values (GETDATE(), 4, 0)
insert dbo.HoaDon(NgayXuat,SoBan,STTus) Values (GETDATE(), 5, 0)
go

insert dbo.ChiTietHoaDon(SoHoaDon,MaSanPham,SoLuong) Values (1, 1, 1)
insert dbo.ChiTietHoaDon(SoHoaDon,MaSanPham,SoLuong) Values (2, 2, 1)
insert dbo.ChiTietHoaDon(SoHoaDon,MaSanPham,SoLuong) Values (3, 3, 1)
insert dbo.ChiTietHoaDon(SoHoaDon,MaSanPham,SoLuong) Values (4, 4, 1)
insert dbo.ChiTietHoaDon(SoHoaDon,MaSanPham,SoLuong) Values (5, 5, 1)
insert dbo.ChiTietHoaDon(SoHoaDon,MaSanPham,SoLuong) Values (1, 6, 1)
insert dbo.ChiTietHoaDon(SoHoaDon,MaSanPham,SoLuong) Values (5, 7, 1)
insert dbo.ChiTietHoaDon(SoHoaDon,MaSanPham,SoLuong) Values (4, 8, 1)
go

select * from ChiTietHoaDon