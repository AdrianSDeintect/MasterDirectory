USE [dbSDM]
GO

/****** Object:  Table [dbo].[Catalogos_Merchandising]    Script Date: 7/10/2023 12:14:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Catalogos_Merchandising](
	[idCons] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[idtipoCatalogo] [int] NOT NULL,
	[idClave] [int] NOT NULL,
	[descripcion] [varchar](250) NULL,
	[activo] [int] NOT NULL,
	[dtRegistro] [datetime] NOT NULL,
)
GO
ALTER TABLE [dbo].[Catalogos_Merchandising] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[Catalogos_Merchandising] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


