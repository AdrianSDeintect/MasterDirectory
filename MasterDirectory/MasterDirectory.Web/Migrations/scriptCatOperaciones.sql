USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatOperaciones]    Script Date: 8/25/2023 11:51:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatOperaciones](
	[LocalSap] [varchar](5) NOT NULL,
	[Region] [varchar](5) NULL,
	[EdoLocal] [varchar](50) NULL,
	[Zona] [varchar](100) NULL,
	[Geo] [varchar](100) NULL,
	[MailGeo] [varchar](50) NULL,
	[DirectorRegional] [varchar](100) NULL,
	[HorarioLV] [varchar](50) NULL,
	[HorarioS] [varchar](50) NULL,
	[HorarioDyF] [varchar](50) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatOperaciones] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatOperaciones] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


