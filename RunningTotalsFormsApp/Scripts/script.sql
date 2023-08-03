USE [Examples]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 8/3/2023 6:09:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TransDate] [date] NULL,
	[Credit] [money] NULL,
	[Debit] [money] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Transactions] ON 

INSERT [dbo].[Transactions] ([id], [TransDate], [Credit], [Debit]) VALUES (1, CAST(N'2023-01-01' AS Date), 5000.0000, NULL)
INSERT [dbo].[Transactions] ([id], [TransDate], [Credit], [Debit]) VALUES (2, CAST(N'2023-01-07' AS Date), NULL, 2000.0000)
INSERT [dbo].[Transactions] ([id], [TransDate], [Credit], [Debit]) VALUES (3, CAST(N'2023-01-11' AS Date), 5000.0000, NULL)
INSERT [dbo].[Transactions] ([id], [TransDate], [Credit], [Debit]) VALUES (4, CAST(N'2023-02-03' AS Date), 6000.0000, NULL)
INSERT [dbo].[Transactions] ([id], [TransDate], [Credit], [Debit]) VALUES (5, CAST(N'2023-02-06' AS Date), NULL, 4000.0000)
INSERT [dbo].[Transactions] ([id], [TransDate], [Credit], [Debit]) VALUES (6, CAST(N'2023-02-11' AS Date), 3000.0000, NULL)
INSERT [dbo].[Transactions] ([id], [TransDate], [Credit], [Debit]) VALUES (7, CAST(N'2023-02-21' AS Date), NULL, 1000.0000)
INSERT [dbo].[Transactions] ([id], [TransDate], [Credit], [Debit]) VALUES (8, CAST(N'2023-02-28' AS Date), 2000.0000, NULL)
INSERT [dbo].[Transactions] ([id], [TransDate], [Credit], [Debit]) VALUES (9, CAST(N'2023-03-01' AS Date), -5000.0000, NULL)
INSERT [dbo].[Transactions] ([id], [TransDate], [Credit], [Debit]) VALUES (10, CAST(N'2023-03-02' AS Date), NULL, 100.0000)
SET IDENTITY_INSERT [dbo].[Transactions] OFF
GO
