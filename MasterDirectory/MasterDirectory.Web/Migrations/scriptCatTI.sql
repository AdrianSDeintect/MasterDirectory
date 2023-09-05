USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatTI]    Script Date: 7/26/2023 11:14:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatTI](
	[LocalSap] [varchar](5) NOT NULL,
	[UsuarioGEO] [varchar](20) NULL,
	[Emaillocal] [varchar](50) NULL,
	[Extension] [varchar](10) NULL,
	[Telefono] [varchar](12) NULL,
	[NSE] [varchar](10) NULL,
	[Cluster] [varchar](15) NULL,
	[Brick] [varchar](15) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatTI] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatTI] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


