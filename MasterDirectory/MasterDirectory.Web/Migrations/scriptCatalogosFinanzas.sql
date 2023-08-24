USE [dbSDM]
GO

/****** Object:  Table [dbo].[Catalogos_Merchandising]    Script Date: 8/8/2023 12:52:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Catalogos_Finanzas](
	[idCons] [int] IDENTITY(1,1) NOT NULL,
	[idtipoCatalogo] [int] NOT NULL,
	[idClave] [int] NOT NULL,
	[descripcion] [varchar](250) NULL,
	[activo] [int] NOT NULL,
	[dtRegistro] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCons] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Catalogos_Finanzas] ADD  DEFAULT ((1)) FOR [activo]
GO

ALTER TABLE [dbo].[Catalogos_Finanzas] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


