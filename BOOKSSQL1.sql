USE [master]
GO
/****** Object:  Database [SQL1]    Script Date: 11/24/2021 11:19:56 AM ******/
CREATE DATABASE [SQL1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SQL1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SQL1.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SQL1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SQL1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SQL1] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SQL1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SQL1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SQL1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SQL1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SQL1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SQL1] SET ARITHABORT OFF 
GO
ALTER DATABASE [SQL1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SQL1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SQL1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SQL1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SQL1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SQL1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SQL1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SQL1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SQL1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SQL1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SQL1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SQL1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SQL1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SQL1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SQL1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SQL1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SQL1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SQL1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SQL1] SET  MULTI_USER 
GO
ALTER DATABASE [SQL1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SQL1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SQL1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SQL1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SQL1] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SQL1]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 11/24/2021 11:19:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Author] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 11/24/2021 11:19:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phones]    Script Date: 11/24/2021 11:19:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContactId] [int] NOT NULL,
	[Number] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Prices]    Script Date: 11/24/2021 11:19:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BookId] [int] NOT NULL,
	[BookPrice] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/24/2021 11:19:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [SQL1] SET  READ_WRITE 
GO
