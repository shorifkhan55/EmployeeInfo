USE [master]
GO
/****** Object:  Database [UniversityManagementDB]    Script Date: 05/10/2015 13:17:33 ******/
CREATE DATABASE [UniversityManagementDB] ON  PRIMARY 
( NAME = N'UniversityManagementDB', FILENAME = N'F:\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\UniversityManagementDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UniversityManagementDB_log', FILENAME = N'F:\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\UniversityManagementDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UniversityManagementDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UniversityManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UniversityManagementDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [UniversityManagementDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [UniversityManagementDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [UniversityManagementDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [UniversityManagementDB] SET ARITHABORT OFF
GO
ALTER DATABASE [UniversityManagementDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [UniversityManagementDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [UniversityManagementDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [UniversityManagementDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [UniversityManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [UniversityManagementDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [UniversityManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [UniversityManagementDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [UniversityManagementDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [UniversityManagementDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [UniversityManagementDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [UniversityManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [UniversityManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [UniversityManagementDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [UniversityManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [UniversityManagementDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [UniversityManagementDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [UniversityManagementDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [UniversityManagementDB] SET  READ_WRITE
GO
ALTER DATABASE [UniversityManagementDB] SET RECOVERY FULL
GO
ALTER DATABASE [UniversityManagementDB] SET  MULTI_USER
GO
ALTER DATABASE [UniversityManagementDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [UniversityManagementDB] SET DB_CHAINING OFF
GO
USE [UniversityManagementDB]
GO
/****** Object:  User [USER\shira_000]    Script Date: 05/10/2015 13:17:33 ******/
CREATE USER [USER\shira_000] FOR LOGIN [USER\shira_000] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 05/10/2015 13:17:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Departments] ON
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (1, N'CSE')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (2, N'EEE')
INSERT [dbo].[Departments] ([Id], [Name]) VALUES (3, N'BBA')
SET IDENTITY_INSERT [dbo].[Departments] OFF
/****** Object:  Table [dbo].[Students]    Script Date: 05/10/2015 13:17:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[RegNo] [varchar](50) NOT NULL,
	[Address] [varchar](300) NULL,
	[DepartmentId] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (1, N'ABC', N'001', N'Dhaka', NULL)
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (2, N'CDE', N'002', N'Rajshahi', NULL)
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (3, N'EFG', N'003', N'Sylhet', NULL)
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (4, N'GHI', N'005', N'Jessore', NULL)
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (5, N'Karim', N'006', N'Dhaka', NULL)
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (7, N'James Bond', N'007', N'New York', NULL)
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (9, N'Shoeb', N'008', N'Dhaka', NULL)
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (10, N'Name', N'010', N'Dhaka', NULL)
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (11, N'New ', N'011', N'Sylhet', NULL)
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (12, N'New New ', N'0012', N'Dhaka', NULL)
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (13, N'Dept EEE', N'0013', N'Dhk', 2)
INSERT [dbo].[Students] ([ID], [Name], [RegNo], [Address], [DepartmentId]) VALUES (14, N'Debashish', N'0024', N'Dhk', 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
/****** Object:  View [dbo].[StudentDepartment]    Script Date: 05/10/2015 13:17:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[StudentDepartment]
AS
SELECT s.ID, s.Name,s.RegNo,s.Address,s.DepartmentId,d.Name as DepartmentName FROM Students as s  LEFT OUTER JOIN Departments as d

ON s.DepartmentId = d.Id
GO
/****** Object:  ForeignKey [FK_Students_Departments]    Script Date: 05/10/2015 13:17:33 ******/
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Departments]
GO
