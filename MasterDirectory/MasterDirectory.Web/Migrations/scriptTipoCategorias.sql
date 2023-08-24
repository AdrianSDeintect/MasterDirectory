USE [dbSDM]
GO

/****** Object:  Table [dbo].[Tipo_Categorias]    Script Date: 7/7/2023 11:20:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tipo_Categorias](
	[idtipoCategoria] [int] NOT NULL,	
	[tipoCategoria] [varchar](250) NOT NULL,
	[activo] [int] NOT NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_Tipo_Categorias] PRIMARY KEY CLUSTERED 
(
	[idtipoCategoria] ASC,
	[tipoCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Tipo_Categorias] ADD  DEFAULT ((1)) FOR [activo]
GO

ALTER TABLE [dbo].[Tipo_Categorias] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO

