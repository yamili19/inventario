USE [master]
GO
/****** Object:  Database [ParaElInventario]    Script Date: 9/1/2023 01:33:33 ******/
CREATE DATABASE [ParaElInventario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ParaElInventario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ParaElInventario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ParaElInventario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ParaElInventario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ParaElInventario] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ParaElInventario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ParaElInventario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ParaElInventario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ParaElInventario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ParaElInventario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ParaElInventario] SET ARITHABORT OFF 
GO
ALTER DATABASE [ParaElInventario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ParaElInventario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ParaElInventario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ParaElInventario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ParaElInventario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ParaElInventario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ParaElInventario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ParaElInventario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ParaElInventario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ParaElInventario] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ParaElInventario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ParaElInventario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ParaElInventario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ParaElInventario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ParaElInventario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ParaElInventario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ParaElInventario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ParaElInventario] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ParaElInventario] SET  MULTI_USER 
GO
ALTER DATABASE [ParaElInventario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ParaElInventario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ParaElInventario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ParaElInventario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ParaElInventario] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ParaElInventario] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ParaElInventario] SET QUERY_STORE = OFF
GO
USE [ParaElInventario]
GO
/****** Object:  Table [dbo].[Consumibles]    Script Date: 9/1/2023 01:33:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consumibles](
	[nombre] [varchar](50) NULL,
	[cantidadComprada] [int] NULL,
	[cantidadDisponible] [int] NULL,
	[nro] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [pk_consumibles] PRIMARY KEY CLUSTERED 
(
	[nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ElementosDibujo]    Script Date: 9/1/2023 01:33:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ElementosDibujo](
	[nombre] [varchar](50) NOT NULL,
	[cantidadDisponible] [int] NOT NULL,
	[cantidadComprada] [int] NOT NULL,
	[estado] [bit] NOT NULL,
	[nro] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [pk_elementosDibujo] PRIMARY KEY CLUSTERED 
(
	[nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HerramientasManuales]    Script Date: 9/1/2023 01:33:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HerramientasManuales](
	[marca] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[material] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL,
	[lugar] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[nro] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [pk_herramientas] PRIMARY KEY CLUSTERED 
(
	[nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Informatica]    Script Date: 9/1/2023 01:33:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Informatica](
	[nombre] [varchar](50) NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL,
	[lugar] [varchar](50) NOT NULL,
	[cantidad] [int] NULL,
	[nro] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [pk_informatica] PRIMARY KEY CLUSTERED 
(
	[nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Maquinas]    Script Date: 9/1/2023 01:33:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maquinas](
	[marca] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL,
	[lugar] [varchar](50) NOT NULL,
	[cantidad] [int] NULL,
	[nro] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [pk_maquinas] PRIMARY KEY CLUSTERED 
(
	[nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Muebles]    Script Date: 9/1/2023 01:33:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muebles](
	[nombre] [varchar](50) NOT NULL,
	[material] [varchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
	[lugar] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL,
	[adquirido] [varchar](50) NOT NULL,
	[nro] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [pk_muebles] PRIMARY KEY CLUSTERED 
(
	[nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HerramientasManuales] ON 

INSERT [dbo].[HerramientasManuales] ([marca], [nombre], [material], [estado], [lugar], [cantidad], [nro]) VALUES (N'philips', N'destornillador', N'metal y madera', 0, N'taller', 10, 1)
INSERT [dbo].[HerramientasManuales] ([marca], [nombre], [material], [estado], [lugar], [cantidad], [nro]) VALUES (N'hi', N'martillo', N'madera', 1, N'Taller', 10, 2)
SET IDENTITY_INSERT [dbo].[HerramientasManuales] OFF
GO
ALTER TABLE [dbo].[ElementosDibujo] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[HerramientasManuales] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Informatica] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Maquinas] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Muebles] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Consumibles]  WITH CHECK ADD  CONSTRAINT [ck_cantidad_comprada] CHECK  (([cantidadComprada]>(0)))
GO
ALTER TABLE [dbo].[Consumibles] CHECK CONSTRAINT [ck_cantidad_comprada]
GO
ALTER TABLE [dbo].[Consumibles]  WITH CHECK ADD  CONSTRAINT [ck_cantidad_disponible] CHECK  (([cantidadDisponible]>=(0)))
GO
ALTER TABLE [dbo].[Consumibles] CHECK CONSTRAINT [ck_cantidad_disponible]
GO
ALTER TABLE [dbo].[ElementosDibujo]  WITH CHECK ADD  CONSTRAINT [ck_cantidadComprada] CHECK  (([cantidadComprada]>(0)))
GO
ALTER TABLE [dbo].[ElementosDibujo] CHECK CONSTRAINT [ck_cantidadComprada]
GO
ALTER TABLE [dbo].[ElementosDibujo]  WITH CHECK ADD  CONSTRAINT [ck_cantidadDisponible] CHECK  (([cantidadDisponible]>=(0)))
GO
ALTER TABLE [dbo].[ElementosDibujo] CHECK CONSTRAINT [ck_cantidadDisponible]
GO
ALTER TABLE [dbo].[HerramientasManuales]  WITH CHECK ADD  CONSTRAINT [ckcantidad] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[HerramientasManuales] CHECK CONSTRAINT [ckcantidad]
GO
ALTER TABLE [dbo].[Informatica]  WITH CHECK ADD  CONSTRAINT [ckCantidadIn] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[Informatica] CHECK CONSTRAINT [ckCantidadIn]
GO
ALTER TABLE [dbo].[Maquinas]  WITH CHECK ADD  CONSTRAINT [ck_cantidadMaquinas] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[Maquinas] CHECK CONSTRAINT [ck_cantidadMaquinas]
GO
ALTER TABLE [dbo].[Muebles]  WITH CHECK ADD  CONSTRAINT [ck_cantidad] CHECK  (([cantidad]>=(0)))
GO
ALTER TABLE [dbo].[Muebles] CHECK CONSTRAINT [ck_cantidad]
GO
/****** Object:  StoredProcedure [dbo].[mostrarHerramientas]    Script Date: 9/1/2023 01:33:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[mostrarHerramientas]
as
SELECT nro, nombre, marca, material, lugar, cantidad 
FROM HerramientasManuales
WHERE estado = 1
GO
USE [master]
GO
ALTER DATABASE [ParaElInventario] SET  READ_WRITE 
GO
