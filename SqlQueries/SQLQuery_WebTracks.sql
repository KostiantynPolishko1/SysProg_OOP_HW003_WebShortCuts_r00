USE [db_aa534b_polxswp31];

IF OBJECT_ID(N'dbo.webtracks', N'U') IS NULL
	BEGIN
		CREATE TABLE [dbo].[webtracks]
		(
		[id] INT IDENTITY(1, 1),
		[date] DATE NULL CONSTRAINT DF_webtracks_date DEFAULT (TRY_CONVERT(DATE, CURRENT_TIMESTAMP)),
		[time] TIME NULL CONSTRAINT DF_webtracks_time DEFAULT (TRY_CONVERT(TIME, CURRENT_TIMESTAMP, 8)),
		[url] NVARCHAR(2083) NOT NULL,
		[name] VARCHAR(128) NOT NULL,
		[owner] VARCHAR(128) NOT NULL CONSTRAINT DF_webtracks_owner DEFAULT (SYSTEM_USER),

		CONSTRAINT PK_webtracks_id PRIMARY KEY ([id]),
		CONSTRAINT CK_webtracks_url CHECK ([url] != ''),
		CONSTRAINT CK_webtracks_name CHECK ([name] != ''),
		CONSTRAINT CK_webtracks_owner CHECK ([owner] != '')
		)
	END;

IF OBJECT_ID(N'dbo.webtracks', N'U') IS NOT NULL
	BEGIN
		INSERT INTO [dbo].[webtracks] ([url], [name])
		VALUES
		('https://www.w3schools.com', 'W3Schools')
	END;

IF OBJECT_ID(N'dbo.webshortcuts', N'U') IS NULL
	BEGIN
		CREATE TABLE [dbo].[webshortcuts]
		(
		[id] INT IDENTITY(1, 1),
		[href] NVARCHAR(2083) NOT NULL DEFAULT('https://www.google.com/'),
		[name] VARCHAR(128) NOT NULL DEFAULT('Google'),

		CONSTRAINT PK_webshortcuts_id PRIMARY KEY ([id]),
		CONSTRAINT CK_webshortcuts_href CHECK ([href] != ''),
		CONSTRAINT UC_webshortcuts_href UNIQUE ([href]),
		CONSTRAINT CK_webshortcuts_name CHECK ([name] != ''),
		CONSTRAINT UC_webshortcuts_name UNIQUE([name]),
		)
	END;

IF OBJECT_ID(N'dbo.webtracks', N'U') IS NOT NULL
	BEGIN
		INSERT INTO [dbo].[webshortcuts]([href], [name])
		VALUES
		('https://www.w3schools.com', 'W3Schools'),
		('https://mystat.itstep.org', 'MyStat'),
		('https://itstep.org/ru', 'ITSTEP')
	END;

SELECT * FROM [dbo].[webtracks];
SELECT * FROM [dbo].[webshortcuts];

--TRUNCATE TABLE [dbo].[webtracks];
--TRUNCATE TABLE [dbo].[webshortcuts];

--DROP TABLE [dbo].[webtracks];
--DROP TABLE [dbo].[webshortcuts];