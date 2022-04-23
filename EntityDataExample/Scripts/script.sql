USE [master]
GO
/****** Object:  Database [EntityData]    Script Date: 4/23/2022 6:14:03 AM ******/
CREATE DATABASE [EntityData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EntityData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EntityData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EntityData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\EntityData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EntityData] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EntityData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EntityData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EntityData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EntityData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EntityData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EntityData] SET ARITHABORT OFF 
GO
ALTER DATABASE [EntityData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EntityData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EntityData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EntityData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EntityData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EntityData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EntityData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EntityData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EntityData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EntityData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EntityData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EntityData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EntityData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EntityData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EntityData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EntityData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EntityData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EntityData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EntityData] SET  MULTI_USER 
GO
ALTER DATABASE [EntityData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EntityData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EntityData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EntityData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EntityData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EntityData] SET QUERY_STORE = OFF
GO
USE [EntityData]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 4/23/2022 6:14:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryIdentifier] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Occupation]    Script Date: 4/23/2022 6:14:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Occupation](
	[OccupationIdentifier] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Occupation] PRIMARY KEY CLUSTERED 
(
	[OccupationIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 4/23/2022 6:14:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[OccupationIdentifier] [int] NOT NULL,
	[CountryIdentifier] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (1, N'Argentina')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (2, N'Austria')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (3, N'Belgium')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (4, N'Brazil')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (5, N'Canada')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (6, N'Denmark')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (7, N'Finland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (8, N'France')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (9, N'Germany')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (10, N'Ireland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (11, N'Italy')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (12, N'Mexico')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (13, N'Norway')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (14, N'Poland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (15, N'Portugal')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (16, N'Spain')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (17, N'Sweden')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (18, N'Switzerland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (19, N'UK')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (20, N'USA')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (21, N'Venezuela')
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[Occupation] ON 

INSERT [dbo].[Occupation] ([OccupationIdentifier], [Description]) VALUES (1, N'Doctor')
INSERT [dbo].[Occupation] ([OccupationIdentifier], [Description]) VALUES (2, N'Actor')
INSERT [dbo].[Occupation] ([OccupationIdentifier], [Description]) VALUES (3, N'Plumber')
SET IDENTITY_INSERT [dbo].[Occupation] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [OccupationIdentifier], [CountryIdentifier]) VALUES (1, N'Mary', N'Jones', 1, 6)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [OccupationIdentifier], [CountryIdentifier]) VALUES (2, N'Frank', N'Adams', 3, 8)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [OccupationIdentifier], [CountryIdentifier]) VALUES (3, N'Jane', N'Smith', 1, 7)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [OccupationIdentifier], [CountryIdentifier]) VALUES (4, N'Hank', N'White', 2, 9)
SET IDENTITY_INSERT [dbo].[Person] OFF
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Countries] FOREIGN KEY([CountryIdentifier])
REFERENCES [dbo].[Countries] ([CountryIdentifier])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Countries]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Occupation1] FOREIGN KEY([OccupationIdentifier])
REFERENCES [dbo].[Occupation] ([OccupationIdentifier])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Occupation1]
GO
USE [master]
GO
ALTER DATABASE [EntityData] SET  READ_WRITE 
GO
