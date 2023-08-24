USE [dbSDM]
GO

/****** Object:  Table [dbo].[CatConsultorios]    Script Date: 8/15/2023 9:24:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CatConsultorios](
	[LocalSap] [varchar](5) NOT NULL,
	[ConsulOperacion] [varchar](15) NULL,
	[Benamedic] [varchar](10) NULL,
	[HorarioLV] [varchar](50) NULL,
	[HorarioS] [varchar](50) NULL,
	[HorarioD] [varchar](50) NULL,
	[RampaDiscapa] [varchar](50) NULL,
	[dtRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_CatConsultorios] PRIMARY KEY CLUSTERED 
(
	[LocalSap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CatConsultorios] ADD  DEFAULT (getdate()) FOR [dtRegistro]
GO


