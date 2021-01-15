
--CREAR LA BASE DE DATOS--
CREATE DATABASE AccidenteTransito

GO

--USAR BASE DE DATOS--
USE AccidenteTransito

GO

--CREAR TABLA ACCIDENTE--
CREATE TABLE [dbo].[Accidente](
	[CodigoAccidentes] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Hora] [datetime] NULL,
	[Lugar] [varchar](100) NULL,
	[Latitud] [float] NOT NULL,
	[Longitud] [float] NOT NULL,
 CONSTRAINT [PK_Accidente] PRIMARY KEY CLUSTERED 
(
	[CodigoAccidentes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--CREAR TABLA INVOLUCRADO --
CREATE TABLE [dbo].[Involucrado](
	[IdPersona] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](90) NOT NULL,
	[Telefono] [varchar](13) NOT NULL,
	[Correo] [varchar](90) NOT NULL,
	[Cedula] [varchar](13) NOT NULL,
	[CasoInvolucrado] [int] NOT NULL,
 CONSTRAINT [PK_Involucrado] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[Involucrado]  WITH CHECK ADD  CONSTRAINT [FK_Involucrado_Accidente] FOREIGN KEY([CasoInvolucrado])
REFERENCES [dbo].[Accidente] ([CodigoAccidentes])

ALTER TABLE [dbo].[Involucrado] CHECK CONSTRAINT [FK_Involucrado_Accidente]