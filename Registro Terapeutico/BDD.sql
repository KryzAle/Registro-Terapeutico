USE [master]
GO
/****** Object:  Database [HogarAncianos]    Script Date: 07/09/2019 12:38:33 ******/
CREATE DATABASE [HogarAncianos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HogarAncianos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\HogarAncianos.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HogarAncianos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\HogarAncianos_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HogarAncianos] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HogarAncianos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HogarAncianos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HogarAncianos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HogarAncianos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HogarAncianos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HogarAncianos] SET ARITHABORT OFF 
GO
ALTER DATABASE [HogarAncianos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HogarAncianos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HogarAncianos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HogarAncianos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HogarAncianos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HogarAncianos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HogarAncianos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HogarAncianos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HogarAncianos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HogarAncianos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HogarAncianos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HogarAncianos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HogarAncianos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HogarAncianos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HogarAncianos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HogarAncianos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HogarAncianos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HogarAncianos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HogarAncianos] SET  MULTI_USER 
GO
ALTER DATABASE [HogarAncianos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HogarAncianos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HogarAncianos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HogarAncianos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HogarAncianos] SET DELAYED_DURABILITY = DISABLED 
GO
USE [HogarAncianos]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 07/09/2019 12:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[codigo_pac] [int] IDENTITY(1,1) NOT NULL,
	[nombre_pac] [varchar](50) NULL,
	[apellido_pac] [varchar](50) NULL,
	[cedula_pac] [varchar](50) NULL,
	[fecha_nacimiento_pac] [date] NULL,
	[fecha_registro_pac] [date] NULL,
	[antecedentes_pac] [char](200) NULL,
	[dolor_pac] [int] NULL,
	[marcha_pac] [varchar](50) NULL,
	[muscular_pac] [varchar](50) NULL,
	[neurologica_pac] [varchar](50) NULL,
	[articular_pac] [varchar](200) NULL,
	[discapacidad_pac] [varchar](50) NULL,
	[impresion_diagnostica_pac] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_pac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Preferencia]    Script Date: 07/09/2019 12:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preferencia](
	[codigo_pre] [int] IDENTITY(1,1) NOT NULL,
	[nombre_pre] [varchar](10) NULL,
	[rutaVideo_pre] [varchar](50) NULL,
	[codigo_pac] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_pre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro_Terapeutico]    Script Date: 07/09/2019 12:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro_Terapeutico](
	[codigo_reg] [int] IDENTITY(1,1) NOT NULL,
	[fecha_reg] [date] NULL,
	[repeticiones_reg] [int] NULL,
	[observaciones_reg] [varchar](100) NULL,
	[codigo_pac] [int] NULL,
	[codigo_usu] [int] NULL,
	[codigo_ter] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_reg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Terapia]    Script Date: 07/09/2019 12:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Terapia](
	[codigo_ter] [int] IDENTITY(1,1) NOT NULL,
	[nombre_ter] [varchar](50) NULL,
	[codigo_tip] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_ter] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Terapia]    Script Date: 07/09/2019 12:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Terapia](
	[codigo_tip] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tip] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_tip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/09/2019 12:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[codigo_usu] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usu] [varchar](50) NULL,
	[apellido_usu] [varchar](50) NULL,
	[user_usu] [varchar](50) NULL,
	[password_usu] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_usu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Preferencia]  WITH CHECK ADD FOREIGN KEY([codigo_pac])
REFERENCES [dbo].[Paciente] ([codigo_pac])
GO
ALTER TABLE [dbo].[Registro_Terapeutico]  WITH CHECK ADD FOREIGN KEY([codigo_pac])
REFERENCES [dbo].[Paciente] ([codigo_pac])
GO
ALTER TABLE [dbo].[Registro_Terapeutico]  WITH CHECK ADD FOREIGN KEY([codigo_usu])
REFERENCES [dbo].[Usuario] ([codigo_usu])
GO
ALTER TABLE [dbo].[Registro_Terapeutico]  WITH CHECK ADD FOREIGN KEY([codigo_ter])
REFERENCES [dbo].[Terapia] ([codigo_ter])
GO
ALTER TABLE [dbo].[Terapia]  WITH CHECK ADD FOREIGN KEY([codigo_tip])
REFERENCES [dbo].[Tipo_Terapia] ([codigo_tip])
GO
USE [master]
GO
ALTER DATABASE [HogarAncianos] SET  READ_WRITE 
GO
