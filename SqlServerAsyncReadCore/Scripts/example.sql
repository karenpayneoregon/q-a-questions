USE [master]
GO
/****** Object:  Database [Examples]    Script Date: 7/28/2022 3:11:47 AM ******/
CREATE DATABASE [Examples]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Examples', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Examples.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Examples_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Examples_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Examples] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Examples].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Examples] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Examples] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Examples] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Examples] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Examples] SET ARITHABORT OFF 
GO
ALTER DATABASE [Examples] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Examples] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Examples] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Examples] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Examples] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Examples] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Examples] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Examples] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Examples] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Examples] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Examples] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Examples] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Examples] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Examples] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Examples] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Examples] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Examples] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Examples] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Examples] SET  MULTI_USER 
GO
ALTER DATABASE [Examples] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Examples] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Examples] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Examples] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Examples] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Examples] SET QUERY_STORE = OFF
GO
USE [Examples]
GO
/****** Object:  Table [dbo].[Table1]    Script Date: 7/28/2022 3:11:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SomeDateTime] [datetime2](7) NULL,
 CONSTRAINT [PK_Table1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Table1] ON 

INSERT [dbo].[Table1] ([Id], [SomeDateTime]) VALUES (1, CAST(N'2022-07-04T01:30:00.0000000' AS DateTime2))
INSERT [dbo].[Table1] ([Id], [SomeDateTime]) VALUES (2, CAST(N'2022-07-04T14:45:00.0000000' AS DateTime2))
INSERT [dbo].[Table1] ([Id], [SomeDateTime]) VALUES (3, CAST(N'2021-07-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Table1] ([Id], [SomeDateTime]) VALUES (4, CAST(N'2021-07-01T14:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Table1] OFF
USE [master]
GO
ALTER DATABASE [Examples] SET  READ_WRITE 
GO
