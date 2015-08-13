USE [IrrigationAdvisor]
GO

/****** Object:  Table [dbo].[City]    Script Date: 06/20/2015 22:11:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[City]') AND type in (N'U'))
DROP TABLE [dbo].[City]
GO

USE [IrrigationAdvisor]
GO

/****** Object:  Table [dbo].[City]    Script Date: 06/20/2015 22:11:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[City]
(
	[CityId]			[bigint]				NOT NULL,
	[PositionId]		[bigint]				NOT NULL,
	[Name]				[varchar](50)			NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


