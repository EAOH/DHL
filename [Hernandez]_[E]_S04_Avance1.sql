--Usar la master
use master
--validar que no exista una BD con ese nombre
if exists (select* from sys.databases where name='dbDHL')
drop database dbDHL

--Crear BD
create database dbDHL
go

--Usarla 
use dbDHL
go

--Crear tablas

--Tablas independientes

--Empleado
create table dbo.Empleado
(empCodigo int identity (1,1) not null,
empNombre varchar (100) not null,
empApellido varchar(100) not null,
empIdentidad varchar(14) not null,
empTelefono varchar(8) not null,
empCorreo varchar (200) not null,
empDireccion varchar (200) not null,
empPuesto varchar (50) not null,
empFechaIngreso date not null,
empUsuario varchar(50) not null,
empContraseña varchar(50) not null,
primary key (empCodigo)
)
go

--Cliente
create table dbo.Cliente
(cliCodigo int identity (1,1) not null,
cliNombre varchar (100) not null,
cliApellido varchar(100) not null,
cliIdentidad varchar(14) not null,
cliTelefono varchar(8) not null,
cliCorreo varchar (200) not null,
cliDireccion varchar (200) not null,
primary key (cliCodigo)
)
go

--Articulos
create table dbo.Articulos
(artCodigo int identity (1,1) not null,
artDescripcion varchar (200) not null,
artEstado varchar (50) not null,
primary key (artCodigo)
)
go

--Otros Gastos
create table dbo.OtrosGastos
(otgaCodigo int identity(1,1) not null,
otgaTipo varchar(100) not null,
otgaDescripcion varchar(200) not null,
otgaFijo decimal(10,2)Not null,
otgaPorcentaje decimal(5,2)not null,
otgaPeso decimal(10,2)not null,
primary key(otgaCodigo)
)
go

--Pais
create table dbo.Pais
(paiCodigo int identity(1,1) not null,
paiNombre varchar(200) not null,
paiZona int not null,
paiEW bit not null,
paie12 bit not null,
paie9 bit not null,
paiImportar bit not null,
primary key (paiCodigo)
)
go

--Precios por zona
create table dbo.Zona
(zonCodigo int identity (1,1) not null,
zonPesoKG decimal (8,3) not null,
zon1 decimal (10,2) not null,
zon2 decimal (10,2) not null,
zon3 decimal (10,2) not null,
zon4 decimal (10,2) not null,
zon5 decimal (10,2) not null,
zon6 decimal (10,2) not null,
zon7 decimal (10,2) not null,
zonTipo varchar(100) not null,
zonCiudad varchar(100),
primary key (zonCodigo)
)
go

--Almacenaje
create table dbo.Almacenaje
(almCodigo int identity (1,1) not null,
almDiasmin int not null,
almDiasMax int not null,
almTipoCarga varchar (100) not null,
almVTramoInicial decimal (10,8) not null,
almVTramoFinal decimal (10,8) not null,
almPesoKmin decimal (10,2) not null,
almPesoKMax decimal (10,2) not null,
almCostoFijo decimal (10,2) not null,
almTipo varchar(100) not null,
almCiudad varchar (100) not null,
primary key(almCodigo)
)
go

--Tablas dependientes

--Envio
create table dbo.Envio
(envCodigo int identity (1,1) not null,
envTipoServicio varchar (50) not null,
envTipoPago varchar (50) not null,
envDescripcion varchar(200) not null,
envPesoKG decimal (10,3) not null,
envDimenciones decimal(10,2) not null,
envDiasAlmacenados int not null,
cliCodigoE int not null,
cliCodigoR int not null,
empCodigo int not null,
paiCodigoD int not null,
zonCodigo int not null,
almCodigo int not null,
primary key (envCodigo),
foreign key (cliCodigoE) references dbo.Cliente (cliCodigo),
foreign key (cliCodigoR) references dbo.Cliente (cliCodigo),
foreign key (empCodigo) references dbo.Empleado (empCodigo),
foreign key (paiCodigoD) references dbo.Pais (paiCodigo),
foreign key (zonCodigo) references dbo.Zona (zonCodigo),
foreign key (almCodigo) references dbo.Almacenaje (almCodigo)
)
go
--Servicios envio
create table dbo.ServicioEnvio
(otgaCodigo int not null,
envCodigo int not null,
primary key(otgaCodigo,envCodigo),
foreign key (otgaCodigo) references dbo.OtrosGastos(otgaCodigo),
foreign key (envCodigo) references dbo.Envio(envCodigo)
)
go

