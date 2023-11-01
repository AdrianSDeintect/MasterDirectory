USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatUltimaMilla]    Script Date: 9/21/2023 1:02:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatUltimaMilla](
	[LocalSap] [varchar](5) NOT NULL,
	[Estado] [varchar](50) NULL,
	[Prov99Min] [varchar](10) NULL,
	[ProvMU] [varchar](10) NULL,
	[ProvCID] [varchar](10) NULL,
	[ProvRappiCargo] [varchar](10) NULL,
	[VentaTelf99Min] [varchar](10) NULL,
	[VentaTelfMU] [varchar](10) NULL,
	[VentaTelfCID] [varchar](10) NULL,
	[VentaTelfRappiCargo] [varchar](10) NULL,
	[Garantizado99Min] [varchar](10) NULL,
	[GarantizadoMU] [varchar](10) NULL,
	[GarantizadoCID] [varchar](10) NULL,
	[eCommerceDelivery] [varchar](10) NULL,
	[eCommerceClickCollect] [varchar](10) NULL,
	[eCommerceTipo] [varchar](50) NULL,
	[Fijo99Min] [varchar](10) NULL,
	[FijoMU] [varchar](10) NULL,
	[FijoCID] [varchar](10) NULL,
	[OnDemandMU] [varchar](10) NULL,
	[OnDemandRappiCargo] [varchar](10) NULL,
	[CanalesDigitalesRappi] [varchar](10) NULL,
	[CanalesDigitalesUber] [varchar](10) NULL,
	[ServicioEfectivo1] [varchar](10) NULL,
	[ServicioEfectivo2] [varchar](10) NULL,
	[ServicioEfectivo3] [varchar](10) NULL,
	[ServicioEfectivo4] [varchar](10) NULL,
	[ServicioEfectivo5] [varchar](10) NULL,
	[ServicioEfectivo6] [varchar](10) NULL,
	[ServicioEfectivo7] [varchar](10) NULL,
	[ServicioEfectivo8] [varchar](10) NULL,
	[ServicioTarjeta9] [varchar](10) NULL,
	[ServicioTarjeta10] [varchar](10) NULL,
	[ServicioTarjeta11] [varchar](10) NULL,
	[ServicioTarjeta12] [varchar](10) NULL,
	[InicioServicio] [varchar](25) NULL,
	[CierreServicio] [varchar](25) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatUltimaMilla] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatUltimaMilla] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


