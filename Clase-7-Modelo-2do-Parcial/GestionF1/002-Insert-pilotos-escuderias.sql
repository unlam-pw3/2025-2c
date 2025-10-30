USE [GestionF1]
GO
SET IDENTITY_INSERT [dbo].[Escuderia] ON 
GO
INSERT [dbo].[Escuderia] ([IdEscuderia], [NombreEscuderia]) VALUES (1, N'Ferrari')
GO
INSERT [dbo].[Escuderia] ([IdEscuderia], [NombreEscuderia]) VALUES (2, N'McLaren')
GO
INSERT [dbo].[Escuderia] ([IdEscuderia], [NombreEscuderia]) VALUES (3, N'Red Bull')
GO
INSERT [dbo].[Escuderia] ([IdEscuderia], [NombreEscuderia]) VALUES (4, N'Mercedez')
GO
INSERT [dbo].[Escuderia] ([IdEscuderia], [NombreEscuderia]) VALUES (5, N'Williams')
GO
INSERT [dbo].[Escuderia] ([IdEscuderia], [NombreEscuderia]) VALUES (6, N'Aston Martin')
GO
INSERT [dbo].[Escuderia] ([IdEscuderia], [NombreEscuderia]) VALUES (7, N'Racing Bulls')
GO
INSERT [dbo].[Escuderia] ([IdEscuderia], [NombreEscuderia]) VALUES (8, N'Haas')
GO
INSERT [dbo].[Escuderia] ([IdEscuderia], [NombreEscuderia]) VALUES (9, N'Kick Sauber')
GO
INSERT [dbo].[Escuderia] ([IdEscuderia], [NombreEscuderia]) VALUES (10, N'Alpine')
GO
INSERT [dbo].[Escuderia] ([IdEscuderia], [NombreEscuderia]) VALUES (11, N'Cadillac')
GO
SET IDENTITY_INSERT [dbo].[Escuderia] OFF
GO
SET IDENTITY_INSERT [dbo].[Piloto] ON 
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (1, N'Lewis Hamilton', 1, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (2, N'Max Verstappen', 3, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (3, N'Fernando Alonso', 6, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (4, N'Lando Norris', 2, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (5, N'Oscar Piastri', 2, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (6, N'Russell', 4, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (7, N'Charles Leclerc', 1, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (8, N'Stroll', 6, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (9, N'Antonelli', 4, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (10, N'Tsunoda', 3, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (11, N'Albon', 5, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (12, N'Sainz', 5, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (13, N'Bortoletto', 9, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (14, N'Hulkenberg', 9, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (15, N'Bearman', 8, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (16, N'Ocon', 8, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (17, N'Lawson', 7, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (18, N'Hadjar', 7, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (19, N'Gasly', 10, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (20, N'Colapinto', 10, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (21, N'Checo Perez', 11, 0)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (22, N'Bottas', 11, 1)
GO
INSERT [dbo].[Piloto] ([IdPiloto], [NombrePiloto], [IdEscuderia], [Eliminado]) VALUES (23, N'Ricciardo', 7, 1)
GO
SET IDENTITY_INSERT [dbo].[Piloto] OFF
GO
