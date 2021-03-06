USE [master]
GO
/****** Object:  Database [db_UKK_Adhi]    Script Date: 15/04/2021 00:21:42 ******/
CREATE DATABASE [db_UKK_Adhi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_PraUKK_Adhi', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_PraUKK_Adhi.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_PraUKK_Adhi_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_PraUKK_Adhi_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_UKK_Adhi] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_UKK_Adhi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_UKK_Adhi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_UKK_Adhi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_UKK_Adhi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_UKK_Adhi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_UKK_Adhi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_UKK_Adhi] SET  MULTI_USER 
GO
ALTER DATABASE [db_UKK_Adhi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_UKK_Adhi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_UKK_Adhi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_UKK_Adhi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_UKK_Adhi] SET DELAYED_DURABILITY = DISABLED 
GO
USE [db_UKK_Adhi]
GO
/****** Object:  Table [dbo].[kelas]    Script Date: 15/04/2021 00:21:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kelas](
	[id_kelas] [char](10) NOT NULL,
	[nama_kelas] [varchar](50) NULL,
	[kompetensi_keahlian] [varchar](50) NULL,
 CONSTRAINT [PK_kelas] PRIMARY KEY CLUSTERED 
(
	[id_kelas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pembayaran]    Script Date: 15/04/2021 00:21:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pembayaran](
	[id_pembayaran] [char](10) NOT NULL,
	[id_petugas] [char](10) NULL,
	[nisn] [varchar](50) NULL,
	[tgl_bayar] [date] NULL,
	[id_spp] [char](10) NULL,
	[jumlah_bayar] [int] NULL,
 CONSTRAINT [PK_pembayaran] PRIMARY KEY CLUSTERED 
(
	[id_pembayaran] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[petugas]    Script Date: 15/04/2021 00:21:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[petugas](
	[id_petugas] [char](10) NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[nama_petugas] [varchar](50) NULL,
	[hak] [varchar](50) NULL,
 CONSTRAINT [PK_petugas] PRIMARY KEY CLUSTERED 
(
	[id_petugas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[siswa]    Script Date: 15/04/2021 00:21:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[siswa](
	[nisn] [varchar](50) NOT NULL,
	[nis] [char](10) NULL,
	[nama] [varchar](50) NULL,
	[id_kelas] [char](10) NULL,
	[alamat] [text] NULL,
	[no_telp] [varchar](50) NULL,
	[id_spp] [char](10) NULL,
 CONSTRAINT [PK_siswa] PRIMARY KEY CLUSTERED 
(
	[nisn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[spp]    Script Date: 15/04/2021 00:21:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[spp](
	[id_spp] [char](10) NOT NULL,
	[tahun] [int] NULL,
	[nominal] [int] NULL,
 CONSTRAINT [PK_spp] PRIMARY KEY CLUSTERED 
(
	[id_spp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbsiswa]    Script Date: 15/04/2021 00:21:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbsiswa](
	[id_siswa] [char](10) NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[nama_siswa] [varchar](50) NULL,
 CONSTRAINT [PK_tbsiswa] PRIMARY KEY CLUSTERED 
(
	[id_siswa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[kelas] ([id_kelas], [nama_kelas], [kompetensi_keahlian]) VALUES (N'IK-01     ', N'12', N'RPL')
INSERT [dbo].[kelas] ([id_kelas], [nama_kelas], [kompetensi_keahlian]) VALUES (N'IK-02     ', N'12', N'TKJ')
INSERT [dbo].[kelas] ([id_kelas], [nama_kelas], [kompetensi_keahlian]) VALUES (N'IK-03     ', N'12', N'MM')
INSERT [dbo].[kelas] ([id_kelas], [nama_kelas], [kompetensi_keahlian]) VALUES (N'IK-04     ', N'11', N'BDP')
INSERT [dbo].[kelas] ([id_kelas], [nama_kelas], [kompetensi_keahlian]) VALUES (N'IK-05     ', N'12', N'OTKP')
INSERT [dbo].[kelas] ([id_kelas], [nama_kelas], [kompetensi_keahlian]) VALUES (N'IK-06     ', N'11', N'RPL')
INSERT [dbo].[kelas] ([id_kelas], [nama_kelas], [kompetensi_keahlian]) VALUES (N'IK-07     ', N'10', N'RPL')
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-001    ', N'P-02      ', N'NISN-01', CAST(N'2021-02-25' AS Date), N'SPP-03    ', 500000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-002    ', N'P-03      ', N'NISN-04', CAST(N'2021-02-26' AS Date), N'SPP-03    ', 500000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-003    ', N'P-03      ', N'NISN-01', CAST(N'2021-02-16' AS Date), N'SPP-02    ', 368000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-004    ', N'P-03      ', N'NISN-03', CAST(N'2021-02-27' AS Date), N'SPP-04    ', 140000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-005    ', N'P-02      ', N'NISN-04', CAST(N'2021-02-26' AS Date), N'SPP-03    ', 500000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-006    ', N'P-03      ', N'NISN-03', CAST(N'2021-02-25' AS Date), N'SPP-02    ', 368000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-007    ', N'P-03      ', N'NISN-04', CAST(N'2021-02-27' AS Date), N'SPP-01    ', 1000000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-008    ', N'P-01      ', N'NISN-05', CAST(N'2021-04-07' AS Date), N'SPP-01    ', 1000000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-009    ', N'P-01      ', N'NISN-04', CAST(N'2021-04-07' AS Date), N'SPP-01    ', 1000000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-10     ', N'P-01      ', N'NISN-06', CAST(N'2021-04-07' AS Date), N'SPP-05    ', 345000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-11     ', N'P-04      ', N'NISN-06', CAST(N'2021-04-07' AS Date), N'SPP-04    ', 140000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-12     ', N'P-05      ', N'NISN-08', CAST(N'2021-04-08' AS Date), N'SPP-01    ', 1000000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-13     ', N'P-04      ', N'NISN-07', CAST(N'2021-04-08' AS Date), N'SPP-04    ', 140000)
INSERT [dbo].[pembayaran] ([id_pembayaran], [id_petugas], [nisn], [tgl_bayar], [id_spp], [jumlah_bayar]) VALUES (N'IP-14     ', N'P-05      ', N'NISN-07', CAST(N'2021-04-16' AS Date), N'SPP-04    ', 140000)
INSERT [dbo].[petugas] ([id_petugas], [username], [password], [nama_petugas], [hak]) VALUES (N'P-01      ', N'admin', N'123', N'Adhi Nugraha Saputra', N'Admin')
INSERT [dbo].[petugas] ([id_petugas], [username], [password], [nama_petugas], [hak]) VALUES (N'P-02      ', N'adhi', N'123', N'Adhi Nugraha Saputra', N'Operator')
INSERT [dbo].[petugas] ([id_petugas], [username], [password], [nama_petugas], [hak]) VALUES (N'P-03      ', N'aqil', N'123', N'Aqil Rasyid', N'Admin')
INSERT [dbo].[petugas] ([id_petugas], [username], [password], [nama_petugas], [hak]) VALUES (N'P-04      ', N'Rizky', N'123', N'Eliazer Rizky', N'Admin')
INSERT [dbo].[petugas] ([id_petugas], [username], [password], [nama_petugas], [hak]) VALUES (N'P-05      ', N'Farisqi', N'1233', N'Faris', N'Admin')
INSERT [dbo].[petugas] ([id_petugas], [username], [password], [nama_petugas], [hak]) VALUES (N'S-06      ', N'siswa', N'123', N'Adhi Nugraha Saputra', N'Siswa')
INSERT [dbo].[siswa] ([nisn], [nis], [nama], [id_kelas], [alamat], [no_telp], [id_spp]) VALUES (N'NISN-01', N'122421    ', N'Adhi', N'IK-04     ', N'Suryanata', N'081253424890', N'SPP-01    ')
INSERT [dbo].[siswa] ([nisn], [nis], [nama], [id_kelas], [alamat], [no_telp], [id_spp]) VALUES (N'NISN-02', N'189089    ', N'Reza', N'IK-03     ', N'Bengkuring', N'0897634579', N'SPP-02    ')
INSERT [dbo].[siswa] ([nisn], [nis], [nama], [id_kelas], [alamat], [no_telp], [id_spp]) VALUES (N'NISN-03', N'124412    ', N'Irfan', N'IK-01     ', N'Juanda', N'08912321142', N'SPP-01    ')
INSERT [dbo].[siswa] ([nisn], [nis], [nama], [id_kelas], [alamat], [no_telp], [id_spp]) VALUES (N'NISN-04', N'122113    ', N'Jaki', N'IK-03     ', N'Suryanata', N'081244212321', N'SPP-02    ')
INSERT [dbo].[siswa] ([nisn], [nis], [nama], [id_kelas], [alamat], [no_telp], [id_spp]) VALUES (N'NISN-05', N'213344    ', N'Henry', N'IK-01     ', N'Suryanata', N'082124412234', N'SPP-02    ')
INSERT [dbo].[siswa] ([nisn], [nis], [nama], [id_kelas], [alamat], [no_telp], [id_spp]) VALUES (N'NISN-06', N'123343    ', N'JONTo', N'IK-06     ', N'Bengkulu', N'0821299213312', N'SPP-01    ')
INSERT [dbo].[siswa] ([nisn], [nis], [nama], [id_kelas], [alamat], [no_telp], [id_spp]) VALUES (N'NISN-07', N'235123    ', N'Aqil Rasyid', N'IK-06     ', N'Bengkuring', N'08711234123124', N'SPP-05    ')
INSERT [dbo].[siswa] ([nisn], [nis], [nama], [id_kelas], [alamat], [no_telp], [id_spp]) VALUES (N'NISN-08', N'1672342   ', N'Adhi Nugraha', N'IK-07     ', N'BEngkuring', N'081253423590', N'SPP-05    ')
INSERT [dbo].[spp] ([id_spp], [tahun], [nominal]) VALUES (N'SPP-01    ', 2020, 1000000)
INSERT [dbo].[spp] ([id_spp], [tahun], [nominal]) VALUES (N'SPP-02    ', 2019, 368000)
INSERT [dbo].[spp] ([id_spp], [tahun], [nominal]) VALUES (N'SPP-03    ', 2018, 500000)
INSERT [dbo].[spp] ([id_spp], [tahun], [nominal]) VALUES (N'SPP-04    ', 2018, 140000)
INSERT [dbo].[spp] ([id_spp], [tahun], [nominal]) VALUES (N'SPP-05    ', 2015, 345000)
INSERT [dbo].[tbsiswa] ([id_siswa], [username], [password], [nama_siswa]) VALUES (N'S-01      ', N'siswa', N'123', N'Aqil Rasyid')
ALTER TABLE [dbo].[pembayaran]  WITH CHECK ADD  CONSTRAINT [FK_pembayaran_petugas] FOREIGN KEY([id_petugas])
REFERENCES [dbo].[petugas] ([id_petugas])
GO
ALTER TABLE [dbo].[pembayaran] CHECK CONSTRAINT [FK_pembayaran_petugas]
GO
ALTER TABLE [dbo].[pembayaran]  WITH CHECK ADD  CONSTRAINT [FK_pembayaran_siswa] FOREIGN KEY([nisn])
REFERENCES [dbo].[siswa] ([nisn])
GO
ALTER TABLE [dbo].[pembayaran] CHECK CONSTRAINT [FK_pembayaran_siswa]
GO
ALTER TABLE [dbo].[pembayaran]  WITH CHECK ADD  CONSTRAINT [FK_pembayaran_spp] FOREIGN KEY([id_spp])
REFERENCES [dbo].[spp] ([id_spp])
GO
ALTER TABLE [dbo].[pembayaran] CHECK CONSTRAINT [FK_pembayaran_spp]
GO
ALTER TABLE [dbo].[siswa]  WITH CHECK ADD  CONSTRAINT [FK_siswa_kelas] FOREIGN KEY([id_kelas])
REFERENCES [dbo].[kelas] ([id_kelas])
GO
ALTER TABLE [dbo].[siswa] CHECK CONSTRAINT [FK_siswa_kelas]
GO
ALTER TABLE [dbo].[siswa]  WITH CHECK ADD  CONSTRAINT [FK_siswa_spp] FOREIGN KEY([id_spp])
REFERENCES [dbo].[spp] ([id_spp])
GO
ALTER TABLE [dbo].[siswa] CHECK CONSTRAINT [FK_siswa_spp]
GO
USE [master]
GO
ALTER DATABASE [db_UKK_Adhi] SET  READ_WRITE 
GO