--Procedimientos almacenados

--Procesos de Seleccion

--Empleado
create procedure SP_sEmpleado
as select * from dbo.Empleado order by empCodigo desc
go

--Cliente
create procedure SP_sCliente
as select * from dbo.Cliente order by cliCodigo desc
go

--Articulos
create procedure SP_sArticulos
as select * from dbo.Articulos order by artCodigo desc
go

--Otros gastos
create procedure SP_sOtrosGastos
as select * from dbo.OtrosGastos order by otgaCodigo desc
go

--Pais
create procedure SP_sPais
as select * from dbo.Pais order by paiCodigo desc
go

--Precio por zona
create procedure SP_sZona
as select * from dbo.Zona order by zonCodigo desc
go

--Almacenaje
create procedure SP_sAlmacenaje
as select * from dbo.Almacenaje order by almCodigo desc
go

-- Envio
create Procedure SP_sEnvio
as select dbo.Envio.envCodigo,
dbo.Envio.envTipoServicio,
dbo.Envio.envTipoPago,
dbo.Envio.cliCodigoE,
CE.cliNombre,
CE.cliApellido,
CE.cliDireccion,
dbo.Envio.cliCodigoR,
CR.cliNombre,
CR.cliApellido,
CR.cliDireccion,
CR.cliIdentidad,
CR.cliTelefono,
dbo.Envio.empCodigo,
dbo.Empleado.empNombre,
dbo.Empleado.empApellido,
dbo.Empleado.empPuesto,
dbo.Envio.paiCodigoD,
dbo.Pais.paiNombre,
dbo.Pais.paiZona,
dbo.Envio.envDescripcion,
dbo.Envio.envDimenciones,
dbo.Envio.envPesoKG,
dbo.Envio.envDiasAlmacenados,
dbo.Envio.zonCodigo,
dbo.Zona.zon1,
dbo.Zona.zon2,
dbo.Zona.zon3,
dbo.Zona.zon4,
dbo.Zona.zon5,
dbo.Zona.zon6,
dbo.Zona.zon7,
dbo.Zona.zonTipo,
dbo.Zona.zonCiudad,
dbo.Envio.almCodigo,
dbo.Almacenaje.almCiudad,
dbo.Almacenaje.almTipo,
dbo.Almacenaje.almTipoCarga,
dbo.Almacenaje.almCostoFijo,
dbo.Almacenaje.almVTramoInicial,
dbo.Almacenaje.almVTramoFinal
from dbo.Envio inner join dbo.Cliente CE
on dbo.Envio.cliCodigoE= CE.cliCodigo
inner join dbo.Cliente CR
on dbo.Envio.cliCodigoR= CR.cliCodigo
inner join dbo.Empleado
on dbo.Envio.empCodigo=dbo.Empleado.empCodigo
inner join dbo.Pais
on dbo.Envio.paiCodigoD=dbo.Pais.paiCodigo
inner join dbo.Zona
on dbo.Envio.zonCodigo=dbo.Zona.zonCodigo
inner join dbo.Almacenaje
on dbo.Envio.almCodigo=dbo.Almacenaje.almCodigo
order by dbo.Envio.envCodigo desc
go

