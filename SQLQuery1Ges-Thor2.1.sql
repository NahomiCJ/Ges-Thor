CREATE DATABASE GesThor;
GO
USE GesThor;
GO

CREATE TABLE Administrador (
  Id_Administrador INT IDENTITY PRIMARY KEY,
  Nombre_Administrador VARCHAR(50) NOT NULL,
  Telefono_Administrador VARCHAR(15),
  Correo_Administrador VARCHAR(100) UNIQUE NOT NULL
);
INSERT INTO Administrador (Nombre_Administrador, Correo_Administrador, Telefono_Administrador)
VALUES ('Cesar Moises Rosales Ramirez', 'Cesar.rosales@tecsanpedro.edu.mx', '8711433414');



CREATE TABLE Equipo (
  Id_Equipo INT IDENTITY PRIMARY KEY,
  Nombre_Equipo VARCHAR(50) NOT NULL,
  Cantidad_Equipo INT CHECK (Cantidad_Equipo >= 0), -- No permitir valores negativos
  Estado_Equipo VARCHAR(50) CHECK (Estado_Equipo IN ('Disponible', 'En Mantenimiento', 'Dañado')), -- Ejemplo de restricciones
  Disponibilidad_Equipo BIT NOT NULL DEFAULT 1 -- 1 = Disponible, 0 = No Disponible
);


INSERT INTO Equipo (Nombre_Equipo, Cantidad_Equipo, Estado_Equipo, Disponibilidad_Equipo)  
VALUES  
    ('Cable de audio', 1, 'Disponible', 1),  
	('Cable de audio', 1, 'Disponible', 1),  
	('Cable de audio', 1, 'Disponible', 1),  
    ('HDMI', 1, 'Disponible', 1),  
	('HDMI', 1, 'Disponible', 1),  
	('HDMI', 1, 'Disponible', 1),  
    ('Cable Ethernet', 1, 'Disponible', 1),
    ('Cable Ethernet', 1, 'Disponible', 1),
	 ('Cable Ethernet', 1, 'Disponible', 1),
	 ('Cable Ethernet', 1, 'Disponible', 1);
	 
UPDATE Equipo
SET Nombre_Equipo = 'Cable de audio',
    Cantidad_Equipo = 1,
    Estado_Equipo = 'En Mantenimiento',
    Disponibilidad_Equipo = 0
WHERE Id_Equipo = 2;




CREATE TABLE Usuario (
  Id_Usuario INT IDENTITY PRIMARY KEY,
  Matricula_Clave VARCHAR(20) UNIQUE NOT NULL,
  Carrera_Usuario VARCHAR(50),
  Correo_Usuario VARCHAR(100) UNIQUE NOT NULL,
  Telefono_Usuario VARCHAR(15)
);

CREATE TABLE Prestamo (
  Id_Prestamo INT IDENTITY PRIMARY KEY,
  Id_Usuario INT NOT NULL,
  Id_Equipo INT NOT NULL,
  Fecha_Prestamo DATETIME DEFAULT GETDATE(), -- Fecha actual por defecto
  Fecha_Devolucion DATETIME NOT NULL,
  Fecha_DevolucionReal DATETIME NULL, -- Puede ser NULL si aún no se ha devuelto
  Status_Prestamo VARCHAR(50) CHECK (Status_Prestamo IN ('Activo', 'Devuelto', 'Retrasado')),

  CONSTRAINT FK_Prestamo_Usuario FOREIGN KEY (Id_Usuario) REFERENCES Usuario(Id_Usuario),
  CONSTRAINT FK_Prestamo_Equipo FOREIGN KEY (Id_Equipo) REFERENCES Equipo(Id_Equipo)
);


select * from Prestamo	

select * from Usuario

select * from Equipo  
select * from Administrador
--DELETE FROM Equipo WHERE Id_Equipo in (1,2,3,4)

UPDATE Equipo 
set Cantidad_Equipo=3
WHERE Id_Equipo =1

select * from Equipo where Estado_Equipo = 'Disponible'

select * from Administrador 


-----------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE OR ALTER VIEW vwInventario AS
	SELECT
		Id_Equipo AS ID,
		Nombre_Equipo AS Nombre, 
		Cantidad_Equipo AS Cantidad,
		Estado_Equipo AS Estado,
		Disponibilidad_Equipo AS Disponibilidad
	FROM	
		Equipo;


