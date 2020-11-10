USE [master]
GO
/****** Object:  Database [IPS]    Script Date: 9/11/2020 8:54:35 p. m. ******/
CREATE DATABASE [IPS]

 ON  PRIMARY 
( NAME = N'IPS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\IPS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'IPS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\IPS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [IPS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IPS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IPS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IPS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IPS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IPS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IPS] SET ARITHABORT OFF 
GO
ALTER DATABASE [IPS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IPS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IPS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IPS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IPS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IPS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IPS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IPS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IPS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IPS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IPS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IPS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IPS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IPS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IPS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IPS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IPS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IPS] SET RECOVERY FULL 
GO
ALTER DATABASE [IPS] SET  MULTI_USER 
GO
ALTER DATABASE [IPS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IPS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IPS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IPS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [IPS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [IPS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'IPS', N'ON'
GO
ALTER DATABASE [IPS] SET QUERY_STORE = OFF
GO
USE [IPS]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 9/11/2020 8:54:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[IdentificacionMedico] [varchar](20) NOT NULL,
	[IdentificacionPaciente] [varchar](20) NOT NULL,
	[FechaCita] [date] NOT NULL,
 CONSTRAINT [PK_Cita_1] PRIMARY KEY CLUSTERED 
(
	[IdentificacionMedico] ASC,
	[IdentificacionPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medico]    Script Date: 9/11/2020 8:54:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medico](
	[IdentificacionMedico] [varchar](20) NOT NULL,
	[Nombres] [nvarchar](50) NOT NULL,
	[Apellidos] [nvarchar](50) NOT NULL,
	[Especialidad] [nvarchar](50) NOT NULL,
	[SalarioPorCita] [int] NOT NULL,
	[AñosExperiencia] [int] NOT NULL,
 CONSTRAINT [PK_Medico] PRIMARY KEY CLUSTERED 
(
	[IdentificacionMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 9/11/2020 8:54:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[IdentificacionPaciente] [varchar](20) NOT NULL,
	[Nombres] [nvarchar](50) NOT NULL,
	[Apellidos] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[FechaRegistro] [date] NOT NULL,
	[Multas] [int] NOT NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[IdentificacionPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Medico] FOREIGN KEY([IdentificacionMedico])
REFERENCES [dbo].[Medico] ([IdentificacionMedico])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Medico]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Paciente] FOREIGN KEY([IdentificacionPaciente])
REFERENCES [dbo].[Paciente] ([IdentificacionPaciente])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Paciente]
GO
USE [master]
GO
ALTER DATABASE [IPS] SET  READ_WRITE 
GO
