USE [dbSDM]
GO

/****** Object:  Table [dbo].[Tipo_Catalogos]    Script Date: 7/10/2023 12:10:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tipo_Catalogos](
	[idCons] [int] NOT NULL IDENTITY(1,1) PRIMARY KEY,
    [idtipoCategoria] [int] NOT NULL,
    [idtipoCatalogo] [int] NOT NULL,
	[tipoCatalogo] [varchar](250) NOT NULL,
	[activo] [int] NOT NULL,
	[dtRegistro] [datetime] NOT NULL);

ALTER TABLE [dbo].[Tipo_Catalogos] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[Tipo_Catalogos] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


