USE [master]
GO
/****** Object:  Database [QLSTMN_C]    Script Date: 06/10/2023 10:04:54 PM ******/
CREATE DATABASE [QLSTMN_C]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSTMN_C#', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLSTMN_C#.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSTMN_C#_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QLSTMN_C#_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLSTMN_C] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSTMN_C].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSTMN_C] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSTMN_C] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSTMN_C] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSTMN_C] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSTMN_C] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSTMN_C] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSTMN_C] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSTMN_C] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSTMN_C] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSTMN_C] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSTMN_C] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSTMN_C] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSTMN_C] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSTMN_C] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSTMN_C] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSTMN_C] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSTMN_C] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSTMN_C] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSTMN_C] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSTMN_C] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSTMN_C] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSTMN_C] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSTMN_C] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLSTMN_C] SET  MULTI_USER 
GO
ALTER DATABASE [QLSTMN_C] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSTMN_C] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSTMN_C] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSTMN_C] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSTMN_C] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLSTMN_C] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLSTMN_C] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLSTMN_C] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLSTMN_C]
GO
/****** Object:  User [ADN]    Script Date: 06/10/2023 10:04:54 PM ******/
CREATE USER [ADN] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 06/10/2023 10:04:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaNhap] [varchar](50) NOT NULL,
	[MaHH] [varchar](50) NOT NULL,
	[GiaNhap] [money] NOT NULL,
	[Soluong] [int] NOT NULL,
	[ThanhTien] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 06/10/2023 10:04:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuat](
	[MaXuat] [varchar](50) NOT NULL,
	[MaHH] [varchar](50) NOT NULL,
	[GiaXuat] [money] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 06/10/2023 10:04:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHH] [varchar](50) NOT NULL,
	[MaNCC] [varchar](50) NOT NULL,
	[MaNH] [varchar](50) NOT NULL,
	[GiaNhap] [money] NOT NULL,
	[GiaXuat] [money] NOT NULL,
	[TonKho] [int] NOT NULL,
	[TenHH] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 06/10/2023 10:04:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[taikhoan] [varchar](50) NOT NULL,
	[matkhau] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 06/10/2023 10:04:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DiaChiNcc] [nvarchar](50) NOT NULL,
	[SdtNcc] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 06/10/2023 10:04:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[Manv] [varchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[ChucVu] [bit] NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[NamSinh] [int] NOT NULL,
	[SdtNV] [varchar](50) NOT NULL,
	[DiaChiNV] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomHang]    Script Date: 06/10/2023 10:04:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomHang](
	[MaNH] [varchar](50) NOT NULL,
	[TenNhomHang] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 06/10/2023 10:04:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaNhap] [varchar](50) NOT NULL,
	[MaNCC] [varchar](50) NOT NULL,
	[MaNV] [varchar](50) NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[TongTien] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 06/10/2023 10:04:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaXuat] [varchar](50) NOT NULL,
	[MaNV] [varchar](50) NOT NULL,
	[NgayXuat] [date] NOT NULL,
	[TongTien] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaNhap], [MaHH], [GiaNhap], [Soluong], [ThanhTien]) VALUES (N'MN01', N'0000000001', 10000.0000, 2, 20000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaNhap], [MaHH], [GiaNhap], [Soluong], [ThanhTien]) VALUES (N'MN07', N'0000000001', 10000.0000, 2, 20000.0000)
