USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatInmobiliaria]    Script Date: 8/25/2023 11:51:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatInmobiliaria](
	[LocalSap] [varchar](5) NOT NULL,
	[Farmacia] [varchar](70) NULL,
	[Colonia] [varchar](250) NULL,
	[FechaApertura] [datetime] NULL,
	[Accesos] [varchar](50) NULL,
	[Ubicacion] [varchar](50) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatInmobiliaria] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatInmobiliaria] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


