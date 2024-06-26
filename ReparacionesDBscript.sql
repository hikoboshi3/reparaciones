USE [master]
GO
/****** Object:  Database [reparaciones]    Script Date: 10/4/2024 01:53:50 ******/
CREATE DATABASE [reparaciones]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'reparaciones', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQL2022\MSSQL\DATA\reparaciones.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'reparaciones_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQL2022\MSSQL\DATA\reparaciones_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [reparaciones] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [reparaciones].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [reparaciones] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [reparaciones] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [reparaciones] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [reparaciones] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [reparaciones] SET ARITHABORT OFF 
GO
ALTER DATABASE [reparaciones] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [reparaciones] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [reparaciones] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [reparaciones] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [reparaciones] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [reparaciones] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [reparaciones] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [reparaciones] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [reparaciones] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [reparaciones] SET  DISABLE_BROKER 
GO
ALTER DATABASE [reparaciones] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [reparaciones] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [reparaciones] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [reparaciones] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [reparaciones] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [reparaciones] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [reparaciones] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [reparaciones] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [reparaciones] SET  MULTI_USER 
GO
ALTER DATABASE [reparaciones] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [reparaciones] SET DB_CHAINING OFF 
GO
ALTER DATABASE [reparaciones] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [reparaciones] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [reparaciones] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [reparaciones] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [reparaciones] SET QUERY_STORE = ON
GO
ALTER DATABASE [reparaciones] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [reparaciones]
GO
/****** Object:  Table [dbo].[Automovil]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Automovil](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdVehiculo] [bigint] NOT NULL,
	[Tipo] [tinyint] NOT NULL,
	[CantidadPuertas] [tinyint] NOT NULL,
 CONSTRAINT [PK_Automovil] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Desperfecto]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Desperfecto](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdPresupuesto] [bigint] NOT NULL,
	[Descripcion] [varchar](512) NOT NULL,
	[ManoDeObra] [decimal](12, 2) NULL,
	[Tiempo] [int] NULL,
 CONSTRAINT [PK_Desperfecto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DesperfectoRepuesto]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DesperfectoRepuesto](
	[IdDesperfecto] [bigint] NOT NULL,
	[IdRepuesto] [bigint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Moto]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Moto](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdVehiculo] [bigint] NOT NULL,
	[Cilindrada] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Moto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presupuesto]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presupuesto](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Email] [varchar](50) NULL,
	[IdVehiculo] [bigint] NOT NULL,
	[TotalRepuestos] [decimal](12, 2) NULL,
	[TotalManoDeObra] [decimal](12, 2) NULL,
	[TotalTiempo] [int] NULL,
	[Total] [decimal](12, 2) NULL,
	[FechaIngreso] [datetime] NOT NULL,
	[Estado] [char](3) NOT NULL,
 CONSTRAINT [PK_Presupuesto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repuesto]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repuesto](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](10) NOT NULL,
	[Precio] [decimal](18, 6) NOT NULL,
 CONSTRAINT [PK_Repuesto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](200) NOT NULL,
	[Modelo] [varchar](200) NOT NULL,
	[Patente] [varchar](20) NOT NULL,
	[Tipo] [char](1) NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Automovil]  WITH CHECK ADD  CONSTRAINT [FK_Automovil_Vehiculo] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculo] ([Id])
GO
ALTER TABLE [dbo].[Automovil] CHECK CONSTRAINT [FK_Automovil_Vehiculo]
GO
ALTER TABLE [dbo].[Desperfecto]  WITH CHECK ADD  CONSTRAINT [FK_Desperfecto_Presupuesto] FOREIGN KEY([IdPresupuesto])
REFERENCES [dbo].[Presupuesto] ([Id])
GO
ALTER TABLE [dbo].[Desperfecto] CHECK CONSTRAINT [FK_Desperfecto_Presupuesto]
GO
ALTER TABLE [dbo].[DesperfectoRepuesto]  WITH CHECK ADD  CONSTRAINT [FK_DesperfectoRepuesto_Desperfecto] FOREIGN KEY([IdDesperfecto])
REFERENCES [dbo].[Desperfecto] ([Id])
GO
ALTER TABLE [dbo].[DesperfectoRepuesto] CHECK CONSTRAINT [FK_DesperfectoRepuesto_Desperfecto]
GO
ALTER TABLE [dbo].[DesperfectoRepuesto]  WITH CHECK ADD  CONSTRAINT [FK_DesperfectoRepuesto_Repuesto] FOREIGN KEY([IdRepuesto])
REFERENCES [dbo].[Repuesto] ([Id])
GO
ALTER TABLE [dbo].[DesperfectoRepuesto] CHECK CONSTRAINT [FK_DesperfectoRepuesto_Repuesto]
GO
ALTER TABLE [dbo].[Moto]  WITH CHECK ADD  CONSTRAINT [FK_Moto_Vehiculo] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculo] ([Id])
GO
ALTER TABLE [dbo].[Moto] CHECK CONSTRAINT [FK_Moto_Vehiculo]
GO
ALTER TABLE [dbo].[Presupuesto]  WITH CHECK ADD  CONSTRAINT [FK_Presupuesto_Vehiculo] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculo] ([Id])
GO
ALTER TABLE [dbo].[Presupuesto] CHECK CONSTRAINT [FK_Presupuesto_Vehiculo]
GO
/****** Object:  StoredProcedure [dbo].[Automovil_I]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Automovil_I]

	@Marca varchar(200),
	@Modelo varchar(200),
	@Patente varchar(20),
	@Tipo smallint,
	@CantidadPuertas tinyint

AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @IdVehiculo bigint

	INSERT INTO Vehiculo (Marca, Modelo, Patente, Tipo)
	VALUES(
	@Marca,
	@Modelo,
	@Patente,
	'A'
	)

	set @IdVehiculo = @@IDENTITY

	if(@IdVehiculo > 0)
	BEGIN
		INSERT INTO Automovil (IdVehiculo, Tipo, CantidadPuertas)
		VALUES (
		@IdVehiculo,
		@Tipo,
		@CantidadPuertas
		)
	END

	SELECT @IdVehiculo as IdVehiculo
 
END
GO
/****** Object:  StoredProcedure [dbo].[Desperfecto_I]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Desperfecto_I] 
 
	@Id bigint output,
	@IdPresupuesto bigint,
	@Descripcion varchar(512),
	@ManoDeObra decimal(12,2),
	@Tiempo int

AS
BEGIN

	SET NOCOUNT ON;

 INSERT INTO Desperfecto (
 							IdPresupuesto,
							Descripcion,
							ManoDeObra,
							Tiempo)
			VALUES
			(
						@IdPresupuesto,
						@Descripcion,
						@ManoDeObra,
						@Tiempo
			)


			Set @Id =  @@IDENTITY	

END
GO
/****** Object:  StoredProcedure [dbo].[DesperfectoRepuesto_I]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DesperfectoRepuesto_I] 
 
	@IdDesperfecto bigint,
	@IdRepuesto bigint
 

AS
BEGIN

	SET NOCOUNT ON;

 INSERT INTO DesperfectoRepuesto (IdDesperfecto, IdRepuesto)
			VALUES
			(
						@IdDesperfecto,
						@IdRepuesto
			)


END
GO
/****** Object:  StoredProcedure [dbo].[GET_presupuesto]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GET_presupuesto] 

	@IdPersupuesto int
AS
BEGIN
 
	SET NOCOUNT ON;

select 
P.id as [Nro. Presupuesto],
P.nombre + ' ' + P.apellido as Nombre,
P.FechaIngreso as Fecha,
V.Marca, V.Modelo, V.patente as Dominio,
P.Total
from presupuesto P inner join Vehiculo V on P.IdVehiculo = V.id
WHERE P.id = 1


--select 
--P.id as [Nro. Presupuesto],
--P.nombre + ' ' + P.apellido as Nombre,
--P.FechaIngreso as Fecha,
--V.Marca, V.Modelo, V.patente as Dominio,
--D.Descripcion
----, D.ManoDeObra 
----,R.Nombre as Repuesto
--from presupuesto P inner join Vehiculo V on P.IdVehiculo = V.id
--inner join Desperfecto D on P.id = D.IdPresupuesto
--inner join DesperfectoRepuesto E on D.Id = E.IdDesperfecto
----inner join Repuesto R on E.IdRepuesto = R.id
--WHERE P.id = 1


/*
	select * from Vehiculo
	select * from Automovil
	select * from Moto
	select * from presupuesto
	select * from Desperfecto
	select * from DesperfectoRepuesto
	select * from repuesto
*/