--Servicios de envio
create procedure SP_sServiciosEnvio
@envCodigo int
as select dbo.ServicioEnvio.otgaCodigo,
dbo.OtrosGastos.otgaDescripcion,
dbo.OtrosGastos.otgaTipo,
dbo.OtrosGastos.otgaFijo,
dbo.OtrosGastos.otgaPorcentaje,
dbo.OtrosGastos.otgaPeso,
dbo.ServicioEnvio.envCodigo
from dbo.ServicioEnvio inner join dbo.Envio
on dbo.ServicioEnvio.envCodigo=dbo.Envio.envCodigo
inner join dbo.OtrosGastos
on dbo.ServicioEnvio.otgaCodigo=dbo.OtrosGastos.otgaCodigo
where  dbo.Envio.envCodigo=@envCodigo
go
--Procedimiento insertar

--Empleado
create procedure SP_iEmpleado
@empNombre varchar (100) ,
@empApellido varchar(100) ,
@empIdentidad varchar(14) ,
@empTelefono varchar(8) ,
@empCorreo varchar (200) ,
@empDireccion varchar (200),
@empPuesto varchar (50) ,
@empFechaIngreso date ,
@empUsuario varchar(50),
@empContraseña varchar(50)
as insert into dbo.Empleado
(empNombre,empApellido,empIdentidad,empTelefono,empCorreo,empDireccion,empPuesto,empFechaIngreso,empUsuario,empContraseña)
values
(@empNombre,@empApellido,@empIdentidad,@empTelefono,@empCorreo,@empDireccion,@empPuesto,@empFechaIngreso,@empUsuario,@empContraseña)
go

--Cliente
create procedure SP_iCliente
@cliNombre varchar (100),
@cliApellido varchar(100),
@cliIdentidad varchar(14),
@cliTelefono varchar(8),
@cliCorreo varchar (200),
@cliDireccion varchar (200)
as insert into dbo.Cliente
(cliNombre,cliApellido,cliIdentidad,cliTelefono,cliCorreo,cliDireccion)
values
(@cliNombre,@cliApellido,@cliIdentidad,@cliTelefono,@cliCorreo,@cliDireccion)
go

--Articulos
create procedure SP_iArticulos
@artDescripcion varchar (200),
@artEstado varchar(50)
as insert into dbo.Articulos
(artDescripcion,artEstado)
values
(@artDescripcion,@artEstado)
go

--Paquetes
create procedure SP_iPaquetes
@paqDescripcion varchar(200),
@paqPesoKG decimal (10,3),
@paqDimenciones decimal(10,2),
@paqDiasAlmacenados int
as insert into dbo.Paquete
(paqDescripcion,paqPesoKG,paqDimenciones,paqDiasAlmacenados)
values
(@paqDescripcion,@paqPesoKG,@paqDimenciones,@paqDiasAlmacenados)
go

--Otros gastos
create procedure SP_iOtrosGastos
@otgaTipo varchar(100) ,
@otgaDescripcion varchar(200) ,
@otgaFijo decimal(10,2),
@otgaPorcentaje decimal(5,2),
@otgaPeso decimal(10,2)
as insert into dbo.OtrosGastos
(otgaTipo,otgaDescripcion,otgaFijo,otgaPorcentaje,otgaPeso)
values
(@otgaTipo,@otgaDescripcion,@otgaFijo,@otgaPorcentaje,@otgaPeso)
go

--Pais
create procedure SP_iPais
@paiNombre varchar(200) ,
@paiZona int ,
@paiEW bit ,
@paie12 bit ,
@paie9 bit ,
@paiImportar bit
as insert into dbo.Pais
(paiNombre,paiZona,paiEW,paie12,paie9,paiImportar)
values
(@paiNombre,@paiZona,@paiEW,@paie12,@paie9,@paiImportar)
go

--Zona
create procedure SP_iZona
@zonPesoKG decimal (8,3) ,
@zon1 decimal (10,2) ,
@zon2 decimal (10,2) ,
@zon3 decimal (10,2) ,
@zon4 decimal (10,2) ,
@zon5 decimal (10,2) ,
@zon6 decimal (10,2) ,
@zon7 decimal (10,2) ,
@zonTipo varchar(100) ,
@zonCiudad varchar(100)
as insert into dbo.Zona
(zonPesoKG,zon1,zon2,zon3,zon4,zon5,zon6,zon7,zonTipo,zonCiudad)
values
(@zonPesoKG,@zon1,@zon2,@zon3,@zon4,@zon5,@zon6,@zon7,@zonTipo,@zonCiudad)
go

