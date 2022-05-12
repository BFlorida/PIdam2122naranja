CREATE DATABASE myhomy CHARACTER SET UTF8 COLLATE UTF8_GENERAL_CI;
USE myhomy;

CREATE TABLE usuario(
id_usuario INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
nombre_Usu VARCHAR(100) NOT NULL,
apellido_Usu VARCHAR(100) NOT NULL,
correo VARCHAR(100) NOT NULL,
contrasenya VARCHAR(100) NOT NULL,
conectado TINYINT(1) NOT NULL
);



#Insert para usuario (campo id autoincrementativo)
INSERT INTO usuario (nombre_Usu,apellido_Usu,correo,contrasenya,conectado) VALUES ("Paco","Franciscano","Paco@franco.com","1989bna",1);
INSERT INTO usuario (nombre_Usu,apellido_Usu,correo,contrasenya,conectado) VALUES ("Elena","Eleniak","Eleno@franco.com","123456",1);

CREATE TABLE casa(
id_casa INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
nombre_Casa VARCHAR(100) NOT NULL,
fk_usuario INT NOT NULL,
FOREIGN KEY (fk_usuario) REFERENCES usuario(id_usuario)
);

#Insert para casa (campo id autoincrementativo)
INSERT INTO casa (nombre_Casa,fk_usuario) VALUES ("Paco's House 1",1);


CREATE TABLE estancia(
id_estancia INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
nombre_Estan VARCHAR(100) NOT NULL,
fk_casa INT NOT NULL,
FOREIGN KEY (fk_casa) REFERENCES casa(id_casa)
);

#Insert para estancia (campo id de estancia autoincrementativo)
INSERT INTO estancia (nombre_Estan,fk_casa) VALUES ("Cocina",1);
INSERT INTO estancia (nombre_Estan,fk_casa) VALUES ("Salón",2);



CREATE TABLE dispositivos(
id_dispositivos INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
nombre_Dispo VARCHAR(100) NOT NULL,
encendido TINYINT(1) NOT NULL,
consumo_base INT NOT NULL,
fk_estancia INT NOT NULL,
FOREIGN KEY (fk_estancia) REFERENCES estancia(id_estancia)
);

#Insert para dispositivos (campo id de dispositivo autoincrementativo)

INSERT INTO dispositivos (nombre_Dispo,encendido,consumo_base,tipo,func_espe,fk_estancia) VALUES ("Horno",1,2500,1,1,1);