END
GO
/****** Object:  StoredProcedure [dbo].[GetDesperfecto]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetDesperfecto]

AS
BEGIN

	SET NOCOUNT ON;

	SELECT * from Desperfecto
END
GO
/****** Object:  StoredProcedure [dbo].[GetDesperfectos]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetDesperfectos]

AS
BEGIN

	SET NOCOUNT ON;

	SELECT * from Desperfectos
END
GO
/****** Object:  StoredProcedure [dbo].[GetRepuestos]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetRepuestos]

AS
BEGIN

	SET NOCOUNT ON;

    SELECT Id, Nombre, Precio FROM REPUESTO
	FOR JSON PATH
END
GO
/****** Object:  StoredProcedure [dbo].[MassiveCharge]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
EXEC dbo.MassiveCharge 
*/

/*****************************************************************************************/
/*+                                                                                      */
/*+ Nombre  : dbo.MassiveCharge                                                          */
/*+ Objetivo: Insertar en la BD una serie de Respuestos con sus Precios                  */
/*+                                                                                      */
/*****************************************************************************************/

CREATE PROC [dbo].[MassiveCharge] AS
BEGIN

/*+ Creación de la tabla Temporal que contendrá los Repuestos con sus precios*/

    CREATE TABLE #TMP_RESPUESTO (Nombre VARCHAR(100),
                                 Precio DECIMAL(18,6))