--Almacenaje
create procedure SP_iAlmacenaje
@almDiasmin int ,
@almDiasMax int,
@almTipoCarga varchar (100),
@almVTramoInicial decimal (10,8),
@almVTramoFinal decimal (10,8),
@almPesoKmin decimal (10,2) ,
@almPesoKMax decimal (10,2) ,
@almCostoFijo decimal (10,2),
@almTipo varchar(100) ,
@almCiudad varchar (100)
as insert into dbo.Almacenaje
(almDiasmin,almDiasMax,almTipoCarga,almVTramoInicial,almVTramoFinal,almPesoKmin,almPesoKMax,almCostoFijo,almTipo,almCiudad)
values
(@almDiasmin,@almDiasMax,@almTipoCarga,@almVTramoInicial,@almVTramoFinal,@almPesoKmin,@almPesoKMax,@almCostoFijo,@almTipo,@almCiudad)
go

--Envio
create procedure SP_iEnvio
@envTipoServicio varchar (50),
@envTipoPago varchar (50),
@envDescripcion varchar(200),
@envPesoKG decimal (10,3),
@envDimenciones decimal(10,2),
@envDiasAlmacenados int,
@cliCodigoE int ,
@cliCodigoR int ,
@empCodigo int ,
@paiCodigoD int ,
@zonCodigo int ,
@almCodigo int
as insert into dbo.Envio
(envTipoServicio,envTipoPago,envDescripcion,envPesoKG,envDimenciones,envDiasAlmacenados,cliCodigoE,cliCodigoR,empCodigo,paiCodigoD,zonCodigo,almCodigo)
values
(@envTipoServicio,@envTipoPago,@envDescripcion,@envPesoKG,@envDimenciones,@envDiasAlmacenados,@cliCodigoE,@cliCodigoR,@empCodigo,@paiCodigoD,@zonCodigo,@almCodigo)
go

--Servicio de envio
create procedure SP_iServicioEnvio
@otgaCodigo int,
@envCodigo int
as insert into dbo.ServicioEnvio
(otgaCodigo,envCodigo)
values
(@otgaCodigo,@envCodigo)
go

--Procedimientos de Actualizar

--Empleado
create procedure SP_aEmpleado
@empCodigo int,
@empNombre varchar (100) ,
@empApellido varchar(100) ,
@empIdentidad varchar(14) ,
@empTelefono varchar(8) ,
@empCorreo varchar (200) ,
@empDireccion varchar (200),
@empPuesto varchar (50) ,
@empFechaIngreso date ,
@empUsuario varchar(50),
@empContraseña varchar(50)
as update dbo.Empleado set
empNombre=@empNombre,
empApellido=@empApellido,
empIdentidad=@empIdentidad,
empTelefono=@empTelefono,
empCorreo=@empCorreo,
empDireccion=@empDireccion,
empPuesto=@empPuesto,
empFechaIngreso=@empFechaIngreso,
empUsuario=@empUsuario,
empContraseña=@empContraseña
where
empCodigo=@empCodigo
go

--Cliente
create procedure SP_aCliente
@cliCodigo int,
@cliNombre varchar (100),
@cliApellido varchar(100),
@cliIdentidad varchar(14),
@cliTelefono varchar(8),
@cliCorreo varchar (200),
@cliDireccion varchar (200)
as update dbo.Cliente set
cliNombre=@cliNombre,
cliApellido=@cliApellido,
cliIdentidad=@cliIdentidad,
cliTelefono=@cliTelefono,
cliCorreo=@cliCorreo,
cliDireccion=@cliDireccion
where
cliCodigo=@cliCodigo
go

--Articulos
create procedure SP_aArticulos
@artCodigo int,
@artDescripcion varchar (200),
@artEstado varchar(50)
as update dbo.Articulos set
artDescripcion=@artDescripcion,
artEstado=@artEstado
where
artCodigo=@artCodigo
go

