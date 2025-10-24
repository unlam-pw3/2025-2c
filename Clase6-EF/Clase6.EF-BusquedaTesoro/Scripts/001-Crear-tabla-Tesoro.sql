CREATE DATABASE [PW3-2025-2c-BusquedaTesoro]
GO

USE [PW3-2025-2c-BusquedaTesoro]
GO

/****** Object:  Table [dbo].[Tesoro]    Script Date: 10/22/2025 8:11:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tesoro](
	[IdTesoro] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[ImagenUrl] [nvarchar](1000) NOT NULL,
	[Latitud] [decimal](9, 6) NULL,
	[Longitud] [decimal](9, 6) NULL,
	[Valor] [int] NULL,
 CONSTRAINT [PK_Tesoro] PRIMARY KEY CLUSTERED 
(
	[IdTesoro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