/*+ Se generan los registros en la tabla temporal que posteriormente se evaluarán para ver si procede su carga en la tabla definitiva de Repuestos*/

    BEGIN /*+ BEGIN INSERT EN LA TEMPORAL DE RESPUESTOS*/
        INSERT INTO #TMP_RESPUESTO VALUES ('B356963821', 17.61)
        INSERT INTO #TMP_RESPUESTO VALUES ('B881468337', 40.88)
        INSERT INTO #TMP_RESPUESTO VALUES ('B867719836', 87.76)
        INSERT INTO #TMP_RESPUESTO VALUES ('B397571688', 13.97)
        INSERT INTO #TMP_RESPUESTO VALUES ('B852883143', 47.97)
        INSERT INTO #TMP_RESPUESTO VALUES ('B461882670', 22.68)
        INSERT INTO #TMP_RESPUESTO VALUES ('B333520964', 82.28)
        INSERT INTO #TMP_RESPUESTO VALUES ('B388445039', 50.71)
        INSERT INTO #TMP_RESPUESTO VALUES ('B648201513', 21.83)
        INSERT INTO #TMP_RESPUESTO VALUES ('B436759416', 35.39)
        INSERT INTO #TMP_RESPUESTO VALUES ('B317533243', 22.84)
        INSERT INTO #TMP_RESPUESTO VALUES ('B666592414', 58.67)
        INSERT INTO #TMP_RESPUESTO VALUES ('B443568817', 53.83)
        INSERT INTO #TMP_RESPUESTO VALUES ('B316416378', 17.74)
        INSERT INTO #TMP_RESPUESTO VALUES ('B252543362', 16.98)
        INSERT INTO #TMP_RESPUESTO VALUES ('B453148609', 14.23)
        INSERT INTO #TMP_RESPUESTO VALUES ('B254958806', 41.19)
        INSERT INTO #TMP_RESPUESTO VALUES ('B356963821', 62.58)
        INSERT INTO #TMP_RESPUESTO VALUES ('B846487171', 92.91)
        INSERT INTO #TMP_RESPUESTO VALUES ('B397571688', 1.04)
        INSERT INTO #TMP_RESPUESTO VALUES ('B535169105', 90.14)
        INSERT INTO #TMP_RESPUESTO VALUES ('B628263302', 78.64)
        INSERT INTO #TMP_RESPUESTO VALUES ('B608816685', 93.73)
        INSERT INTO #TMP_RESPUESTO VALUES ('B660755442', 43.62)
        INSERT INTO #TMP_RESPUESTO VALUES ('B659053715', 90.59)
        INSERT INTO #TMP_RESPUESTO VALUES ('B556344166', 71.62)
        INSERT INTO #TMP_RESPUESTO VALUES ('B216140665', 93.15)
        INSERT INTO #TMP_RESPUESTO VALUES ('B843858581', 66.52)
        INSERT INTO #TMP_RESPUESTO VALUES ('B790077756', 8.91)
        INSERT INTO #TMP_RESPUESTO VALUES ('B916071768', 85.46)
        INSERT INTO #TMP_RESPUESTO VALUES ('B317533243', 7.97)
        INSERT INTO #TMP_RESPUESTO VALUES ('B343454513', 22.91)
        INSERT INTO #TMP_RESPUESTO VALUES ('B986574036', 65.10)
        INSERT INTO #TMP_RESPUESTO VALUES ('B662139869', 3.50)
        INSERT INTO #TMP_RESPUESTO VALUES ('B618792223', 6.87)
        INSERT INTO #TMP_RESPUESTO VALUES ('B578485476', 49.70)
        INSERT INTO #TMP_RESPUESTO VALUES ('B132813434', 32.58)
        INSERT INTO #TMP_RESPUESTO VALUES ('B776163235', 73.64)
        INSERT INTO #TMP_RESPUESTO VALUES ('B215908676', 92.83)
        INSERT INTO #TMP_RESPUESTO VALUES ('B871139440', 31.83)
        INSERT INTO #TMP_RESPUESTO VALUES ('B564893705', 18.91)
        INSERT INTO #TMP_RESPUESTO VALUES ('B634131771', 70.35)
        INSERT INTO #TMP_RESPUESTO VALUES ('B321187273', 91.96)
        INSERT INTO #TMP_RESPUESTO VALUES ('B444737823', 78.73)
        INSERT INTO #TMP_RESPUESTO VALUES ('B413525993', 9.93)
        INSERT INTO #TMP_RESPUESTO VALUES ('B229547877', 97.08)
        INSERT INTO #TMP_RESPUESTO VALUES ('B545788950', 11.84)
        INSERT INTO #TMP_RESPUESTO VALUES ('B658514562', 8.84)
        INSERT INTO #TMP_RESPUESTO VALUES ('B736313138', 78.47)
        INSERT INTO #TMP_RESPUESTO VALUES ('B840888802', 93.85)
        INSERT INTO #TMP_RESPUESTO VALUES ('B883572821', 21.57)
        INSERT INTO #TMP_RESPUESTO VALUES ('B493478663', 76.98)
        INSERT INTO #TMP_RESPUESTO VALUES ('B718838840', 7.41)
        INSERT INTO #TMP_RESPUESTO VALUES ('B183671709', 45.53)
        INSERT INTO #TMP_RESPUESTO VALUES ('B908384721', 14.73)
        INSERT INTO #TMP_RESPUESTO VALUES ('B566417680', 44.04)
        INSERT INTO #TMP_RESPUESTO VALUES ('B633833113', 33.28)
        INSERT INTO #TMP_RESPUESTO VALUES ('B829258206', 41.74)
        INSERT INTO #TMP_RESPUESTO VALUES ('B350041352', 85.13)
        INSERT INTO #TMP_RESPUESTO VALUES ('B548168477', 7.44)
        INSERT INTO #TMP_RESPUESTO VALUES ('B765657146', 89.79)
        INSERT INTO #TMP_RESPUESTO VALUES ('B830231322', 81.42)
        INSERT INTO #TMP_RESPUESTO VALUES ('B816385774', 9.30)
        INSERT INTO #TMP_RESPUESTO VALUES ('B857448796', 77.36)
        INSERT INTO #TMP_RESPUESTO VALUES ('B302875266', 54.89)
        INSERT INTO #TMP_RESPUESTO VALUES ('B790507487', 50.41)
        INSERT INTO #TMP_RESPUESTO VALUES ('B723629401', 65.36)
        INSERT INTO #TMP_RESPUESTO VALUES ('B595728629', 19.94)
        INSERT INTO #TMP_RESPUESTO VALUES ('B472436824', 65.69)
        INSERT INTO #TMP_RESPUESTO VALUES ('B235859870', 66.44)
        INSERT INTO #TMP_RESPUESTO VALUES ('B874178252', 42.38)
        INSERT INTO #TMP_RESPUESTO VALUES ('B777713850', 40.26)
        INSERT INTO #TMP_RESPUESTO VALUES ('B550221285', 8.72)
        INSERT INTO #TMP_RESPUESTO VALUES ('B816043247', 73.97)
        INSERT INTO #TMP_RESPUESTO VALUES ('B607313788', 15.95)
        INSERT INTO #TMP_RESPUESTO VALUES ('B396482694', 45.17)
        INSERT INTO #TMP_RESPUESTO VALUES ('B504021331', 24.52)
        INSERT INTO #TMP_RESPUESTO VALUES ('B651475349', 86.77)
        INSERT INTO #TMP_RESPUESTO VALUES ('B470409863', 11.81)
        INSERT INTO #TMP_RESPUESTO VALUES ('B264135435', 62.58)
        INSERT INTO #TMP_RESPUESTO VALUES ('B755636151', 33.88)
        INSERT INTO #TMP_RESPUESTO VALUES ('B382183955', 0.92)
        INSERT INTO #TMP_RESPUESTO VALUES ('B667316286', 0.29)
        INSERT INTO #TMP_RESPUESTO VALUES ('B783117048', 41.57)
        INSERT INTO #TMP_RESPUESTO VALUES ('B812952354', 86.25)
        INSERT INTO #TMP_RESPUESTO VALUES ('B621838237', 80.54)
        INSERT INTO #TMP_RESPUESTO VALUES ('B665465223', 53.69)
        INSERT INTO #TMP_RESPUESTO VALUES ('B881682635', 64.78)
        INSERT INTO #TMP_RESPUESTO VALUES ('B646289861', 72.01)
        INSERT INTO #TMP_RESPUESTO VALUES ('B852115667', 48.73)
        INSERT INTO #TMP_RESPUESTO VALUES ('B144635415', 34.23)
        INSERT INTO #TMP_RESPUESTO VALUES ('B874863828', 24.70)
        INSERT INTO #TMP_RESPUESTO VALUES ('B333841476', 41.57)
        INSERT INTO #TMP_RESPUESTO VALUES ('B587386017', 45.27)
        INSERT INTO #TMP_RESPUESTO VALUES ('B874270576', 42.38)
        INSERT INTO #TMP_RESPUESTO VALUES ('B300733136', 25.55)
        INSERT INTO #TMP_RESPUESTO VALUES ('B611446656', 60.12)
        INSERT INTO #TMP_RESPUESTO VALUES ('B801300387', 61.04)
        INSERT INTO #TMP_RESPUESTO VALUES ('B845153562', 60.09)
        INSERT INTO #TMP_RESPUESTO VALUES ('B943846621', 37.05)
    END /*+ END INSERT EN LA TEMPORAL DE RESPUESTOS*/

	