--Otros gastos
create procedure SP_aOtrosGastos
@otgaCodigo int,
@otgaTipo varchar(100),
@otgaDescripcion varchar(200),
@otgaFijo decimal(10,2),
@otgaPorcentaje decimal(5,2),
@otgaPeso decimal(10,2)
as update dbo.OtrosGastos set
otgaTipo=@otgaTipo,
otgaDescripcion=@otgaDescripcion,
otgaFijo=@otgaFijo,
otgaPorcentaje=@otgaPorcentaje,
otgaPeso=@otgaPeso
where
otgaCodigo=@otgaCodigo
go

--Pais
create procedure SP_aPais
@paiCodigo int,
@paiNombre varchar(200) ,
@paiZona int ,
@paiEW bit ,
@paie12 bit ,
@paie9 bit ,
@paiImportar bit
as update dbo.Pais set
paiNombre=@paiNombre,
paiZona=@paiZona,
paiEW=@paiEW,
paie12=@paie12,
paie9=@paie9,
paiImportar=@paiImportar
where
paiCodigo=@paiCodigo
go

--Zona
create procedure SP_aZona
@zonCodigo int,
@zonPesoKG decimal (8,3) ,
@zon1 decimal (10,2) ,
@zon2 decimal (10,2) ,
@zon3 decimal (10,2) ,
@zon4 decimal (10,2) ,
@zon5 decimal (10,2) ,
@zon6 decimal (10,2) ,
@zon7 decimal (10,2) ,
@zonTipo varchar(100) ,
@zonCiudad varchar(100)
as update dbo.Zona set
zonPesoKG=@zonPesoKG,
zon1=@zon1,
zon2=@zon2,
zon3=@zon3,
zon4=@zon4,
zon5=@zon5,
zon6=@zon6,
zon7=@zon7,
zonTipo=@zonTipo,
zonCiudad=@zonCiudad
where
zonCodigo=@zonCodigo
go

--Almacenaje
create procedure SP_aAlmacenaje
@almCodigo int,
@almDiasmin int ,
@almDiasMax int,
@almTipoCarga varchar (100),
@almVTramoInicial decimal (10,8),
@almVTramoFinal decimal (10,8),
@almPesoKmin decimal (10,2) ,
@almPesoKMax decimal (10,2) ,
@almCostoFijo decimal (10,2),
@almTipo varchar(100) ,
@almCiudad varchar (100)
as update dbo.Almacenaje set
almDiasmin=@almDiasmin,
almDiasMax=@almDiasMax,
almTipoCarga=@almTipoCarga,
almVTramoInicial=@almVTramoInicial,
almVTramoFinal=@almVTramoFinal,
almPesoKmin=@almPesoKmin,
almPesoKMax=@almPesoKMax,
almCostoFijo=@almCostoFijo,
almTipo=@almTipo,
almCiudad=@almCiudad
where
almCodigo=@almCodigo
go

--Envio
create procedure SP_aEnvio
@envTipoServicio varchar (50),
@envTipoPago varchar (50),
@envDescripcion varchar(200),
@envPesoKG decimal (10,3),
@envDimenciones decimal(10,2),
@envDiasAlmacenados int,
@envCodigo int,
@cliCodigoE int ,
@cliCodigoR int ,
@empCodigo int ,
@paiCodigoD int ,
@zonCodigo int ,
@almCodigo int
as update dbo.Envio set
envDescripcion=@envDescripcion,
envPesoKG=@envPesoKG,
envDimenciones=@envDimenciones,
envDiasAlmacenados=@envDiasAlmacenados,
envTipoServicio=@envTipoServicio,
envTipoPago=@envTipoPago,
cliCodigoE=@cliCodigoE,
cliCodigoR=@cliCodigoR,
empCodigo=@empCodigo,
paiCodigoD=@paiCodigoD,
zonCodigo=@zonCodigo,
almCodigo=@almCodigo
where
envCodigo=@envCodigo
go

--Procedimiento de eliminar

--Empleado
create procedure SP_eEmpleado
@empCodigo int
as delete from dbo.Empleado
where
empCodigo=@empCodigo
go

