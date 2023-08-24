USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatFinanzas]   Script Date: 8/7/2023 9:28:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatFinanzas](
	[LocalSap] [varchar](5) NOT NULL,
	[Mercado] [varchar](250) NULL,
	[FechaCierre] [datetime] NULL,
	[EstatusFarmacia] [varchar](250) NULL,
	[Top360] [varchar](250) NULL,
	[MarketCluster] [varchar](250) NULL,
	[TopMkt] [varchar](250) NULL,
	[MarketDaily] [varchar](250) NULL,
	[DailyMarketOrder] [varchar](250) NULL,
	[RegionCluster] [varchar](250) NULL,
	[Top550] [varchar](250) NULL,
	[KeyState] [varchar](250) NULL,
	[CECOFarmacias] [varchar](250) NULL,
	[CECOConsultorio] [varchar](250) NULL,
	[CECOEcommerce] [varchar](250) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatFinanzas] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatFinanzas] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


