INSERT INTO dbo.Users (Username,Password) VALUES ('payneoregon',PWDENCRYPT('!FirstOnMonday'))
INSERT INTO dbo.Users (Username,Password) VALUES ('jimbeam',PWDENCRYPT('@MySilly1Password'))
INSERT INTO dbo.Users (Username,Password) VALUES('smithone',PWDENCRYPT('P@ss123'))

INSERT INTO Users1 (UserName, [Password]) VALUES ('payneoregon', HASHBYTES('SHA2_512', '!FirstOnMonday'));
INSERT INTO Users1 (UserName, [Password]) VALUES ('jimbeam', HASHBYTES('SHA2_512', '@MySilly1Password'));
