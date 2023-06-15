DROP DATABASE IF EXISTS poli;
CREATE DATABASE IF NOT EXISTS poli;
USE poli;
/*------Consulta Inteligente------------------*/
DROP TABLE IF EXISTS tbl_consultainteligente;
CREATE TABLE IF NOT EXISTS tbl_consultainteligente (
	nombre_consulta varchar(50) not null,
    tabla_consulta varchar(50) not null,
    campos_consultas varchar(50) not null,
    alias_consultas varchar(50) not null,
    cadena_consultas varchar(80) not null,
    PkId INT NOT NULL,
    PRIMARY KEY (PkId)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_consultainteligente1; 
CREATE TABLE IF NOT EXISTS tbl_consultainteligente1 (
 operador_consulta varchar(50) not null,
    campos_consulta varchar(50) not null,
    valor_consultas varchar(50) not null,
    PkId INT NOT NULL,   
    metodo varchar(50) not null,
    PRIMARY KEY (PkId)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_consultainteligente2;
CREATE TABLE IF NOT EXISTS tbl_consultainteligente2 (
    PkId INT NOT NULL,
    ordenar_consulta varchar(50) not null,
    campo_consulta varchar(50) not null,    
    metodo varchar(50) not null,
    PRIMARY KEY (PkId)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

/*---------Reporteria----------*/

CREATE TABLE tbl_regreporteria (
  idregistro int NOT NULL AUTO_INCREMENT,
  ruta varchar(500) NOT NULL,
  nombre_archivo varchar(45) NOT NULL,
  aplicacion varchar(45) NOT NULL,
  estado varchar(45) NOT NULL,
  PRIMARY KEY (idregistro)
) ENGINE=InnoDB;

/*-----------Seguridad-----------*/

DROP TABLE IF EXISTS tbl_modulos;
CREATE TABLE IF NOT EXISTS tbl_modulos (
	pk_id_modulos INT NOT NULL,
    nombre_modulo VARCHAR(50) NOT NULL,
    descripcion_modulo VARCHAR(150) NOT NULL,
    estado_modulo TINYINT DEFAULT 0,
    primary key (pk_id_modulos)
);

DROP TABLE IF EXISTS tbl_aplicaciones;
CREATE TABLE IF NOT EXISTS tbl_aplicaciones (
	pk_id_aplicacion INT NOT NULL,
    nombre_aplicacion VARCHAR(50) NOT NULL,
    descripcion_aplicacion VARCHAR(150) NOT NULL,
    estado_aplicacion TINYINT DEFAULT 0,
    primary key (pk_id_aplicacion)
);

DROP TABLE IF EXISTS tbl_AsignacionModuloAplicacion;
CREATE TABLE IF NOT EXISTS tbl_AsignacionModuloAplicacion (
  fk_id_modulos INT NOT NULL,
  fk_id_aplicacion INT NOT NULL, 
  PRIMARY KEY (fk_id_modulos,fk_id_aplicacion ),
  FOREIGN KEY (fk_id_modulos) REFERENCES tbl_modulos (pk_id_modulos),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_usuarios;
CREATE TABLE IF NOT EXISTS tbl_usuarios (
  pk_id_usuario INT AUTO_INCREMENT NOT NULL,
  nombre_usuario VARCHAR(50) NOT NULL,
  apellido_usuario VARCHAR(50) NOT NULL,
  username_usuario VARCHAR(20) NOT NULL,
  password_usuario VARCHAR(100) NOT NULL,
  email_usuario VARCHAR(50) NOT NULL,
  estado_usuario TINYINT DEFAULT 0 NOT NULL,
  pregunta varchar(50) not null,
  respuesta varchar(50) not null,
  PRIMARY KEY (pk_id_usuario)
);

DROP TABLE IF EXISTS tbl_perfiles;
CREATE TABLE IF NOT EXISTS tbl_perfiles (
	pk_id_perfil INT AUTO_INCREMENT NOT NULL,
    nombre_perfil VARCHAR(50) NOT NULL,
    descripcion_perfil VARCHAR(150) NOT NULL,
    estado_perfil TINYINT DEFAULT 0,
    primary key (pk_id_perfil)
);

DROP TABLE IF EXISTS tbl_permisosAplicacionesUsuario;
CREATE TABLE IF NOT EXISTS tbl_permisosAplicacionesUsuario (
  fk_id_aplicacion INT NOT NULL, 
  fk_id_usuario INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (fk_id_aplicacion,fk_id_usuario),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion),
  FOREIGN KEY (fk_id_usuario) REFERENCES tbl_usuarios (pk_id_usuario)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_permisosAplicacionPerfil;
CREATE TABLE IF NOT EXISTS tbl_permisosAplicacionPerfil (
  fk_id_perfil INT NOT NULL, 
  fk_id_aplicacion INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (fk_id_perfil,fk_id_aplicacion),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion),
  FOREIGN KEY (fk_id_perfil) REFERENCES tbl_perfiles (pk_id_perfil)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_asignacionesPerfilsUsuario;
CREATE TABLE IF NOT EXISTS tbl_asignacionesPerfilsUsuario (
  fk_id_usuario INT NOT NULL, 
  fk_id_perfil INT NOT NULL,
  PRIMARY KEY (fk_id_usuario,fk_id_perfil ),
  FOREIGN KEY (fk_id_usuario) REFERENCES tbl_usuarios (pk_id_usuario),
  FOREIGN KEY (fk_id_perfil) REFERENCES tbl_perfiles (pk_id_perfil)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_bitacoraDeEventos;
CREATE TABLE IF NOT EXISTS tbl_bitacoraDeEventos (
  pk_id_bitacora INT AUTO_INCREMENT NOT NULL,
  fk_id_usuario INT NOT NULL,
  fk_id_aplicacion INT NOT NULL,
  fecha_bitacora DATE NOT NULL,
  hora_bitacora TIME NOT NULL,
  host_bitacora VARCHAR(45) NOT NULL,
  ip_bitacora VARCHAR(100) NOT NULL,
  accion_bitacora VARCHAR(50) NOT NULL,
  PRIMARY KEY (pk_id_bitacora),
  FOREIGN KEY (fk_id_usuario) REFERENCES tbl_usuarios (pk_id_usuario),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;


-- vistas Seguridad------------------------------------------------------------------------
CREATE 
VIEW poli.vista_aplicacion_perfil AS 
    SELECT 
        b.fk_id_perfil AS ID,
        a.nombre_perfil AS Perfil,
        b.fk_id_aplicacion AS Aplicacion,
        b.guardar_permiso AS Insertar,
        b.modificar_permiso AS Modificar,
        b.eliminar_permiso AS Eliminar,
        b.buscar_permiso AS Buscar,
        b.imprimir_permiso AS Reporte
    FROM
        (poli.tbl_permisosaplicacionperfil b
        JOIN poli.tbl_perfiles a ON ((a.pk_id_perfil = b.fk_id_perfil)));
        
CREATE 
VIEW poli.vista_aplicacionusuario AS
    SELECT 
        b.fk_id_aplicacion AS Aplicacion,
        b.fk_id_usuario AS ID,
        a.nombre_usuario AS Usuario,
        b.guardar_permiso AS Insertar,
        b.modificar_permiso AS Editar,
        b.eliminar_permiso AS Eliminar,
        b.buscar_permiso AS Buscar,
        b.imprimir_permiso AS Reporte
    FROM
        (poli.tbl_permisosaplicacionesusuario b
        JOIN poli.tbl_usuarios a ON ((a.pk_id_usuario = b.fk_id_usuario)));
        
CREATE 
VIEW poli.vista_modulo_aplicacion AS
    SELECT 
        b.fk_id_modulos AS ID,
        a.nombre_modulo AS Modulo,
        b.fk_id_aplicacion AS Aplicacion,
        c.nombre_aplicacion AS Nombre,
        c.descripcion_aplicacion AS Descripcion
    FROM
        ((poli.tbl_asignacionmoduloaplicacion b
        JOIN poli.tbl_modulos a ON ((a.pk_id_modulos = b.fk_id_modulos)))
        JOIN poli.tbl_aplicaciones c ON ((c.pk_id_aplicacion = b.fk_id_aplicacion)));
        
CREATE VIEW poli.vista_perfil_usuario AS
    SELECT 
        b.fk_id_usuario AS ID,
        a.nombre_usuario AS Usuario,
        a.username_usuario AS nickName,
        b.fk_id_perfil AS perfil,
        c.nombre_perfil AS Nombre
    FROM
        ((poli.tbl_asignacionesperfilsusuario b
        JOIN poli.tbl_usuarios a ON ((a.pk_id_usuario = b.fk_id_usuario)))
        JOIN poli.tbl_perfiles c ON ((c.pk_id_perfil = b.fk_id_perfil)));
        
        

CREATE TABLE `campeonato` (
  `ID_CAMPEONATO` int(11) NOT NULL,
  `NOMBRE_CAMPEONATO` varchar(60) DEFAULT NULL,
  `CANTIDAD_EQUIPOS` int(11) DEFAULT NULL,
  `ID_SEDE_POLI_FK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


CREATE TABLE `detalle_partido` (
  `ID_PARTIDO` int(11) NOT NULL,
  `ID_CAMPEONATO_FK` int(11) NOT NULL,
  `FECHA_PARTIDO` datetime DEFAULT NULL,
  `ID_LOCAL` int(11) NOT NULL,
  `ID_VISITANTE` int(11) NOT NULL,
  `MARCADOR` varchar(9) DEFAULT NULL,
  `ID_MEJOR_JUGADOR_FK` int(11) NOT NULL,
  `FALTAS` varchar(45) DEFAULT NULL,
  `ID_ESTADO_PARTIDO_FK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


CREATE TABLE `empleado` (
  `ID_EMPLEADO` int(11) NOT NULL,
  `NOMBRE1` varchar(45) DEFAULT NULL,
  `NOMBRE2` varchar(45) DEFAULT NULL,
  `APELLIDO1` varchar(45) DEFAULT NULL,
  `APELLIDO2` varchar(45) DEFAULT NULL,
  `CORREO` varchar(60) DEFAULT NULL,
  `ID_TIPO_PUESTO` int(11) NOT NULL,
  `DIRECCION` varchar(100) DEFAULT NULL,
  `FECHA_NACIMIENTO` date DEFAULT NULL,
  `NIT` varchar(30) DEFAULT NULL,
  `DPI` varchar(20) DEFAULT NULL,
  `ID_USUARIO_FK` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `empleado` (`ID_EMPLEADO`, `NOMBRE1`, `NOMBRE2`, `APELLIDO1`, `APELLIDO2`, `CORREO`, `ID_TIPO_PUESTO`, `DIRECCION`, `FECHA_NACIMIENTO`, `NIT`, `DPI`, `ID_USUARIO_FK`) VALUES
(0, 'Mario', 'Raul', 'Lopez', 'Sierra', 'falso@gmail.com', 0, 'CIUDAD', '0000-00-00', '45874154', '4856214785', 'Trey'),
(1, 'asdq', 'qwesad', 'qwerf', 'asdf', 'falso@gmail.com', 2, 'ciudad', '1997-02-05', '2459741-5', '147854620101', 'A'),
(2, 'Luis', 'Eduardo', 'Lopez', 'Obrador', 'System.Windows.Forms.TextBox, Text: real@gmail.com', 2, 'System.Windows.Forms.TextBox, Text: CIUDAD', '0000-00-00', '2458741-5', '257413250101', 'caster');


CREATE TABLE `entrenador` (
  `ID_ENTRENADOR` int(11) NOT NULL,
  `NOMBRE1` varchar(45) DEFAULT NULL,
  `NOMBRE2` varchar(45) DEFAULT NULL,
  `APELLIDO1` varchar(45) DEFAULT NULL,
  `APELLIDO2` varchar(45) DEFAULT NULL,
  `FECHA_NACIMIENTO` varchar(45) DEFAULT NULL,
  `ID_USUARIO_FK` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;


CREATE TABLE `equipo` (
  `ID_EQUIPO` int(11) NOT NULL,
  `NOMBRE_EQUIPO` varchar(50) DEFAULT NULL,
  `ID_ENTRENADOR_FK` int(11) NOT NULL,
  `ID_TIPO_DEPORTE__FK` int(11) NOT NULL,
  `TORNEOS_GANADOS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;



CREATE TABLE `estado_partido` (
  `ID_ESTADO` int(11) NOT NULL,
  `NOMBRE_ESTADO` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;



CREATE TABLE `jugador` (
  `ID_JUGADOR` int(11) NOT NULL,
  `NOMBRE1` varchar(45) DEFAULT NULL,
  `NOMBRE2` varchar(45) DEFAULT NULL,
  `APELLIDO1` varchar(45) DEFAULT NULL,
  `APELLIDO2` varchar(45) DEFAULT NULL,
  `FECHA_NACIMIENTO` date DEFAULT NULL,
  `ID_EQUIPO_FK` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;



CREATE TABLE `sede_polideportivo` (
  `ID_SEDE` int(11) NOT NULL,
  `NOMBRE_SEDE` varchar(100) DEFAULT NULL,
  `CAPACIDAD` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;



CREATE TABLE `telefono` (
  `ID_TELEFONO` int(11) NOT NULL,
  `ID_EMPLEADO_FK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `telefono` (`ID_TELEFONO`, `ID_EMPLEADO_FK`) VALUES
(24579632, 0),
(24857415, 0),
(0, 2);



CREATE TABLE `tipo_deporte` (
  `ID_TIPO_DEPORTE` int(11) NOT NULL,
  `NOMBRE_DEPORTE` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;



CREATE TABLE `tipo_puesto` (
  `ID_TIPO_PUESTO` int(11) NOT NULL,
  `NOMBRE_PUESTO` varchar(60) DEFAULT NULL,
  `SALARIO` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `tipo_puesto` (`ID_TIPO_PUESTO`, `NOMBRE_PUESTO`, `SALARIO`) VALUES
(0, 'Jefe', 14000),
(1, 'Jefe Ventas', 14587),
(2, 'Jefe Compras', 25147),
(3, 'Gerencia', 25412),
(4, 'Admin', 15478);
        
        
CREATE TABLE `tipo_usuario` (
  `ID_TIPO_USUARIO` int(11) NOT NULL,
  `NOMBRE_TIPO` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `tipo_usuario` (`ID_TIPO_USUARIO`, `NOMBRE_TIPO`) VALUES
(1, 'Administrador'),
(2, 'Entrenador'),
(3, 'Gerencia');
        

CREATE TABLE `usuario` (
  `ID_USUARIO` varchar(50) NOT NULL,
  `PASSWORD` varchar(50) DEFAULT NULL,
  `ID_TIPO_USUARIO_FK` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `usuario` (`ID_USUARIO`, `PASSWORD`, `ID_TIPO_USUARIO_FK`) VALUES
('A', '88', 1),
('caster', '12345', 2),
('Man', '88', 1),
('Tefa21', '100', 3),
('Trey', '3', 3),
('Yisus', '123', 2);       



/*--------------------SEGURIDAD---------------*/
-- -----MODULOS

INSERT INTO `tbl_modulos` VALUES
('1000', 'SEGURIDAD', 'Seguridad', 1),
('2000', 'VENTAS', 'ventas', 1),
('3000', 'COMPRAS', 'compras', 1),
('4000', 'CxC', 'CxC', 1),
('5000', 'CxP', 'CxP', 1)
;

-- -----APLICACIONES
INSERT INTO `tbl_aplicaciones` VALUES
('1000', 'MDI SEGURIDAD', 'PARA SEGURIDAD', '1'),
('1001', 'Mant. Usuario', 'PARA SEGURIDAD', '1'),
('1002', 'Mant. Aplicación', 'PARA SEGURIDAD', '1'),
('1003', 'Mant. Modulo', 'PARA SEGURIDAD', '1'),
('1004', 'Mant. Perfil', 'PARA SEGURIDAD', '1'),
('1101', 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', '1'),
('1102', 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', '1'),
('1103', 'Asign. Perfil Usuario', 'PARA SEGURIDAD', '1'),
('1201', 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', '1'),
('1301', 'Pcs. BITACORA', 'PARA SEGURIDAD', '1'),
('2000', 'MDI VENTAS', 'PARA VENTAS', '1'),
('2001', 'Mant. Vendedores', 'PARA VENTAS', '1'),
('2002', 'Mant. Politicas', 'PARA VENTAS', '1'),
('2003', 'Mant. Cotizaciones', 'PARA VENTAS', '1'),
('2004', 'Mant. Pedidos', 'PARA VENTAS', '1'),
('2101', 'Pcs. Clientes', 'PARA VENTAS', '1'),
('2102', 'Pcs. Facturas', 'PARA VENTAS', '1'),
('2103', 'Pcs. Devoluciones', 'PARA VENTAS', '1'),
('2104', 'Pcs. Notas de credito', 'PARA VENTAS', '1'),
('2105', 'Pcs. Venta', 'PARA VENTAS', '1'),
('2201', 'Rep. Clientes', 'PARA VENTAS', '1'),
('2202', 'Rep. Facturas', 'PARA VENTAS', '1'),
('2203', 'Rep. Devoluciones', 'PARA VENTAS', '1'),
('2204', 'Rep. Ventas', 'PARA VENTAS', '1'),
('2205', 'Rep. Cotizaciones', 'PARA VENTAS', '1'),
('2206', 'Rep. Pedidos', 'PARA VENTAS', '1'),
('3000', 'MDI COMPRAS', 'PARA COMPRAS', '1'),
('3001', 'Mant. Orden de compra', 'PARA COMPRAS', '1'),
('3101', 'Pcs compras', 'PARA COMPRAS', '1'),
('3102', 'Pcs devoluciones', 'PARA COMPRAS', '1'),
('3103', 'Pcs facturas', 'PARA COMPRAS', '1'),
('3201', 'Rep. compras', 'PARA COMPRAS', '1'),
('3202', 'Rep. devoluciones', 'PARA COMPRAS', '1'),
('3203', 'Rep. facturas', 'PARA COMPRAS', '1'),
('3204', 'Rep. orden de compras', 'PARA COMPRAS', '1'),
('4000', 'MDI CxC', 'PARA CxC', '1'),
('4001', 'Mant. Moneda', 'PARA CxC', '1'),
('4002', 'Mant. Tipo Pago', 'PARA CxC', '1'),
('4003', 'Mant. Concepto por cobrar', 'PARA CxC', '1'),
('4101', 'Pcs. Balance de clientes', 'PARA CxC', '1'),
('4201', 'Rep. Historial de cliente', 'PARA CxC', '1'),
('4202', 'Rep. Moviminetos', 'PARA CxC', '1'),
('5000', 'MDI CxP', 'PARA CxP', '1'),
('5001', 'Mant. Proveedor', 'PARA CxP', '1'),
('5002', 'Mant. Moneda', 'PARA CxP', '1'),
('5003', 'Mant. Tipo Pago', 'PARA CxP', '1'),
('5004', 'Mant. Concepto por Pagar', 'PARA CxP', '1'),
('5101', 'Pcs. Movimineto por pagar', 'PARA CxP', '1'),
('5102', 'Pcs. Balance Saldos', 'PARA CxP', '1'),
('5103', 'Pcs. Ingreso Factura', 'PARA CxP', '1'),
('5201', 'Rep. Movimineto por pagar', 'PARA CxP', '1'),
('5202', 'Rep. Antiguedad de saldos', 'PARA CxP', '1')
;

-- -----USUARIOS
INSERT INTO `tbl_usuarios` VALUES
('1', 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', '1', 'COLOR FAVORITO', 'X9yc1/l1b2A='),
('2', 'seguridad', 'seguridad', 'seguridad', 'X9yc1/l1b2A=', 'seguridad@gmail.com', '1', 'COLOR FAVORITO', 'X9yc1/l1b2A='),
('3', 'ventas', 'ventas', 'ventas', 'X9yc1/l1b2A=', 'ventas@gmail.com', '1', 'COLOR FAVORITO', 'X9yc1/l1b2A='),
('4', 'compras', 'compras', 'compras', 'X9yc1/l1b2A=', 'compras@gmail.com', '1', 'COLOR FAVORITO', 'X9yc1/l1b2A='),
('5', 'cxc', 'cxc', 'cxc', 'X9yc1/l1b2A=', 'cxc@gmail.com', '1', 'COLOR FAVORITO', 'X9yc1/l1b2A='),
('6', 'cxp', 'cxp', 'cxp', 'X9yc1/l1b2A=', 'cxp@gmail.com', '1', 'COLOR FAVORITO', 'X9yc1/l1b2A=')
;

-- -----PERFILES
INSERT INTO `tbl_perfiles` VALUES
('1', 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
('2', 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1),
('3', 'VENTAS', 'contiene todos los permisos de ventas', 1),
('4', 'COMPRAS', 'contiene todos los permisos de compras', 1),
('5', 'CxC', 'contiene todos los permisos de CxC', 1),
('6', 'CxP', 'contiene todos los permisos de CxP', 1)
;

-- -----ASIGNACIÓNES MODULO A APLICACION
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES
('1000', '1000'),
('1000', '1001'),
('1000', '1002'),
('1000', '1003'),
('1000', '1004'),
('1000', '1102'),
('1000', '1103'),
('1000', '1201'),
('1000', '1301'),
('2000', '2000'),
('2000', '2001'),
('2000', '2002'),
('2000', '2003'),
('2000', '2004'),
('2000', '2101'),
('2000', '2102'),
('2000', '2103'),
('2000', '2104'),
('2000', '2105'),
('2000', '2201'),
('2000', '2202'),
('2000', '2203'),
('2000', '2204'),
('2000', '2205'),
('2000', '2206'),
('3000', '3000'),
('3000', '3001'),
('3000', '3101'),
('3000', '3102'),
('3000', '3103'),
('3000', '3201'),
('3000', '3202'),
('3000', '3203'),
('3000', '3204'),
('4000', '4000'),
('4000', '4001'),
('4000', '4002'),
('4000', '4003'),
('4000', '4101'),
('4000', '4201'),
('4000', '4202'),
('5000', '5000'),
('5000', '5001'),
('5000', '5002'),
('5000', '5003'),
('5000', '5004'),
('5000', '5101'),
('5000', '5102'),
('5000', '5103'),
('5000', '5201'),
('5000', '5202')
;

-- -----PERMISOS DE APLICACIONES A PERFILES
INSERT INTO `tbl_permisosAplicacionPerfil` VALUES
('1', '1000', '1', '1', '1', '1', '1'),
('1', '1001', '1', '1', '1', '1', '1'),
('1', '1002', '1', '1', '1', '1', '1'),
('1', '1003', '1', '1', '1', '1', '1'),
('1', '1004', '1', '1', '1', '1', '1'),
('1', '1101', '1', '1', '1', '1', '1'),
('1', '1102', '1', '1', '1', '1', '1'),
('1', '1103', '1', '1', '1', '1', '1'),
('1', '1201', '1', '1', '1', '1', '1'),
('1', '1301', '1', '1', '1', '1', '1'),
('1', '2000', '1', '1', '1', '1', '1'),
('1', '2001', '1', '1', '1', '1', '1'),
('1', '2002', '1', '1', '1', '1', '1'),
('1', '2003', '1', '1', '1', '1', '1'),
('1', '2004', '1', '1', '1', '1', '1'),
('1', '2101', '1', '1', '1', '1', '1'),
('1', '2102', '1', '1', '1', '1', '1'),
('1', '2103', '1', '1', '1', '1', '1'),
('1', '2104', '1', '1', '1', '1', '1'),
('1', '2105', '1', '1', '1', '1', '1'),
('1', '2201', '1', '1', '1', '1', '1'),
('1', '2202', '1', '1', '1', '1', '1'),
('1', '2203', '1', '1', '1', '1', '1'),
('1', '2204', '1', '1', '1', '1', '1'),
('1', '2205', '1', '1', '1', '1', '1'),
('1', '2206', '1', '1', '1', '1', '1'),
('1', '3000', '1', '1', '1', '1', '1'),
('1', '3001', '1', '1', '1', '1', '1'),
('1', '3101', '1', '1', '1', '1', '1'),
('1', '3102', '1', '1', '1', '1', '1'),
('1', '3103', '1', '1', '1', '1', '1'),
('1', '3201', '1', '1', '1', '1', '1'),
('1', '3202', '1', '1', '1', '1', '1'),
('1', '3203', '1', '1', '1', '1', '1'),
('1', '3204', '1', '1', '1', '1', '1'),
('1', '4000', '1', '1', '1', '1', '1'),
('1', '4001', '1', '1', '1', '1', '1'),
('1', '4002', '1', '1', '1', '1', '1'),
('1', '4003', '1', '1', '1', '1', '1'),
('1', '4101', '1', '1', '1', '1', '1'),
('1', '4201', '1', '1', '1', '1', '1'),
('1', '4202', '1', '1', '1', '1', '1'),
('1', '5000', '1', '1', '1', '1', '1'),
('1', '5001', '1', '1', '1', '1', '1'),
('1', '5002', '1', '1', '1', '1', '1'),
('1', '5003', '1', '1', '1', '1', '1'),
('1', '5004', '1', '1', '1', '1', '1'),
('1', '5101', '1', '1', '1', '1', '1'),
('1', '5102', '1', '1', '1', '1', '1'),
('1', '5103', '1', '1', '1', '1', '1'),
('1', '5201', '1', '1', '1', '1', '1'),
('1', '5202', '1', '1', '1', '1', '1'),
('2', '1000', '1', '1', '1', '1', '1'),
('2', '1001', '1', '1', '1', '1', '1'),
('2', '1002', '1', '1', '1', '1', '1'),
('2', '1003', '1', '1', '1', '1', '1'),
('2', '1004', '1', '1', '1', '1', '1'),
('2', '1101', '1', '1', '1', '1', '1'),
('2', '1102', '1', '1', '1', '1', '1'),
('2', '1103', '1', '1', '1', '1', '1'),
('2', '1201', '1', '1', '1', '1', '1'),
('2', '1301', '1', '1', '1', '1', '1'),
('3', '2000', '1', '1', '1', '1', '1'),
('3', '2001', '1', '1', '1', '1', '1'),
('3', '2002', '1', '1', '1', '1', '1'),
('3', '2003', '1', '1', '1', '1', '1'),
('3', '2004', '1', '1', '1', '1', '1'),
('3', '2101', '1', '1', '1', '1', '1'),
('3', '2102', '1', '1', '1', '1', '1'),
('3', '2103', '1', '1', '1', '1', '1'),
('3', '2104', '1', '1', '1', '1', '1'),
('3', '2105', '1', '1', '1', '1', '1'),
('3', '2201', '1', '1', '1', '1', '1'),
('3', '2202', '1', '1', '1', '1', '1'),
('3', '2203', '1', '1', '1', '1', '1'),
('3', '2204', '1', '1', '1', '1', '1'),
('3', '2205', '1', '1', '1', '1', '1'),
('3', '2206', '1', '1', '1', '1', '1'),
('4', '3000', '1', '1', '1', '1', '1'),
('4', '3001', '1', '1', '1', '1', '1'),
('4', '3101', '1', '1', '1', '1', '1'),
('4', '3102', '1', '1', '1', '1', '1'),
('4', '3103', '1', '1', '1', '1', '1'),
('4', '3201', '1', '1', '1', '1', '1'),
('4', '3202', '1', '1', '1', '1', '1'),
('4', '3203', '1', '1', '1', '1', '1'),
('4', '3204', '1', '1', '1', '1', '1'),
('5', '4000', '1', '1', '1', '1', '1'),
('5', '4001', '1', '1', '1', '1', '1'),
('5', '4002', '1', '1', '1', '1', '1'),
('5', '4003', '1', '1', '1', '1', '1'),
('5', '4101', '1', '1', '1', '1', '1'),
('5', '4201', '1', '1', '1', '1', '1'),
('5', '4202', '1', '1', '1', '1', '1'),
('6', '5000', '1', '1', '1', '1', '1'),
('6', '5001', '1', '1', '1', '1', '1'),
('6', '5002', '1', '1', '1', '1', '1'),
('6', '5003', '1', '1', '1', '1', '1'),
('6', '5004', '1', '1', '1', '1', '1'),
('6', '5101', '1', '1', '1', '1', '1'),
('6', '5102', '1', '1', '1', '1', '1'),
('6', '5103', '1', '1', '1', '1', '1'),
('6', '5201', '1', '1', '1', '1', '1'),
('6', '5202', '1', '1', '1', '1', '1')
;

-- -----ASIGNACIÓN DE PERFIL A USUARIO
INSERT INTO `tbl_asignacionesPerfilsUsuario` VALUES
('1', '1'),
('2', '2'),
('3', '3'),
('4', '4'),
('5', '5'),
('6', '6')
; 




DELIMITER ;;
/*drop procedure if exists pa_registro_buscarvalor;*/
CREATE  PROCEDURE `pa_registro_buscarvalor`(
_valorbuscar varchar (45))
BEGIN
select *
from tbl_regreporteria
where nombre_archivo like concat('%',_valorbuscar,'%') || aplicacion like concat('%',_valorbuscar,'%');
END ;;
DELIMITER ;

DELIMITER ;;
CREATE PROCEDURE `pa_registro_eliminarporid`(
_idregistro int)
BEGIN
delete from tbl_regreporteria
where idregistro = _idregistro;
END ;;
DELIMITER ;

DELIMITER ;;
CREATE  PROCEDURE `pa_registro_ver`()
BEGIN
 select *
    from tbl_regreporteria;
END ;;
DELIMITER ;

DELIMITER ;;
CREATE  PROCEDURE `pa_registro_verporid`(
_idregistro int)
BEGIN
 select*
    from tbl_regreporteria
    where idregostrp = _idregistro;
END ;;
DELIMITER ;

DELIMITER ;;
CREATE  PROCEDURE `pa_reporteria_agregareditar`(
_idregistro int,
_ruta varchar(500),
_nombre_archivo varchar(45),
_aplicacion varchar(45),
_estado varchar (45)
)
BEGIN
if _idregistro = 0 then
 insert into tbl_regreporteria (ruta,nombre_archivo,aplicacion,estado)
    values (_ruta,_nombre_archivo,_aplicacion,_estado);
else
 update tbl_regreporteria
    set
  ruta = _ruta,
        nombre_archivo = _nombre_archivo,
        aplicacion = _aplicacion,
        estado = _estado
        where idregistro = _idregistro;
end if;
END ;;
DELIMITER ;

use poli

 