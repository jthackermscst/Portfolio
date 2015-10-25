--USE [master]
--GO
--/****** Object:  Database [ThackTracks]    Script Date: 10/25/2015 10:06:29 AM ******/
--CREATE DATABASE [ThackTracks]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'ThackTracks', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS1A\MSSQL\DATA\ThackTracks.mdf' , SIZE = 7168KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'ThackTracks_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS1A\MSSQL\DATA\ThackTracks_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
--GO
--ALTER DATABASE [ThackTracks] SET COMPATIBILITY_LEVEL = 110
--GO
--IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
--begin
--EXEC [ThackTracks].[dbo].[sp_fulltext_database] @action = 'enable'
--end
--GO
--ALTER DATABASE [ThackTracks] SET ANSI_NULL_DEFAULT OFF 
--GO
--ALTER DATABASE [ThackTracks] SET ANSI_NULLS OFF 
--GO
--ALTER DATABASE [ThackTracks] SET ANSI_PADDING OFF 
--GO
--ALTER DATABASE [ThackTracks] SET ANSI_WARNINGS OFF 
--GO
--ALTER DATABASE [ThackTracks] SET ARITHABORT OFF 
--GO
--ALTER DATABASE [ThackTracks] SET AUTO_CLOSE OFF 
--GO
--ALTER DATABASE [ThackTracks] SET AUTO_CREATE_STATISTICS ON 
--GO
--ALTER DATABASE [ThackTracks] SET AUTO_SHRINK OFF 
--GO
--ALTER DATABASE [ThackTracks] SET AUTO_UPDATE_STATISTICS ON 
--GO
--ALTER DATABASE [ThackTracks] SET CURSOR_CLOSE_ON_COMMIT OFF 
--GO
--ALTER DATABASE [ThackTracks] SET CURSOR_DEFAULT  GLOBAL 
--GO
--ALTER DATABASE [ThackTracks] SET CONCAT_NULL_YIELDS_NULL OFF 
--GO
--ALTER DATABASE [ThackTracks] SET NUMERIC_ROUNDABORT OFF 
--GO
--ALTER DATABASE [ThackTracks] SET QUOTED_IDENTIFIER OFF 
--GO
--ALTER DATABASE [ThackTracks] SET RECURSIVE_TRIGGERS OFF 
--GO
--ALTER DATABASE [ThackTracks] SET  DISABLE_BROKER 
--GO
--ALTER DATABASE [ThackTracks] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
--GO
--ALTER DATABASE [ThackTracks] SET DATE_CORRELATION_OPTIMIZATION OFF 
--GO
--ALTER DATABASE [ThackTracks] SET TRUSTWORTHY OFF 
--GO
--ALTER DATABASE [ThackTracks] SET ALLOW_SNAPSHOT_ISOLATION OFF 
--GO
--ALTER DATABASE [ThackTracks] SET PARAMETERIZATION SIMPLE 
--GO
--ALTER DATABASE [ThackTracks] SET READ_COMMITTED_SNAPSHOT OFF 
--GO
--ALTER DATABASE [ThackTracks] SET HONOR_BROKER_PRIORITY OFF 
--GO
--ALTER DATABASE [ThackTracks] SET RECOVERY SIMPLE 
--GO
--ALTER DATABASE [ThackTracks] SET  MULTI_USER 
--GO
--ALTER DATABASE [ThackTracks] SET PAGE_VERIFY CHECKSUM  
--GO
--ALTER DATABASE [ThackTracks] SET DB_CHAINING OFF 
--GO
--ALTER DATABASE [ThackTracks] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
--GO
--ALTER DATABASE [ThackTracks] SET TARGET_RECOVERY_TIME = 0 SECONDS 
--GO
--USE [ThackTracks]
--GO
/****** Object:  Table [dbo].[2hBlogger]    Script Date: 10/25/2015 10:06:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2hBlogger](
	[BloggerID] [int] NOT NULL,
	[PersonID] [int] NULL,
	[BlogDescription] [nvarchar](255) NULL,
	[DateOfLastBlog] [nvarchar](255) NULL,
	[Password] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[2hClient]    Script Date: 10/25/2015 10:06:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2hClient](
	[ClientID] [int] NOT NULL,
	[PersonID] [int] NULL,
	[SeviceID] [int] NULL,
	[DateOfSevice] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[2hEmployee]    Script Date: 10/25/2015 10:06:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2hEmployee](
	[EmpID] [int] NOT NULL,
	[PersonID] [int] NULL,
	[TalentID] [int] NULL,
	[Salary] [money] NULL,
	[Password] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[2hPerson]    Script Date: 10/25/2015 10:06:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2hPerson](
	[PersonID] [int] NOT NULL,
	[FirstName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[2hPersonAddress]    Script Date: 10/25/2015 10:06:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2hPersonAddress](
	[PersonAddressID] [int] NOT NULL,
	[PersonID] [int] NULL,
	[Address] [nvarchar](255) NULL,
	[City] [nvarchar](255) NULL,
	[State] [nvarchar](255) NULL,
	[Zip] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[2hService]    Script Date: 10/25/2015 10:06:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2hService](
	[ServiceID] [int] NOT NULL,
	[TypeOfService] [nvarchar](255) NULL,
	[ChargePerHour] [money] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[2hTalent]    Script Date: 10/25/2015 10:06:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2hTalent](
	[TalentID] [int] NOT NULL,
	[TalentDescription] [nvarchar](255) NULL,
	[Specialty] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[4hServiceTransaction]    Script Date: 10/25/2015 10:06:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[4hServiceTransaction](
	[TransID] [int] NOT NULL,
	[ClientID] [int] NULL,
	[ServiceID] [int] NULL,
	[EmpID] [int] NULL,
	[Hours] [int] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[2hBlogger] ([BloggerID], [PersonID], [BlogDescription], [DateOfLastBlog], [Password]) VALUES (1, 4, N'All About Azure', N'03/17/2015', N'skduju')
INSERT [dbo].[2hBlogger] ([BloggerID], [PersonID], [BlogDescription], [DateOfLastBlog], [Password]) VALUES (2, 5, N'Graphic Design', N'04/11/2015', N'skeiimn')
INSERT [dbo].[2hBlogger] ([BloggerID], [PersonID], [BlogDescription], [DateOfLastBlog], [Password]) VALUES (3, 7, N'Studio Gear', N'06/02/2015', N'12hthek')
INSERT [dbo].[2hClient] ([ClientID], [PersonID], [SeviceID], [DateOfSevice]) VALUES (1, 6, 3, CAST(0x0000A44F00000000 AS DateTime))
INSERT [dbo].[2hClient] ([ClientID], [PersonID], [SeviceID], [DateOfSevice]) VALUES (2, 2, 4, CAST(0x0000A4F200000000 AS DateTime))
INSERT [dbo].[2hClient] ([ClientID], [PersonID], [SeviceID], [DateOfSevice]) VALUES (3, 7, 1, CAST(0x0000A67F00000000 AS DateTime))
INSERT [dbo].[2hClient] ([ClientID], [PersonID], [SeviceID], [DateOfSevice]) VALUES (4, 10, 2, CAST(0x0000A4EF00000000 AS DateTime))
INSERT [dbo].[2hClient] ([ClientID], [PersonID], [SeviceID], [DateOfSevice]) VALUES (5, 11, 1, CAST(0x0000A64000000000 AS DateTime))
INSERT [dbo].[2hEmployee] ([EmpID], [PersonID], [TalentID], [Salary], [Password]) VALUES (1, 1, 10, 80000.0000, N'asdf11')
INSERT [dbo].[2hEmployee] ([EmpID], [PersonID], [TalentID], [Salary], [Password]) VALUES (2, 3, 4, 45000.0000, N'asdl;fjdf87')
INSERT [dbo].[2hEmployee] ([EmpID], [PersonID], [TalentID], [Salary], [Password]) VALUES (3, 8, 11, 65000.0000, N'sadljjf776')
INSERT [dbo].[2hEmployee] ([EmpID], [PersonID], [TalentID], [Salary], [Password]) VALUES (4, 9, 2, 30000.0000, N'87the88sn')
INSERT [dbo].[2hEmployee] ([EmpID], [PersonID], [TalentID], [Salary], [Password]) VALUES (5, 8, 1, 0.0000, NULL)
INSERT [dbo].[2hPerson] ([PersonID], [FirstName], [LastName]) VALUES (1, N'Jeremy', N'Thacker')
INSERT [dbo].[2hPerson] ([PersonID], [FirstName], [LastName]) VALUES (2, N'Mike', N'Jones')
INSERT [dbo].[2hPerson] ([PersonID], [FirstName], [LastName]) VALUES (3, N'Jim', N'Jimmy')
INSERT [dbo].[2hPerson] ([PersonID], [FirstName], [LastName]) VALUES (4, N'Sara', N'Bryan')
INSERT [dbo].[2hPerson] ([PersonID], [FirstName], [LastName]) VALUES (5, N'Emily', N'Schuster')
INSERT [dbo].[2hPerson] ([PersonID], [FirstName], [LastName]) VALUES (6, N'Moe', N'Mawnie')
INSERT [dbo].[2hPerson] ([PersonID], [FirstName], [LastName]) VALUES (7, N'D.O', N'Derant')
INSERT [dbo].[2hPerson] ([PersonID], [FirstName], [LastName]) VALUES (8, N'Happy', N'McDrinksalot')
INSERT [dbo].[2hPerson] ([PersonID], [FirstName], [LastName]) VALUES (9, N'Freddy', N'Krueger')
INSERT [dbo].[2hPerson] ([PersonID], [FirstName], [LastName]) VALUES (10, N'Marina', N'Bobbit')
INSERT [dbo].[2hPerson] ([PersonID], [FirstName], [LastName]) VALUES (11, N'Mitt', N'Romney')
INSERT [dbo].[2hPersonAddress] ([PersonAddressID], [PersonID], [Address], [City], [State], [Zip]) VALUES (1, 1, N'N1635', N'Hager City', N'WI', 54014)
INSERT [dbo].[2hPersonAddress] ([PersonAddressID], [PersonID], [Address], [City], [State], [Zip]) VALUES (2, 2, N'232 Maple Ave', N'Ellsworth', N'WI', 54014)
INSERT [dbo].[2hPersonAddress] ([PersonAddressID], [PersonID], [Address], [City], [State], [Zip]) VALUES (3, 3, N'87 asdf St', N'Inhduie', N'WI', 55066)
INSERT [dbo].[2hPersonAddress] ([PersonAddressID], [PersonID], [Address], [City], [State], [Zip]) VALUES (4, 4, N'565 Brown Ave', N'thekdi', N'CA', 88900)
INSERT [dbo].[2hPersonAddress] ([PersonAddressID], [PersonID], [Address], [City], [State], [Zip]) VALUES (5, 5, N'77 North BLvd', N'EndZone', N'HI', 99909)
INSERT [dbo].[2hPersonAddress] ([PersonAddressID], [PersonID], [Address], [City], [State], [Zip]) VALUES (6, 6, N'101 Dogwood Ln', N'Lexington', N'SC', 26016)
INSERT [dbo].[2hPersonAddress] ([PersonAddressID], [PersonID], [Address], [City], [State], [Zip]) VALUES (7, 7, N'889 Catsass Ave', N'asdnnk', N'OR', 77887)
INSERT [dbo].[2hPersonAddress] ([PersonAddressID], [PersonID], [Address], [City], [State], [Zip]) VALUES (8, 8, N'880', N'adslkf', N'FL', 24005)
INSERT [dbo].[2hPersonAddress] ([PersonAddressID], [PersonID], [Address], [City], [State], [Zip]) VALUES (9, 9, N'542 ave', N'intuge', N'NY', 19786)
INSERT [dbo].[2hPersonAddress] ([PersonAddressID], [PersonID], [Address], [City], [State], [Zip]) VALUES (10, 10, N'2312 West Northeast St', N'Confussed', N'AB', 98020)
INSERT [dbo].[2hPersonAddress] ([PersonAddressID], [PersonID], [Address], [City], [State], [Zip]) VALUES (11, 11, N'S1123', N'Okaydone', N'IA', 57892)
INSERT [dbo].[2hService] ([ServiceID], [TypeOfService], [ChargePerHour]) VALUES (1, N'Song Production', 30.0000)
INSERT [dbo].[2hService] ([ServiceID], [TypeOfService], [ChargePerHour]) VALUES (2, N'Logo Design', 20.0000)
INSERT [dbo].[2hService] ([ServiceID], [TypeOfService], [ChargePerHour]) VALUES (3, N'Brand Jingle', 30.0000)
INSERT [dbo].[2hService] ([ServiceID], [TypeOfService], [ChargePerHour]) VALUES (4, N'Application Design', 60.0000)
INSERT [dbo].[2hTalent] ([TalentID], [TalentDescription], [Specialty]) VALUES (1, N'Guitar', N'Classical')
INSERT [dbo].[2hTalent] ([TalentID], [TalentDescription], [Specialty]) VALUES (2, N'Piano', N'Classical')
INSERT [dbo].[2hTalent] ([TalentID], [TalentDescription], [Specialty]) VALUES (3, N'Vocals', N'Opera')
INSERT [dbo].[2hTalent] ([TalentID], [TalentDescription], [Specialty]) VALUES (4, N'Sound Engineer', N'ProTools')
INSERT [dbo].[2hTalent] ([TalentID], [TalentDescription], [Specialty]) VALUES (5, N'Graphic Designer', N'Illustrator')
INSERT [dbo].[2hTalent] ([TalentID], [TalentDescription], [Specialty]) VALUES (6, N'Web Developer', N'ASP.Net')
INSERT [dbo].[2hTalent] ([TalentID], [TalentDescription], [Specialty]) VALUES (7, N'Guitar', N'Electric')
INSERT [dbo].[2hTalent] ([TalentID], [TalentDescription], [Specialty]) VALUES (8, N'Piano', N'Rock n Roll')
INSERT [dbo].[2hTalent] ([TalentID], [TalentDescription], [Specialty]) VALUES (9, N'Vocals', N'Yoddling')
INSERT [dbo].[2hTalent] ([TalentID], [TalentDescription], [Specialty]) VALUES (10, N'Sound Engineer', N'Ableton')
INSERT [dbo].[2hTalent] ([TalentID], [TalentDescription], [Specialty]) VALUES (11, N'Web Developer', N'DreamweaverHTML/CSS')
INSERT [dbo].[4hServiceTransaction] ([TransID], [ClientID], [ServiceID], [EmpID], [Hours]) VALUES (1, 1, 3, 3, 6)
INSERT [dbo].[4hServiceTransaction] ([TransID], [ClientID], [ServiceID], [EmpID], [Hours]) VALUES (2, 3, 1, 2, 8)
INSERT [dbo].[4hServiceTransaction] ([TransID], [ClientID], [ServiceID], [EmpID], [Hours]) VALUES (3, 4, 2, 2, 12)
INSERT [dbo].[4hServiceTransaction] ([TransID], [ClientID], [ServiceID], [EmpID], [Hours]) VALUES (4, 5, 1, 1, 7)
INSERT [dbo].[4hServiceTransaction] ([TransID], [ClientID], [ServiceID], [EmpID], [Hours]) VALUES (5, 2, 4, 4, 4)
INSERT [dbo].[4hServiceTransaction] ([TransID], [ClientID], [ServiceID], [EmpID], [Hours]) VALUES (7, 2, 3, 4, 10)
INSERT [dbo].[4hServiceTransaction] ([TransID], [ClientID], [ServiceID], [EmpID], [Hours]) VALUES (8, 1, 4, 1, 8)
INSERT [dbo].[4hServiceTransaction] ([TransID], [ClientID], [ServiceID], [EmpID], [Hours]) VALUES (9, 5, 2, 3, 7)
INSERT [dbo].[4hServiceTransaction] ([TransID], [ClientID], [ServiceID], [EmpID], [Hours]) VALUES (10, 3, 1, 3, 4)
--USE [master]
--GO
--ALTER DATABASE [ThackTracks] SET  READ_WRITE 
--GO