GO
INSERT [dbo].[HangHoa] ([MaHH], [MaNCC], [MaNH], [GiaNhap], [GiaXuat], [TonKho], [TenHH]) VALUES (N'0000000001', N'NCC1', N'NH01', 10000.0000, 20000.0000, 17, NULL)
GO
INSERT [dbo].[Login] ([taikhoan], [matkhau]) VALUES (N'Seller', N'1')
INSERT [dbo].[Login] ([taikhoan], [matkhau]) VALUES (N'Importer', N'2')
INSERT [dbo].[Login] ([taikhoan], [matkhau]) VALUES (N'Manager', N'3')
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNcc], [SdtNcc]) VALUES (N'NCC01', N'Công ty A', N'Hà Nội', N'0123456789')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNcc], [SdtNcc]) VALUES (N'NCC02', N'Công ty B', N'Hải Phòng', N'0987654321')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNcc], [SdtNcc]) VALUES (N'NCC03', N'Công ty C', N'Đà Nẵng', N'0912345678')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNcc], [SdtNcc]) VALUES (N'NCC04', N'Công ty D', N'Hồ Chí Minh', N'0901234567')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNcc], [SdtNcc]) VALUES (N'NCC05', N'Công ty E', N'Cần Thơ', N'0934567890')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChiNcc], [SdtNcc]) VALUES (N'NCC1', N'Cocacola', N'Nam Định', N'0847706667')
GO
INSERT [dbo].[Nhanvien] ([Manv], [TenNV], [ChucVu], [GioiTinh], [NamSinh], [SdtNV], [DiaChiNV]) VALUES (N'N01', N'Trần Duy Hải', 1, 1, 2002, N'0847706667', N'Nam Định')
INSERT [dbo].[Nhanvien] ([Manv], [TenNV], [ChucVu], [GioiTinh], [NamSinh], [SdtNV], [DiaChiNV]) VALUES (N'N02', N'Nguyễn Công Danh', 0, 1, 2002, N'0564116744', N'Sóc Sơn')
INSERT [dbo].[Nhanvien] ([Manv], [TenNV], [ChucVu], [GioiTinh], [NamSinh], [SdtNV], [DiaChiNV]) VALUES (N'NV01', N'Nguyễn Văn A', 1, 1, 1980, N'0123456789', N'Hà Nội')
INSERT [dbo].[Nhanvien] ([Manv], [TenNV], [ChucVu], [GioiTinh], [NamSinh], [SdtNV], [DiaChiNV]) VALUES (N'NV02', N'Trần Thị B', 1, 0, 1985, N'0987654321', N'Hải Phòng')
INSERT [dbo].[Nhanvien] ([Manv], [TenNV], [ChucVu], [GioiTinh], [NamSinh], [SdtNV], [DiaChiNV]) VALUES (N'NV03', N'Lê Văn C', 0, 1, 1990, N'0912345678', N'Đà Nẵng')
INSERT [dbo].[Nhanvien] ([Manv], [TenNV], [ChucVu], [GioiTinh], [NamSinh], [SdtNV], [DiaChiNV]) VALUES (N'NV04', N'Phạm Thị D', 0, 0, 1995, N'0901234567', N'Hồ Chí Minh')
INSERT [dbo].[Nhanvien] ([Manv], [TenNV], [ChucVu], [GioiTinh], [NamSinh], [SdtNV], [DiaChiNV]) VALUES (N'NV05', N'Nguyễn Thị E', 1, 0, 2000, N'0934567890', N'Cần Thơ')
GO
INSERT [dbo].[NhomHang] ([MaNH], [TenNhomHang]) VALUES (N'NH01', N'Nước giải khát')
INSERT [dbo].[NhomHang] ([MaNH], [TenNhomHang]) VALUES (N'NH02', N'Bánh kẹo')
INSERT [dbo].[NhomHang] ([MaNH], [TenNhomHang]) VALUES (N'NH03', N'Sữa')
INSERT [dbo].[NhomHang] ([MaNH], [TenNhomHang]) VALUES (N'NH04', N'Gạo')
INSERT [dbo].[NhomHang] ([MaNH], [TenNhomHang]) VALUES (N'NH05', N'Dầu ăn')
GO
INSERT [dbo].[PhieuNhap] ([MaNhap], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'1', N'NCC01', N'NV01', CAST(N'2021-12-01' AS Date), 250000.0000)
INSERT [dbo].[PhieuNhap] ([MaNhap], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'2', N'NCC02', N'NV02', CAST(N'2021-12-02' AS Date), 270000.0000)
INSERT [dbo].[PhieuNhap] ([MaNhap], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'3', N'NCC03', N'NV03', CAST(N'2021-12-03' AS Date), 300000.0000)
INSERT [dbo].[PhieuNhap] ([MaNhap], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'4', N'NCC04', N'NV04', CAST(N'2021-12-04' AS Date), 320000.0000)
INSERT [dbo].[PhieuNhap] ([MaNhap], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'5', N'NCC05', N'NV05', CAST(N'2021-12-05' AS Date), 350000.0000)
INSERT [dbo].[PhieuNhap] ([MaNhap], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'MN01', N'NCC1', N'N02', CAST(N'2023-05-24' AS Date), 20000.0000)
INSERT [dbo].[PhieuNhap] ([MaNhap], [MaNCC], [MaNV], [NgayNhap], [TongTien]) VALUES (N'MN07', N'NCC1', N'NV03', CAST(N'2023-05-29' AS Date), 0.0000)
GO
INSERT [dbo].[PhieuXuat] ([MaXuat], [MaNV], [NgayXuat], [TongTien]) VALUES (N'MX1', N'NV01', CAST(N'2021-12-01' AS Date), 240000.0000)
INSERT [dbo].[PhieuXuat] ([MaXuat], [MaNV], [NgayXuat], [TongTien]) VALUES (N'MX2', N'NV02', CAST(N'2021-12-02' AS Date), 360000.0000)
INSERT [dbo].[PhieuXuat] ([MaXuat], [MaNV], [NgayXuat], [TongTien]) VALUES (N'MX3', N'NV03', CAST(N'2021-12-03' AS Date), 480000.0000)
INSERT [dbo].[PhieuXuat] ([MaXuat], [MaNV], [NgayXuat], [TongTien]) VALUES (N'MX4', N'NV04', CAST(N'2021-12-04' AS Date), 600000.0000)
INSERT [dbo].[PhieuXuat] ([MaXuat], [MaNV], [NgayXuat], [TongTien]) VALUES (N'MX5', N'NV05', CAST(N'2021-12-05' AS Date), 720000.0000)
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [LK_CTPN_HH] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [LK_CTPN_HH]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [LK_CTPN_PN] FOREIGN KEY([MaNhap])
REFERENCES [dbo].[PhieuNhap] ([MaNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [LK_CTPN_PN]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [LK_CTPX_HH] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoa] ([MaHH])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [LK_CTPX_HH]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [LK_CTPX_PX] FOREIGN KEY([MaXuat])
REFERENCES [dbo].[PhieuXuat] ([MaXuat])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [LK_CTPX_PX]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [LK_HH_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [LK_HH_NCC]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [LK_HH_NH] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhomHang] ([MaNH])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [LK_HH_NH]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [LK_PN_NCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [LK_PN_NCC]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [LK_PN_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhanvien] ([Manv])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [LK_PN_NV]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [LK_PX_NV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[Nhanvien] ([Manv])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [LK_PX_NV]
GO
USE [master]
GO
ALTER DATABASE [QLSTMN_C] SET  READ_WRITE 
GO
