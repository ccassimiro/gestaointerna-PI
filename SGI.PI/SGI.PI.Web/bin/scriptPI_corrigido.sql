/****** Object:  Table [dbo].[Departamento]    Script Date: 06/05/2019 16:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[Id] [int] NOT NULL,
	[Nome] [nchar](128) NOT NULL,
	[Sigla] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Membro]    Script Date: 06/05/2019 16:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Membro](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NucleoId] [int] NOT NULL,
	[CargoId] [int] NOT NULL,
	[PessoaId] [int] NOT NULL,
 CONSTRAINT [PK_Membro] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MembroHistorico]    Script Date: 06/05/2019 16:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MembroHistorico](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NucleoId] [int] NOT NULL,
	[Cargo] [nvarchar](50) NOT NULL,
	[PessoaId] [int] NOT NULL,
	[CriadoPorId] [int] NOT NULL,
	[CriadoEm] [date] NOT NULL,
 CONSTRAINT [PK_MembroHistorico] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nucleo]    Script Date: 06/05/2019 16:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nucleo](
	[Id] [int] NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Sigla] [nchar](10) NULL,
	[DepartamentoId] [int] NOT NULL,
 CONSTRAINT [PK_Nucleo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Cargo](
	[Id] [int] NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Lideranca] [bit] NOT NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pessoa]    Script Date: 06/05/2019 16:12:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Idade] [int] NOT NULL,
	[Sexo] [nvarchar](15) NOT NULL,
	[CPF] [nvarchar](11) NOT NULL,
	[RG] [nvarchar](10) NOT NULL,
	[Endereco] [nvarchar](100) NOT NULL,
	[Bairro] [nvarchar](50) NULL,
	[Cidade] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Curso] [nvarchar](50) NOT NULL,
	[SemestreAtual] [int] NOT NULL,
	[SemestreEntrada] [int] NOT NULL,
 CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Membro]  WITH CHECK ADD  CONSTRAINT [FK_Membro_Nucleo] FOREIGN KEY([NucleoId])
REFERENCES [dbo].[Nucleo] ([Id])
GO
ALTER TABLE [dbo].[Membro]  WITH CHECK ADD  CONSTRAINT [FK_Membro_Cargo] FOREIGN KEY([CargoId])
REFERENCES [dbo].[Cargo] ([Id])
GO
ALTER TABLE [dbo].[Membro] CHECK CONSTRAINT [FK_Membro_Nucleo]
GO
ALTER TABLE [dbo].[Membro]  WITH CHECK ADD  CONSTRAINT [FK_Membro_Pessoa] FOREIGN KEY([PessoaId])
REFERENCES [dbo].[Pessoa] ([Id])
GO
ALTER TABLE [dbo].[Membro] CHECK CONSTRAINT [FK_Membro_Pessoa]
GO
ALTER TABLE [dbo].[MembroHistorico]  WITH CHECK ADD  CONSTRAINT [FK_MembroHistorico_Nucleo] FOREIGN KEY([NucleoId])
REFERENCES [dbo].[Nucleo] ([Id])
GO
ALTER TABLE [dbo].[MembroHistorico] CHECK CONSTRAINT [FK_MembroHistorico_Nucleo]
GO
ALTER TABLE [dbo].[MembroHistorico]  WITH CHECK ADD  CONSTRAINT [FK_MembroHistorico_Pessoa] FOREIGN KEY([CriadoPorId])
REFERENCES [dbo].[Pessoa] ([Id])
GO
ALTER TABLE [dbo].[MembroHistorico] CHECK CONSTRAINT [FK_MembroHistorico_Pessoa]
GO
ALTER TABLE [dbo].[Nucleo]  WITH CHECK ADD  CONSTRAINT [FK_Nucleo_Departamento] FOREIGN KEY([DepartamentoId])
REFERENCES [dbo].[Departamento] ([Id])
GO
ALTER TABLE [dbo].[Nucleo] CHECK CONSTRAINT [FK_Nucleo_Departamento]
GO

