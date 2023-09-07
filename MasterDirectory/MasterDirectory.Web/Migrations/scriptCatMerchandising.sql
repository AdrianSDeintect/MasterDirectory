USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatMerchandising]    Script Date: 7/26/2023 11:14:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatMerchandising](
	[LocalSap] [varchar](5) NOT NULL,
	[TipoSenalizacion] [varchar](250) NULL,
	[ScreenDisplay] [varchar](250) NULL,
	[TramosLisos] [varchar](250) NULL,
	[TamanoMiniheders] [varchar](250) NULL,
	[TamanoHeader] [varchar](250) NULL,
	[Checkout] [varchar](250) NULL,
	[MedidaCabecera] [varchar](250) NULL,
	[EndCap] [varchar](250) NULL,
	[MedidaGrafico] [varchar](250) NULL,
	[BusStop] [varchar](250) NULL,
	[Aretes] [varchar](250) NULL,
	[ExhibidorRetail] [varchar](250) NULL,
	[ExhibidorGloblaBrands] [varchar](250) NULL,
	[ExhibidorWellBeginnings] [varchar](250) NULL,
	[ExhibidorInstitucional] [varchar](250) NULL,
	[ExhibidorMascarillas] [varchar](250) NULL,
	[ExhibidorGenerico] [varchar](250) NULL,
	[CabecerasInstitucionales] [varchar](250) NULL,
	[TramosFarma] [varchar](250) NULL,
	[PortaposterCanceleria] [varchar](250) NULL,
	[MedidasPecheras] [varchar](250) NULL,
	[MedidaCopete] [varchar](250) NULL,
	[MedidasCanceleria] [varchar](250) NULL,
	[M2Calc] [varchar](250) NULL,
	[RutaDLI] [varchar](50) NULL,
	[TipoSucursal] [varchar](250) NULL,
    [RampaDiscapa] [varchar](50) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatMerchandising] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatMerchandising] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