/*
     Se necesita que se carguen en la tabla Definitiva de Repuestos, cada registro
    que exista en la temporal, siempre y cuando:
     El valor del Repuesto sea menor a 20$
o Aquellos Repuestos que no se inserten/actualicen, pues su
valor es mayor o igual a 20$, deberá reportarse en un Query de
salida.
     Si un repuesto existiere más de una vez, se deberá acumular el valor del
    mismo, para el mismo Respuesto.
     Se recomienda usar un Cursor para la evaluación de los registros. 


*/
/* CURSOR */
declare @NombreRepuesto varchar(20)
declare @PrecioRepuesto decimal(12,2)

--
DECLARE cursor_repuestos CURSOR READ_ONLY FOR 

--> Si un repuesto existiere más de una vez, se deberá acumular el valor del mismo, para el mismo Respuesto.
select Nombre, SUM(Precio) as Precio
from #TMP_RESPUESTO
--> Si entendí bien esto....
group by Nombre

OPEN cursor_repuestos
FETCH NEXT FROM cursor_repuestos INTO @NombreRepuesto, @PrecioRepuesto

WHILE @@FETCH_STATUS = 0 
  BEGIN
    if @PrecioRepuesto < 20 
	BEGIN
        INSERT INTO Repuesto
            (Nombre, Precio)
        VALUES
            (@NombreRepuesto, @PrecioRepuesto)
    END
    FETCH NEXT FROM cursor_repuestos INTO @NombreRepuesto, @PrecioRepuesto
