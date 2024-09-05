drop table usuarios;
show tables


create table usuarios(
    ID int primary key auto_increment,
    Username varchar(255),
    Password varchar(12),
    Nombre varchar(255),
    Apellido varchar(255),
    Nivel int
);
alter table usuarios modify column Password varchar(255);
alter table usuarios modify column Nivel varchar(1);

create table Registro_Temperatura (
    ID int primary key auto_increment,
    Numero_Sensor int,
    Temperatura int,
    Fecha_Hora timestamp default current_timestamp,
    Estado_Sensor boolean
);
drop table Registro_Temperatura;

show tables;
describe Registro_Temperatura;
describe usuarios;

/*creacion procedure de validar usuario*/
DROP procedure if exists p_validar; 
create procedure p_validar
(
	in _user varchar(255),
	in _pass varchar(255)
)
begin 

	DECLARE x INT;
	SELECT COUNT(*) FROM usuarios WHERE Username = _user AND Password = _pass INTO x;
	if x > 0 then
		SELECT 'Correcto' AS rs, (SELECT Nivel FROM usuarios WHERE Username = _user) AS Nivel;
	ELSE
		SELECT 'Error' AS rs, 0 AS Nivel;
	END if;
END;

insert into usuarios (Username, Password, Nombre, Apellido, Nivel) values
(
    'Pepin1',sha1('123'),'Pepin','Gempleis',1
),
(
    'Pepin2',sha1('123'),'Pepin','Gempleis',2
),
(
    'Pepin3',sha1('123'),'Pepin','Gempleis',3
);

select * from usuarios;

call p_validar('Pepin1',sha1('123'));
call p_validar('Pepin2',sha1('123'));
call p_validar('Pepin3',sha1('123'));

show databases;

create view v_Usuarios AS select Username, Nombre, Apellido, Nivel from usuarios;

select * from Registro_Temperatura;

create view V_Temps_General AS
    SELECT 
        CONCAT('Sensor ', Numero_Sensor) AS Numero_Sensor,
        IFNULL(Temperatura, '---') AS Temperatura,
        CASE 
            WHEN Estado_Sensor = 1 THEN 'Activado'
            WHEN Estado_Sensor = 0 THEN 'Desactivado'
        END AS Estado_Sensor,
        Fecha_Hora
    FROM 
        Registro_Temperatura;

drop view if exists Vista_Temps_General;

create view V_Temps_Activados as
    SELECT 
        CONCAT('Sensor ', Numero_Sensor) AS Numero_Sensor,
        IFNULL(Temperatura, '---') AS Temperatura,
        CASE 
            WHEN Estado_Sensor = 1 THEN 'Activado'
            ELSE 'Desactivado'
        END AS Estado_Sensor,
        Fecha_Hora
    FROM 
        Registro_Temperatura
    WHERE 
        Estado_Sensor = 1;