Use [JoyeríaDALA.Data];

delete from Usuario;
delete from TipoProducto;
delete from SubtiposProducto;
delete from MarcasTipo;
delete from Material;
delete from tamanos;
delete from Producto;
delete from Preferencia;

DBCC CHECKIDENT ('Usuario', RESEED, 0);
DBCC CHECKIDENT ('TipoProducto', RESEED, 0);
DBCC CHECKIDENT ('SubtiposProducto', RESEED, 0);
DBCC CHECKIDENT ('MarcasTipo', RESEED, 0);
DBCC CHECKIDENT ('Material', RESEED, 0);
DBCC CHECKIDENT ('tamanos', RESEED, 0);
DBCC CHECKIDENT ('Producto', RESEED, 0);
DBCC CHECKIDENT ('Preferencia', RESEED, 0);

DBCC CHECKIDENT ('Usuario', RESEED, 0);
DBCC CHECKIDENT ('TipoProducto', RESEED, 0);
DBCC CHECKIDENT ('SubtiposProducto', RESEED, 0);
DBCC CHECKIDENT ('MarcasTipo', RESEED, 0);
DBCC CHECKIDENT ('Material', RESEED, 0);
DBCC CHECKIDENT ('tamanos', RESEED, 0);
DBCC CHECKIDENT ('Producto', RESEED, 0);
DBCC CHECKIDENT ('Preferencia', RESEED, 0);

INSERT INTO Usuario (nombre,username, password, ApiKey, TipoUsuario)
VALUES ('Administrador','admin', '', 'apikey123', 'Administrador');
INSERT INTO Usuario (nombre,username, password, ApiKey, TipoUsuario)
VALUES ('Guillermo','guiller', '', 'apikey123', 'Administrador');
INSERT INTO Usuario (nombre,username, password, ApiKey, TipoUsuario)
VALUES ('Usuario','user', '', 'apikey123', 'Usuario');

INSERT INTO TipoProducto (Tipo)
VALUES ('Anillo');
INSERT INTO TipoProducto (Tipo)
VALUES ('Pulsera');
INSERT INTO TipoProducto (Tipo)
VALUES ('Colgante');
INSERT INTO TipoProducto (Tipo)
VALUES ('Reloj');
INSERT INTO TipoProducto (Tipo)
VALUES ('Pendientes');
INSERT INTO TipoProducto (Tipo)
VALUES ('Gemelos');
INSERT INTO TipoProducto (Tipo)
VALUES ('Accesorio');
INSERT INTO TipoProducto (Tipo)
VALUES ('Decoración');
INSERT INTO TipoProducto (Tipo)
VALUES ('Trofeos');
INSERT INTO TipoProducto (Tipo)
VALUES ('Regalos');

INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (1, 'Sortija');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (1, 'Sellos');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (1, 'Diamantes');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (1, 'Personalizado');

INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (2, 'Bolas');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (2, 'Cordón');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (2, 'Brazalete');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (2, 'Chapas');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (2, 'Esclavas');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (2, 'Perlas');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (2, 'Cadena');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (2, 'Diamantes');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (2, 'Personalizado');

INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (3, 'Collar');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (3, 'Cadena');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (3, 'Cordel');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (3, 'Perlas');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (3, 'Rosarios');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (3, 'Diamantes');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (3, 'Personalizado');

INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (4, 'Reloj de Pulsera');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (4, 'Smartwatch');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (4, 'Reloj de pared');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (4, 'Despertadores');

INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (5, 'Perlas');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (5, 'Con piedras');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (5, 'Con esmalte');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (5, 'Largos');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (5, 'Aros');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (5, 'Piercing');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (5, 'Lisos');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (5, 'Diamantes');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (5, 'Personalizado');

INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (6, 'Lisos');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (6, 'Con dibujo');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (6, 'Personalizado');

INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (7, 'Llaveros');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (7, 'Broches');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (7, 'Boligrafos');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (7, 'Auriculares');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (7, 'Plumas');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (7, 'Mecheros');

INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (8, 'Jarrones');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (8, 'Bomboneras');

INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (9, 'Trofeo');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (9, 'Medalla');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (9, 'Placa');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (9, 'Figura');

INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (10, 'Portafotos');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (10, 'Placas');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (10, 'Conchas bautismales');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (10, 'Joyeros');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (10, 'Cubiertos');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (10, 'Copas');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (10, 'Figuras');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (10, 'Chupetes');
INSERT INTO SubtiposProducto (IdTipo, Subtipo)
VALUES (10, 'Albumes');

INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (1, 'Tiffany & Co.');
INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (1, 'Cartier');
INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (1, 'Bvlgari');

INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (2, 'Pandora');
INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (2, 'David Yurman');
INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (2, 'Chopard');

INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (3, 'Harry Winston');
INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (3, 'Van Cleef & Arpels');
INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (3, 'Boucheron');

INSERT INTO Material(material)
VALUES	('Oro');
INSERT INTO Material(material)
VALUES	('Plata');
INSERT INTO Material(material)
VALUES	('Acero');
INSERT INTO Material(material)
VALUES	('Cuero');
INSERT INTO Material(material)
VALUES	('Cristal');
INSERT INTO Material(material)
VALUES	('Otros');

INSERT INTO tamanos(tamano)
VALUES	('Pequeño');
INSERT INTO tamanos(tamano)
VALUES	('Mediano');
INSERT INTO tamanos(tamano)
VALUES	('Grande');
INSERT INTO tamanos(tamano)
VALUES	('Otro');

INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (4, 'Rolex');
INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (4, 'Omega');
INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (4, 'TAG Heuer');

INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (5, 'Chopard');
INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (5, 'Harry Winston');
INSERT INTO MarcasTipo (IdTipo, NombreMarca)
VALUES (5, 'Van Cleef & Arpels');


INSERT INTO Producto (tipoProducto, subtipo, Nombre, Precio, Descripcion, Stock, material, tamano, Marca, activo)
VALUES ('Anillo', 'Alianza', 'Anillo de Diamantes', 1500.00, 'Anillo de diamantes con montura de oro blanco', 10, 'Oro', 'Pequeño', 'Tiffany & Co.',1);
INSERT INTO Producto (tipoProducto, subtipo, Nombre, Precio, Descripcion, Stock, material, tamano, Marca,activo)
VALUES ('Pulsera','Cadena' , 'Pulsera de Oro', 800.00, 'Pulsera de oro con diseño clásico', 20, 'Oro', 'Mediano', 'Pandora',1);
INSERT INTO Producto (tipoProducto, subtipo, Nombre, Precio, Descripcion, Stock, material, tamano, Marca,activo)
VALUES ('Colgante', 'Cadena', 'Colgante de Perlas', 300.00, 'Colgante de perlas con cadena de plata', 15, 'Plata', 'Grande', 'Harry Winston',1);

INSERT INTO Preferencia(nombreAjuste,valor,otrosDatos)
VALUES ('nombreNegocio','Joyería DALA','');
INSERT INTO Preferencia(nombreAjuste,valor,otrosDatos)
VALUES ('direccionNegocio','Av. Besaya, 28, 39300 Torrelavega, Cantabria','');
INSERT INTO Preferencia(nombreAjuste,valor,otrosDatos)
VALUES ('tlfNegocio','942 085 326','');
INSERT INTO Preferencia(nombreAjuste,valor,otrosDatos)
VALUES ('NifPropietario','12345678A','');