END

CLOSE cursor_repuestos
DEALLOCATE cursor_repuestos
/*
	Aquellos Repuestos que no se inserten/actualicen, pues su
	valor es mayor o igual a 20$, deberá reportarse en un Query de
	salida.
*/

select *
from #TMP_RESPUESTO
where Nombre not in(SELECT Nombre
FROM Repuesto)

END
GO
/****** Object:  StoredProcedure [dbo].[Moto_I]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Moto_I]

	@Marca varchar(200),
	@Modelo varchar(200),
	@Patente varchar(20),
	@Cilindrada varchar(200)

AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @IdVehiculo bigint

	INSERT INTO Vehiculo (Marca, Modelo, Patente, Tipo)
	VALUES(
	@Marca,
	@Modelo,
	@Patente,
	'M'
	)

	set @IdVehiculo = @@IDENTITY

	if(@IdVehiculo > 0)
	BEGIN
		INSERT INTO Moto (IdVehiculo, Cilindrada)
		VALUES (
		@IdVehiculo,
		@Cilindrada
		)
	END

	SELECT @IdVehiculo as IdVehiculo
 
END
GO
/****** Object:  StoredProcedure [dbo].[Presupuesto_I]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Presupuesto_I]
	@Id bigint output,
	@Nombre varchar(100),
	@Apellido varchar(100), 
	@Email varchar(50),
	@IdVehiculo bigint,
	@Total Decimal(12,2)
AS
BEGIN
 
	SET NOCOUNT ON;
	 
	INSERT INTO Presupuesto (Nombre, Apellido, Email, IdVehiculo,Total,FechaIngreso, Estado)
	VALUES
	(@Nombre,
	@Apellido, 
	@Email,
	@IdVehiculo,
	@Total,
	getdate(),
	'ING'
	)

	set @Id = @@IDENTITY

END
GO
/****** Object:  StoredProcedure [dbo].[Presupuesto_U]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Presupuesto_U]

	@IdPresupuesto bigint,
	@TotalRepuestos decimal(12,2),
	@TotalManoDeObra decimal(12,2),
	@TotalTiempo int,
	@Total decimal(12,2)

AS
BEGIN

	SET NOCOUNT ON;

	UPDATE Presupuesto set
	TotalRepuestos = @TotalRepuestos,
	TotalManoDeObra = @TotalManoDeObra,
	TotalTiempo = @TotalTiempo,
	Total = @Total
	WHERE Id = @IdPresupuesto

END
GO
/****** Object:  StoredProcedure [dbo].[PromedioTotalMarcaModelo]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PromedioTotalMarcaModelo]

AS
BEGIN

	SET NOCOUNT ON;

--Promedio del Monto Total de Presupuestos agrupado por Marca/Modelo 

	select 
	V.marca, V.modelo, AVG(P.Total) as Monto
	from 
	Presupuesto P 
		inner join Vehiculo V on P.IdVehiculo = V.id
	 group by V.marca, V.modelo
	 ORDER BY COUNT(*) desc

END
GO
/****** Object:  StoredProcedure [dbo].[RepuestoMasUtilizado]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[RepuestoMasUtilizado]

AS
BEGIN

/*
	Repuesto más utilizado agrupado por Marca/Modelo en las reparaciones
	realizadas (Mostrar Descripción del Repuesto y cantidad de veces usado)
*/


	select 
	V.marca, V.modelo, R.Nombre, COUNT(*) as Cantidad
	from 
	Presupuesto P 
		inner join Vehiculo V on P.IdVehiculo = V.id
		inner join Desperfecto D on P.id = D.IdPresupuesto
		inner join DesperfectoRepuesto DP on D.id = DP.IdDesperfecto
		inner join Repuesto R on DP.IdRepuesto = R.Id
	 group by V.marca, V.modelo, R.Nombre
	 ORDER BY COUNT(*) desc

END
GO
/****** Object:  StoredProcedure [dbo].[SumatoriaTotalesPorTipoVehiculo]    Script Date: 10/4/2024 01:53:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SumatoriaTotalesPorTipoVehiculo]
 
AS
BEGIN
 
	SET NOCOUNT ON;
 --Sumatoria del Monto Total de Presupuestos para Autos y para Motos 

	select 
	SUM(case when V.tipo = 'A' then Total else 0 END) as Sumatoria_Autos,
	SUM(case when V.tipo = 'M' then Total else 0 END) as Sumatoria_Motos
	from 
	Presupuesto P inner join Vehiculo V on P.IdVehiculo = V.id
END
GO
USE [master]
GO
ALTER DATABASE [reparaciones] SET  READ_WRITE 
GO
