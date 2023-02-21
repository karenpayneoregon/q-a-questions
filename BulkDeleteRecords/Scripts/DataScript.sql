USE [ForumExample]
GO
/****** Object:  Table [dbo].[Demo1]    Script Date: 2/21/2023 3:01:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Demo1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Serial] [nvarchar](max) NULL,
	[SomeDate] [date] NULL,
 CONSTRAINT [PK_Demo1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Demo1] ON 

INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (1, N'18910', CAST(N'1978-07-09' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (2, N'96252', CAST(N'1985-07-14' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (3, N'11222', CAST(N'1992-02-08' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (4, N'16584', CAST(N'1967-03-26' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (5, N'91504', CAST(N'1997-06-18' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (6, N'72419', CAST(N'2014-07-09' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (7, N'44254', CAST(N'2002-03-08' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (8, N'02299', CAST(N'1981-11-21' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (9, N'11854', CAST(N'2006-02-14' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (10, N'23422', CAST(N'1996-01-11' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (11, N'68128', CAST(N'1973-07-26' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (12, N'30187', CAST(N'2021-09-28' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (13, N'35227', CAST(N'1984-06-26' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (14, N'50299', CAST(N'1998-11-29' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (15, N'11768', CAST(N'2012-09-12' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (16, N'92249', CAST(N'2013-11-29' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (17, N'17325', CAST(N'1996-04-23' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (18, N'42401', CAST(N'2015-08-21' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (19, N'50527', CAST(N'1997-12-31' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (20, N'57891', CAST(N'1991-12-22' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (21, N'27159', CAST(N'2003-10-24' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (22, N'59660', CAST(N'2008-12-24' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (23, N'83434', CAST(N'1953-03-01' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (24, N'80080', CAST(N'2005-09-01' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (25, N'06418', CAST(N'2010-06-06' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (26, N'72679', CAST(N'1996-03-14' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (27, N'78285', CAST(N'1956-03-07' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (28, N'29054', CAST(N'1966-03-04' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (29, N'62310', CAST(N'1978-01-03' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (30, N'63635', CAST(N'1971-02-05' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (31, N'03059', CAST(N'1976-09-15' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (32, N'30365', CAST(N'2021-08-17' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (33, N'49476', CAST(N'1996-03-06' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (34, N'74204', CAST(N'1982-12-17' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (35, N'76251', CAST(N'1986-09-30' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (36, N'14308', CAST(N'1953-08-17' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (37, N'16022', CAST(N'1967-09-30' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (38, N'00786', CAST(N'1963-02-14' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (39, N'68755', CAST(N'1999-01-13' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (40, N'09947', CAST(N'2010-01-22' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (41, N'58974', CAST(N'1978-05-15' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (42, N'14136', CAST(N'1999-11-16' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (43, N'05280', CAST(N'2016-09-25' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (44, N'89918', CAST(N'1965-05-11' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (45, N'85829', CAST(N'2004-08-02' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (46, N'26876', CAST(N'1958-10-26' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (47, N'43556', CAST(N'1971-09-06' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (48, N'93275', CAST(N'2018-06-30' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (49, N'82956', CAST(N'2005-09-23' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (50, N'34969', CAST(N'1969-08-30' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (51, N'29420', CAST(N'1972-10-16' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (52, N'03983', CAST(N'1974-05-24' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (53, N'82361', CAST(N'1971-08-23' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (54, N'00083', CAST(N'1999-08-08' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (55, N'87003', CAST(N'2020-10-11' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (56, N'37363', CAST(N'1991-07-17' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (57, N'76226', CAST(N'1985-05-15' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (58, N'10826', CAST(N'2008-06-08' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (59, N'46246', CAST(N'1978-10-20' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (60, N'84574', CAST(N'1954-04-07' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (61, N'90974', CAST(N'2011-05-04' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (62, N'32968', CAST(N'1989-01-04' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (63, N'27387', CAST(N'1956-11-18' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (64, N'85176', CAST(N'1988-01-11' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (65, N'99157', CAST(N'1972-04-27' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (66, N'10293', CAST(N'1973-12-09' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (67, N'13539', CAST(N'1978-07-25' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (68, N'37771', CAST(N'1954-07-11' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (69, N'40718', CAST(N'1965-03-02' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (70, N'11437', CAST(N'2012-01-28' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (71, N'47505', CAST(N'1999-03-03' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (72, N'22366', CAST(N'1986-03-10' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (73, N'75673', CAST(N'1969-08-09' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (74, N'81710', CAST(N'2009-12-10' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (75, N'19148', CAST(N'1966-08-09' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (76, N'28608', CAST(N'1956-12-09' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (77, N'82295', CAST(N'2014-03-31' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (78, N'58343', CAST(N'2009-10-21' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (79, N'14854', CAST(N'1954-01-31' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (80, N'72789', CAST(N'2004-08-12' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (81, N'67424', CAST(N'1977-07-09' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (82, N'67649', CAST(N'1959-09-09' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (83, N'59686', CAST(N'1982-06-12' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (84, N'37682', CAST(N'1961-05-07' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (85, N'36402', CAST(N'2020-04-22' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (86, N'40363', CAST(N'1955-04-25' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (87, N'53357', CAST(N'2002-12-27' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (88, N'77470', CAST(N'2018-07-31' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (89, N'99644', CAST(N'1984-03-07' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (90, N'98498', CAST(N'2017-03-17' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (91, N'36409', CAST(N'1990-04-04' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (92, N'79593', CAST(N'1981-04-23' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (93, N'87990', CAST(N'2006-04-28' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (94, N'96680', CAST(N'1997-10-09' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (95, N'89507', CAST(N'2020-09-20' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (96, N'25561', CAST(N'2011-05-11' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (97, N'16759', CAST(N'1995-12-30' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (98, N'90636', CAST(N'1981-09-15' AS Date))
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (99, N'29790', CAST(N'2015-01-14' AS Date))
GO
INSERT [dbo].[Demo1] ([Id], [Serial], [SomeDate]) VALUES (100, N'05612', CAST(N'1983-08-26' AS Date))
SET IDENTITY_INSERT [dbo].[Demo1] OFF
GO
