USE [master]
GO
/****** Object:  Database [Demo]    Script Date: 10/14/2023 1:08:40 PM ******/
CREATE DATABASE [Demo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Demo', FILENAME = N'C:\Users\paynek\Demo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Demo_log', FILENAME = N'C:\Users\paynek\Demo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Demo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Demo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Demo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Demo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Demo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Demo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Demo] SET ARITHABORT OFF 
GO
ALTER DATABASE [Demo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Demo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Demo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Demo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Demo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Demo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Demo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Demo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Demo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Demo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Demo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Demo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Demo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Demo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Demo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Demo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Demo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Demo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Demo] SET  MULTI_USER 
GO
ALTER DATABASE [Demo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Demo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Demo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Demo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Demo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Demo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Demo] SET QUERY_STORE = OFF
GO
USE [Demo]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/14/2023 1:08:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NULL,
	[CurrentQuantity] [decimal](10, 2) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (1, N'Coffee Maker', CAST(12.50 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (2, N'Toaster', CAST(11.33 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (3, N'Microwave Oven', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (4, N'Blender', CAST(2.45 AS Decimal(10, 2)))
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (5, N'Vacuum Cleaner', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (6, N'Dishwasher', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (7, N'Air Conditioner', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (8, N'Fan', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (9, N'Iron', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (10, N'Hair Dryer', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (11, N'Electric Kettle', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (12, N'Food Processor', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (13, N'Oven', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (14, N'Electric Grill', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (15, N'Hand Mixer', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (16, N'Rice Cooker', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (17, N'Pressure Cooker', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (18, N'Slow Cooker', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (19, N'Stand Mixer', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (20, N'Juicer', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (21, N'Digital Camera', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (22, N'Luggage Set', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (23, N'Backpack', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (24, N'Wristwatch', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (25, N'Sneakers', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (26, N'Running Shoes', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (27, N'Hiking Boots', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (28, N'Bicycle', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (29, N'Smartwatch', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (30, N'Fitness Tracker', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (31, N'Desktop Computer', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (32, N'Printer', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (33, N'Gaming Console', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (34, N'External Hard Drive', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (35, N'Monitor', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (36, N'Bluetooth Speaker', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (37, N'Wireless Headphones', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (38, N'Home Theater System', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (39, N'Bookshelf Speakers', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (40, N'Guitar', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (41, N'Keyboard', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (42, N'Drum Kit', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (43, N'Television Stand', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (44, N'Coffee Table', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (45, N'Sofa', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (46, N'Dining Table', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (47, N'Recliner Chair', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (48, N'Office Chair', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (49, N'Bed Frame', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (50, N'Mattress', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (51, N'Nightstand', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (52, N'Wardrobe', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (53, N'Curtains', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (54, N'Throw Pillow', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (55, N'Dining Set', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (56, N'Cutlery Set', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (57, N'Cookware Set', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (58, N'Glassware Set', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (59, N'Towel Set', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (60, N'Bedding Set', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (61, N'Area Rug', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (62, N'Wall Clock', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (63, N'Table Lamp', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (64, N'Floor Lamp', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (65, N'Wall Art', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (66, N'Plant Pot', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (67, N'Fire Pit', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (68, N'Patio Furniture Set', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (69, N'Barbecue Grill', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (70, N'Bicycle Helmet', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (71, N'Sunglasses', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (72, N'Backpack', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (73, N'Tent', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (74, N'Sleeping Bag', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (75, N'Camping Stove', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (76, N'Fishing Rod', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (77, N'Kayak', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (78, N'Snowboard', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (79, N'Skis', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (80, N'Snow Boots', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (81, N'Winter Jacket', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (82, N'Golf Clubs', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (83, N'Tennis Racket', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (84, N'Basketball', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (85, N'Soccer Ball', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (86, N'Baseball Glove', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (87, N'Fishing Tackle Box', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (88, N'Hiking Backpack', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (89, N'Camping Lantern', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (90, N'Swimming Goggles', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (91, N'Yoga Mat', NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [CurrentQuantity]) VALUES (92, N'Exercise Ball', NULL)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
USE [master]
GO
ALTER DATABASE [Demo] SET  READ_WRITE 
GO
