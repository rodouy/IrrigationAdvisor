USE [IrrigationAdvisor]
GO

/****** Object:  Table [dbo].[Position]    Script Date: 06/20/2015 22:11:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Position]') AND type in (N'U'))
DROP TABLE [dbo].[Position]
GO

USE [IrrigationAdvisor]
GO

/****** Object:  Table [dbo].[Position]    Script Date: 06/20/2015 22:11:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Position]
(
	[PositionId]		[bigint]				NOT NULL,
	[Latitude]			[decimal](12, 8)		NOT NULL,
	[Longitude]			[decimal](12, 8)		NOT NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[PositionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


