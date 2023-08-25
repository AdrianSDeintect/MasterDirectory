USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatExpansion]    Script Date: 8/22/2023 3:53:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatExpansion](
	[LocalSap] [varchar](5) NOT NULL,
	[TipoFarmacia] [varchar](50) NULL,
	[LocationType] [varchar](50) NULL,
	[Reapertura] [varchar](25) NULL,
	[Comsuc] [varchar](50) NULL,
	[TipoEstaciona] [varchar](100) NULL,
	[NCajonesEstaciona] [varchar](10) NULL,
	[Ciudad] [varchar](80) NULL,
	[Estado] [varchar](60) NULL,
	[Direccion] [varchar](250) NULL,
	[NExterior] [varchar](25) NULL,
	[Colonia] [varchar](250) NULL,
	[CP] [varchar](10) NULL,
	[Latitud] [varchar](50) NULL,
	[Longuitud] [varchar](50) NULL,
	[FormatoFarmAlcance] [varchar](50) NULL,
	[Pantallas] [varchar](10) NULL,
	[ProvMobiliario] [varchar](50) NULL,
	[ColorMob] [varchar](60) NULL,
	[Dermo] [varchar](25) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatExpansion] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatExpansion] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


