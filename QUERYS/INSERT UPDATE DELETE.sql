INSERT INTO Logistica.Productos
(IdProducto,NombreProducto,Descripcion,PrecioUnitario)
VALUES
(1,'Pendrive','el pincho',10),
(2,'Teclado','Las Teclas',5),
(3,'Raton','El que se mueve',12);

UPDATE Logistica.Productos
SET
PrecioUnitario=8
Where NombreProducto='raton'

DELETE FROM Logistica.Productos
WHERE NombreProducto='raton'