--Cliente
create procedure SP_eCliente
@cliCodigo int
as delete from dbo.Cliente
where
cliCodigo=@cliCodigo
go

--Articulos
create procedure SP_eArticulos
@artCodigo int
as delete from dbo.Articulos
where
artCodigo=@artCodigo
go

--Otros gastos
create procedure SP_eOtrosGastos
@otgaCodigo int
as delete from dbo.OtrosGastos
where
otgaCodigo=@otgaCodigo
go

--Pais
create procedure SP_ePais
@paiCodigo int
as delete from dbo.Pais
where
paiCodigo=@paiCodigo
go

--Zona
create procedure SP_eZona
@zonCodigo int
as delete from dbo.Zona
where
zonCodigo=@zonCodigo
go

--Almacenaje
create procedure SP_eAlmacenaje
@almCodigo int
as delete from dbo.Almacenaje
where
almCodigo=@almCodigo
go

--Envio
create procedure SP_eEnvio
@envCodigo int
as delete from dbo.Envio
where
envCodigo=@envCodigo
go

--Servicio de envio
create procedure SP_eServicioEnvio
@otgaCodigo int,
@envCodigo int
as delete from dbo.ServicioEnvio
where
otgaCodigo=@otgaCodigo and envCodigo=@envCodigo
go

--Servicio de envio
create procedure SP_eEnvioServicioEnvio
@envCodigo int
as delete from dbo.ServicioEnvio
where
envCodigo=@envCodigo
go

--Inserciones

--Empleado
exec SP_iEmpleado 'Sara','Herreras','0801199818009','00000000','sara@unitec.edu','La Kennedy','Recursos humanos','1/1/2018','sara','Sh2000'
exec SP_iEmpleado 'Harold','Hernandez','0801199018000','00000000','harold@unitec.edu','El bosque','Atencion al cliente','1/1/2018','harold','Hh1990'
exec SP_iEmpleado 'Maria','Rodriguez','0801199800000','00000000','majo@unitec.edu','La kennedy','Administrador','1/1/2018','majo','Mr1998'
exec SP_iEmpleado 'R','M','0','0','rm@unitec.edu','La kennedy','Mensajero','1/1/2018','rm','Rm'

--Articulos
exec SP_iArticulos 'Armas de Fuego','Prohibido'
exec SP_iArticulos 'Objetos corto Pulsantes','Restringido'

--Paises
exec SP_iPais 'Honduras','1','1','1','1','1'
exec SP_iPais 'Guatemala','5','1','1','0','1'

--Otros gastos
exec SP_iOtrosGastos 'Opcional','Entrega los Fines de Semana','53.00 ','0','0'
exec SP_iOtrosGastos 'Adicional','Áreas Remotas','27.00 ','0.49','0'

--Zona
exec SP_iZona '20','27.25','0','0','0','0','0','0','Local','San pedro sula'
exec SP_iZona '10','287.14','344.88','458.43','522.11','553.29','605.85','686.85','Importacion','Estados unidos'
exec SP_iZona '5','196.28','187.98','246.05','283.34','289.74','289.74','309.03','Exportacion','Estados unidos'

--Almacenaje
exec SP_iAlmacenaje '0','20','General','0','0','0.0','45','30','Estatico','Tegucigalpa'
exec SP_iAlmacenaje'1','10','General','0.02939585','1.24270619','1','125','7.21','Especial','San pedro sula'

--Clientes
exec SP_iCliente 'Elio','Hernandez','0801199800000','00000000','elio@unitec.edu','Barrio el bosque calle el mirador'
exec SP_iCliente 'Ronald','Hernandez','0801199800001','00000001','ronald@unitec.edu','Estacion de bomberos del estadio'

--Mostreos

--Empleado
exec SP_sEmpleado

--Articulos
exec SP_sArticulos

--Pais
exec SP_sPais

--Otros gastos
exec SP_sOtrosGastos

--Almacenaje
exec SP_sAlmacenaje

--Clientes
exec SP_sCliente