USE GesThor

CREATE OR ALTER PROCEDURE spi_AgEquipo 
	@Nombre VARCHAR(50),
	@Cantidad INT,
	@Estado VARCHAR(50),
	@Disponibilidad BIT
AS
BEGIN
	IF @Cantidad < 0
	BEGIN
		RAISERROR ('La cantidad de equipo no puede ser negativa', 16,1);
		RETURN;
	END
	IF @Estado NOT IN ('Disponible', 'En Mantenimiento', 'Dañado')
  BEGIN
    RAISERROR('El estado del equipo no es válido.', 16, 1);
    RETURN;
  END

  -- Inserción de datos
  INSERT INTO Equipo (Nombre_Equipo, Cantidad_Equipo, Estado_Equipo, Disponibilidad_Equipo)
  VALUES (@Nombre, @Cantidad, @Estado, @Disponibilidad);
END;




	
/*	EXEC spi_AgEquipo
  @Nombre = 'Laptop',
  @Cantidad = 10,
  @Estado = 'Disponible',
  @Disponibilidad = 1;

  delete from Equipo where Id_Equipo = 11
  */
  

CREATE OR ALTER PROCEDURE spu_ModEquipo 
	@Id INT,
	@Nombre VARCHAR(50),
	@Cantidad INT,
	@Estado VARCHAR(50),
	@Disponibilidad BIT
AS
BEGIN
	BEGIN TRAN
	BEGIN TRY
		UPDATE dbo.Equipo
			SET Nombre_Equipo = @Nombre,
				Cantidad_Equipo = @Cantidad,
				Estado_Equipo = @Estado,
				Disponibilidad_Equipo = @Disponibilidad
		WHERE Id_Equipo = @Id
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
END;




USE GesThor

CREATE OR ALTER PROCEDURE spiAgPrestamo
    @Id_U INT,
    @Id_E INT,
    @Fecha_Dev DATETIME,
    @Status_Prestamo VARCHAR(50),
	@Fecha_DevReal DATETIME = NULL -- Parámetro opcional
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar el préstamo
    INSERT INTO Prestamo (
        Id_Usuario,
        Id_Equipo,
        Fecha_Devolucion,
        Fecha_DevolucionReal,
        Status_Prestamo
    )
    VALUES (
        @Id_U,
        @Id_E,
        @Fecha_Dev,
        @Fecha_DevReal,
        @Status_Prestamo
    );

    -- Actualizar la disponibilidad del equipo
    UPDATE Equipo
    SET Disponibilidad_Equipo = 0
    WHERE Id_Equipo = @Id_E;
END;


CREATE OR ALTER PROCEDURE sprConsultarIdUsuario
@Matricula VARCHAR (20)
AS
BEGIN
	SELECT 
	Id_Usuario
    FROM Usuario WITH(nolock)
	WHERE Matricula_Clave = @Matricula
END
exec sprConsultarIdUsuario '221000101'

---------------------------------------------------------------------------------------------------------------------------------------
select * from Prestamo;

CREATE OR ALTER PROCEDURE ObtenerPrestamosPorMatricula
    @Matricula NVARCHAR(50) = NULL
AS
BEGIN
    SELECT 
        P.Id_Prestamo,
        U.Matricula_Clave,
        P.Fecha_Prestamo,
        P.Fecha_Devolucion,
        P.Fecha_DevolucionReal,
        P.Status_Prestamo
    FROM Prestamo P
    INNER JOIN Usuario U ON P.Id_Usuario = U.Id_Usuario
    INNER JOIN Equipo E ON P.Id_Equipo = E.Id_Equipo
    WHERE U.Matricula_Clave = @Matricula;
END;


select * from Usuario



Insert into Usuario (Matricula_Clave,Carrera_Usuario,Correo_Usuario,Telefono_Usuario) values ('221000139','ISIC','SaulHR24@hotmail.com','872161466'),
('221000101','ISIC','lynda.castillo.22isc@tecsanpedro.edu.mx','8721083999')
>>>>>>> 9ab9c7e357b802291215d22a75ddd3d1ce91764c
