USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatMarketIntelligence]    Script Date: 7/26/2023 11:14:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatMarketIntelligence](
	[LocalSap] [varchar](5) NOT NULL,
	[NSE] [varchar](30) NULL,
	[Cluster] [varchar](30) NULL,
	[Brick] [varchar](20) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatMarketIntelligence] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatMarketIntelligence] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


