USE [master]
GO
/****** Object:  Database [Sürücü_Kursu_Otomasyonu]    Script Date: 1.06.2022 16:43:25 ******/
CREATE DATABASE [Sürücü_Kursu_Otomasyonu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sürücü_Kursu_Otomasyonu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sürücü_Kursu_Otomasyonu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sürücü_Kursu_Otomasyonu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sürücü_Kursu_Otomasyonu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sürücü_Kursu_Otomasyonu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET  MULTI_USER 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET QUERY_STORE = OFF
GO
USE [Sürücü_Kursu_Otomasyonu]
GO
/****** Object:  Table [dbo].[kisiselbilgiler]    Script Date: 1.06.2022 16:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kisiselbilgiler](
	[serino] [int] IDENTITY(1,1) NOT NULL,
	[tc] [nvarchar](50) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NOT NULL,
	[babaAd] [nvarchar](50) NOT NULL,
	[anneAd] [nvarchar](50) NOT NULL,
	[cinsiyet] [nvarchar](50) NOT NULL,
	[dtarih] [datetime] NOT NULL,
	[uyruk] [nvarchar](50) NOT NULL,
	[kangrup] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_kisiselbilgiler] PRIMARY KEY CLUSTERED 
(
	[serino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kursiyer_Kaydı]    Script Date: 1.06.2022 16:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kursiyer_Kaydı](
	[aday_id] [int] IDENTITY(1,1) NOT NULL,
	[tc_kimlik] [nvarchar](50) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NOT NULL,
	[kul_arac] [nvarchar](50) NULL,
	[yas] [nvarchar](50) NOT NULL,
	[tahsil] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[rapor] [nvarchar](50) NOT NULL,
	[belge] [nvarchar](50) NOT NULL,
	[kayit_tarih] [datetime] NOT NULL,
	[sınıf_ad] [nvarchar](50) NULL,
	[ehliyet_sınıfı] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kursiyer_Kaydı] PRIMARY KEY CLUSTERED 
(
	[aday_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notbilgisi]    Script Date: 1.06.2022 16:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notbilgisi](
	[ıd] [int] IDENTITY(1,1) NOT NULL,
	[tc] [nvarchar](50) NOT NULL,
	[sınavtarihi] [datetime] NOT NULL,
	[tnot] [nvarchar](50) NOT NULL,
	[mnot] [nvarchar](50) NOT NULL,
	[ilknot] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_notbilgisi] PRIMARY KEY CLUSTERED 
(
	[ıd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[odeme]    Script Date: 1.06.2022 16:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odeme](
	[ıd] [int] IDENTITY(1,1) NOT NULL,
	[tc] [nvarchar](50) NOT NULL,
	[otarih] [datetime] NOT NULL,
	[topborc] [nvarchar](50) NOT NULL,
	[otutar] [nvarchar](50) NOT NULL,
	[kborc] [nvarchar](50) NOT NULL,
	[osekli] [nvarchar](50) NOT NULL,
	[ocekim] [nvarchar](50) NULL,
	[tsayısı] [nvarchar](50) NULL,
 CONSTRAINT [PK_odeme] PRIMARY KEY CLUSTERED 
(
	[ıd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personelbilgisi]    Script Date: 1.06.2022 16:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personelbilgisi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[tc] [nvarchar](50) NOT NULL,
	[adı] [nvarchar](50) NOT NULL,
	[soyadı] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[adres] [nvarchar](50) NOT NULL,
	[eposta] [nvarchar](50) NOT NULL,
	[görevi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_personelbilgisi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_login]    Script Date: 1.06.2022 16:43:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_login](
	[kID] [int] IDENTITY(1,1) NOT NULL,
	[kullanici] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_login] PRIMARY KEY CLUSTERED 
(
	[kID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[kisiselbilgiler] ON 

INSERT [dbo].[kisiselbilgiler] ([serino], [tc], [ad], [soyad], [babaAd], [anneAd], [cinsiyet], [dtarih], [uyruk], [kangrup]) VALUES (15, N'333333', N'A', N'ZA', N'AAA', N'AAAAAAAAA', N'BAY', CAST(N'2021-05-31T19:42:59.000' AS DateTime), N'TC', N'B0RH+')
INSERT [dbo].[kisiselbilgiler] ([serino], [tc], [ad], [soyad], [babaAd], [anneAd], [cinsiyet], [dtarih], [uyruk], [kangrup]) VALUES (16, N'4544646', N'RABİA', N'DURNAĞOLU', N'AA', N'BB', N'BAYAN', CAST(N'2000-05-31T19:49:56.000' AS DateTime), N'TC', N'A0RH-')
SET IDENTITY_INSERT [dbo].[kisiselbilgiler] OFF
GO
SET IDENTITY_INSERT [dbo].[Kursiyer_Kaydı] ON 

INSERT [dbo].[Kursiyer_Kaydı] ([aday_id], [tc_kimlik], [ad], [soyad], [kul_arac], [yas], [tahsil], [telefon], [rapor], [belge], [kayit_tarih], [sınıf_ad], [ehliyet_sınıfı]) VALUES (1029, N'11111111111', N'qwe', N'qwe', N'N', N'34', N'LİSE', N'313123123', N'VAR', N'VAR', CAST(N'2022-06-01T16:25:11.000' AS DateTime), N'2022/1 SABAH', N'A1')
INSERT [dbo].[Kursiyer_Kaydı] ([aday_id], [tc_kimlik], [ad], [soyad], [kul_arac], [yas], [tahsil], [telefon], [rapor], [belge], [kayit_tarih], [sınıf_ad], [ehliyet_sınıfı]) VALUES (1030, N'13123123', N'gfb', N'gfb', N'N', N'34', N'LİSE', N'313123123', N'VAR', N'VAR', CAST(N'2022-06-01T16:25:11.000' AS DateTime), N'2022/1 SABAH', N'A1')
INSERT [dbo].[Kursiyer_Kaydı] ([aday_id], [tc_kimlik], [ad], [soyad], [kul_arac], [yas], [tahsil], [telefon], [rapor], [belge], [kayit_tarih], [sınıf_ad], [ehliyet_sınıfı]) VALUES (1031, N'13123123', N'asd', N'asd', N'N', N'34', N'LİSE', N'313123123', N'VAR', N'VAR', CAST(N'2022-06-01T16:25:11.000' AS DateTime), N'2022/1 SABAH', N'A1')
INSERT [dbo].[Kursiyer_Kaydı] ([aday_id], [tc_kimlik], [ad], [soyad], [kul_arac], [yas], [tahsil], [telefon], [rapor], [belge], [kayit_tarih], [sınıf_ad], [ehliyet_sınıfı]) VALUES (1032, N'22222222222', N'qwdq', N'qwe', N'N', N'34', N'LİSE', N'313123123', N'VAR', N'VAR', CAST(N'2022-06-01T16:25:11.000' AS DateTime), N'2022/1 SABAH', N'A1')
INSERT [dbo].[Kursiyer_Kaydı] ([aday_id], [tc_kimlik], [ad], [soyad], [kul_arac], [yas], [tahsil], [telefon], [rapor], [belge], [kayit_tarih], [sınıf_ad], [ehliyet_sınıfı]) VALUES (1033, N'11111111111', N'gsd', N'gs', N'N', N'34', N'LİSE', N'313123123', N'VAR', N'VAR', CAST(N'2022-06-01T16:25:11.000' AS DateTime), N'2022/1 SABAH', N'A1')
SET IDENTITY_INSERT [dbo].[Kursiyer_Kaydı] OFF
GO
SET IDENTITY_INSERT [dbo].[notbilgisi] ON 

INSERT [dbo].[notbilgisi] ([ıd], [tc], [sınavtarihi], [tnot], [mnot], [ilknot]) VALUES (33, N'4444455', CAST(N'2022-05-31T10:33:32.000' AS DateTime), N'90', N'60', N'60')
INSERT [dbo].[notbilgisi] ([ıd], [tc], [sınavtarihi], [tnot], [mnot], [ilknot]) VALUES (40, N'4544646', CAST(N'2022-05-31T19:50:32.000' AS DateTime), N'100', N'100', N'100')
SET IDENTITY_INSERT [dbo].[notbilgisi] OFF
GO
SET IDENTITY_INSERT [dbo].[personelbilgisi] ON 

INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (10, N'111111', N'x', N'y', N'5555', N'aaaa', N'aaaa', N'aa')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (11, N'1111155', N'all', N'vell', N'122222', N'antep', N'al@gmail.com', N'yardımcı')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (12, N'1222', N'ayse', N'er', N'555', N'erzurum', N'555555', N'e@gmail.com')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (14, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (15, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (16, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (17, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (18, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (19, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (20, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (21, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (22, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (23, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (24, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (25, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (26, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (27, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (28, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (29, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (30, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (31, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (32, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (33, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (34, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (35, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (36, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (37, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (38, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (39, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (40, N'1222', N'ayseE', N'er', N'555', N'erzurum', N'555555', N'e@gmail.com')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (41, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (42, N'111111', N'x', N'y', N'5555', N'aaaa', N'aaaa', N'aa')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (43, N'1222', N'ayse', N'er', N'555', N'erzurum', N'555555', N'e@gmail.com')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (44, N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (45, N'111111555', N'xrr', N'y', N'5555', N'aaaa', N'aaaa', N'aa')
INSERT [dbo].[personelbilgisi] ([ID], [tc], [adı], [soyadı], [telefon], [adres], [eposta], [görevi]) VALUES (46, N'', N'', N'', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[personelbilgisi] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_login] ON 

INSERT [dbo].[tbl_login] ([kID], [kullanici], [sifre]) VALUES (1, N'pnarr', N'e10adc3949ba59abbe56e057f20f883e')
SET IDENTITY_INSERT [dbo].[tbl_login] OFF
GO
USE [master]
GO
ALTER DATABASE [Sürücü_Kursu_Otomasyonu] SET  READ_WRITE 
GO
