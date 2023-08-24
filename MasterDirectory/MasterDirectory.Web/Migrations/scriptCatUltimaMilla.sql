USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatUltimaMilla]    Script Date: 8/10/2023 10:06:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatUltimaMilla](
	[LocalSap] [varchar](5) NOT NULL,
	[VentaTelefonica] [varchar](10) NULL,
	[Garantizado] [varchar](10) NULL,
	[HUB] [varchar](50) NULL,
	[ECommerce] [varchar](50) NULL,
	[TipoEComm] [varchar](50) NULL,
	[RAPPI] [varchar](50) NULL,
	[TABLET] [varchar](50) NULL,
	[NSerie] [varchar](50) NULL,
	[EstatusTablet] [varchar](50) NULL,
	[QR] [varchar](50) NULL,
	[ServicioDomicilio] [varchar](50) NULL,
	[PruebaUBER] [varchar](50) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatUltimaMilla] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatUltimaMilla] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


