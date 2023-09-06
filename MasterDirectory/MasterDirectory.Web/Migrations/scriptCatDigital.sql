USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatDigital]    Script Date: 7/26/2023 11:14:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatDigital](
	[LocalSap] [varchar](5) NOT NULL,
	[DirGoogle] [varchar](250) NULL,
	[Latitud] [varchar](50) NULL,
	[Longitud] [varchar](50) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatDigital] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatDigital] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


