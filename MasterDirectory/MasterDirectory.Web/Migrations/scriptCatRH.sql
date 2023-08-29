USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatRH]    Script Date: 8/25/2023 11:51:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatRH](
	[LocalSap] [varchar](5) NOT NULL,
	[Plantilla] [varchar](10) NULL,
	[Vacantes] [varchar](10) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatRH] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatRH] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO