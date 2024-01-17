USE [Cadastro]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 17/01/2024 16:31:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](400) NULL,
	[Email] [varchar](100) NULL,
	[Data] [date] NULL,
	[CEP] [varchar](50) NULL,
	[Rua] [varchar](400) NULL,
	[Bairro] [varchar](400) NULL,
	[Cidade] [varchar](100) NULL,
	[UF] [varchar](10) NULL,
	[IBGE] [varchar](100) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
