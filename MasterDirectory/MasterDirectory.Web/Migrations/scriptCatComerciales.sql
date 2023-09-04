USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatComerciales]    Script Date: 7/26/2023 11:14:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatComerciales](
	[LocalSap] [varchar](5) NOT NULL,
	[M2PDV] [varchar](20) NULL,
	[M2Local] [varchar](20) NULL,
	[TotEspacioExhibFarm] [varchar](15) NULL,
	[TirasImpulso] [varchar](15) NULL,
	[Islas] [varchar](15) NULL,
	[ExhibMostrador] [varchar](15) NULL,
	[HP1] [varchar](15) NULL,
	[HP2] [varchar](15) NULL,
	[HP3] [varchar](15) NULL,
    [MedidaCabecera] [varchar](50) NULL,
    [Cajonera] [varchar](15) NULL,
    [TramosCajonera] [varchar](15) NULL,
    [MuebleGenericos] [varchar](15) NULL,
	[RefriMostradorFarma] [varchar](50) NULL,
	[Refri4puertas] [varchar](50) NULL,
    [Tabaquera] [varchar](15) NULL,
    [TabletasFujiFilm] [varchar](15) NULL,
    [Kioscos] [varchar](15) NULL,
    [No7] [varchar](25) NULL,
    [SoapYGlory] [varchar](70) NULL,
	[TramosDermo] [varchar](50) NULL,
	[TempoFarma] [varchar](100) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatComerciales] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatComerciales] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


