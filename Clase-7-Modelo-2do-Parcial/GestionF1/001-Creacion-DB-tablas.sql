USE [master]
GO
/****** Object:  Database [GestionF1]    Script Date: 10/29/2025 7:47:41 PM ******/
CREATE DATABASE [GestionF1]
 GO
 USE [GestionF1]
GO
/****** Object:  Table [dbo].[Escuderia]    Script Date: 10/29/2025 7:47:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Escuderia](
	[IdEscuderia] [int] IDENTITY(1,1) NOT NULL,
	[NombreEscuderia] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Escuderia] PRIMARY KEY CLUSTERED 
(
	[IdEscuderia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Piloto]    Script Date: 10/29/2025 7:47:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Piloto](
	[IdPiloto] [int] IDENTITY(1,1) NOT NULL,
	[NombrePiloto] [nvarchar](100) NOT NULL,
	[IdEscuderia] [int] NOT NULL,
	[Eliminado] [bit] NOT NULL,
 CONSTRAINT [PK_Piloto] PRIMARY KEY CLUSTERED 
(
	[IdPiloto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Piloto] ADD  CONSTRAINT [DF_Piloto_Eliminado]  DEFAULT ((0)) FOR [Eliminado]
GO
ALTER TABLE [dbo].[Escuderia]  WITH CHECK ADD  CONSTRAINT [FK_Escuderia_Escuderia] FOREIGN KEY([IdEscuderia])
REFERENCES [dbo].[Escuderia] ([IdEscuderia])
GO
ALTER TABLE [dbo].[Escuderia] CHECK CONSTRAINT [FK_Escuderia_Escuderia]
GO
ALTER TABLE [dbo].[Piloto]  WITH CHECK ADD  CONSTRAINT [FK_Piloto_Escuderia] FOREIGN KEY([IdEscuderia])
REFERENCES [dbo].[Escuderia] ([IdEscuderia])
GO
ALTER TABLE [dbo].[Piloto] CHECK CONSTRAINT [FK_Piloto_Escuderia]
GO
USE [master]
GO
ALTER DATABASE [GestionF1] SET  READ_WRITE 
GO
