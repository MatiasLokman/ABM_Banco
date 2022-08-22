-- Problema 1.3: Banco

-- Crear base de datos
create database db_113870

-- Usar la base de datos anteriormente creada
use db_113870

-- Crear las tablas de la base de datos
create table TiposCuentas(
tipoCuenta int identity(1,1),
nombre varchar(30)
constraint pk_TiposCuentas primary key(tipoCuenta)
)

create table Cuentas(
cbu int,
saldo money,
tipoCuenta int,
ultimoMovimiento money
constraint pk_cuentas primary key(cbu),
constraint fk_cuentas_tiposCuentas foreign key(tipoCuenta) references TiposCuentas(tipoCuenta),
)

create table Clientes(
dni int,
nombre varchar(30),
apellido varchar(30),
cbu int
constraint pk_clientes primary key(dni)
constraint fk_clientes_cuentas foreign key(cbu) references Cuentas(cbu)
)

-- Crear las procedimientos almacenados
-- (Cargar Grilla de clientes y cuentas)
create procedure GrillaClientesCuentas
as
select dni as 'DNI', Clientes.nombre as 'Nombre', apellido as 'Apellido', Clientes.cbu as 'CBU', TiposCuentas.nombre as 'Tipo de cuenta' from Clientes join Cuentas on Clientes.cbu = Cuentas.cbu join
TiposCuentas on Cuentas.tipoCuenta = TiposCuentas.tipoCuenta

-- (Cargar grilla de cuentas)
create procedure GrillaCuentas
as
select cbu as 'CBU', convert(int, round(saldo, 0,1)) as 'Saldo', TiposCuentas.nombre as 'Tipo de cuenta', convert(int, round(ultimoMovimiento, 0,1)) as 'Ultimo movimiento' from Cuentas join
TiposCuentas on Cuentas.tipoCuenta = TiposCuentas.tipoCuenta

-- (Cargar combo)
create procedure ComboTiposCuenta
as
select * from TiposCuentas

-- (Agregar cliente)
create procedure AgregarCliente
@dni int,
@nombre varchar(30),
@apellido varchar(30),
@cbuCliente int
as
insert into Clientes (dni, Cliente.nombre, apellido, Cliente.cbu)
values (@dni, @nombre, @apellido, @cbuCliente)

-- (Actualizar cliente)
create procedure ActualizarCliente
@dni int,
@nombre varchar(30),
@apellido varchar(30),
@cbuCliente int
as
update Clientes set nombre=@nombre, apellido=@apellido, cbu=@cbuCliente where dni=@dni

-- (Eliminar cliente)
create procedure EliminarCliente
@dni int
as
delete from Clientes where dni=@dni

-- (Agregar cuenta)
create procedure AgregarCuenta
@cbuCuenta int,
@saldo money,
@tipoCuenta int,
@ultimoMovimiento money
as
insert into cuentas (cbu, saldo, tipoCuenta, ultimoMovimiento)
values (@cbuCuenta, @saldo, @tipoCuenta, @ultimoMovimiento)

-- (Actualizar cuenta)
create procedure ActualizarCuenta
@cbuCuenta int,
@saldo money,
@tipoCuenta int,
@ultimoMovimiento money
as
update Cuentas set saldo=@saldo, tipoCuenta=@tipoCuenta, ultimoMovimiento=@ultimoMovimiento WHERE cbu=@cbuCuenta

-- (Eliminar cuenta)
create procedure EliminarCuenta
@cbuCuenta int
as
delete from Cuentas where cbu=@cbuCuenta

-- Insertar datos
-- (Insertar datos en tipos de cuenta)
insert into TiposCuentas  (nombre) values ('Cuenta corriente')
insert into TiposCuentas  (nombre) values ('Cuenta Sueldo')
insert into TiposCuentas  (nombre) values ('Caja de ahorro')

-- (Insertar datos en cuentas)
insert into Cuentas (cbu, saldo, tipoCuenta, ultimoMovimiento) values (4254, 1500, 1, 200)
insert into Cuentas (cbu, saldo, tipoCuenta, ultimoMovimiento) values (4255, 500, 2, 100)
insert into Cuentas (cbu, saldo, tipoCuenta, ultimoMovimiento) values (4256, 3000, 3, 1000)

-- (Insertar datos en clientes)
insert into Clientes (dni, nombre, apellido, cbu) values (43693949, 'Matias', 'Lokman', 4254)
insert into Clientes (dni, nombre, apellido, cbu) values (16529349, 'Ramiro', 'Fernandez', 4255)
insert into Clientes (dni, nombre, apellido, cbu) values (24897632, 'Jorge', 'Ramirez', 4256)