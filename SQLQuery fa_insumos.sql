CREATE DATABASE fa_insumos;
GO
-- Usar la base de datos "fa_insumos"
USE fa_insumos;
GO

-- Crear la tabla "roles" para almacenar los roles
CREATE TABLE roles (
    IdRol INT PRIMARY KEY IDENTITY(1,1),
    NombreRol VARCHAR(20) NOT NULL
);
GO

-- Insertar registros en la tabla "roles"
INSERT INTO roles (NombreRol) VALUES ('admin');
INSERT INTO roles (NombreRol) VALUES ('usuario');
-- Añade más roles según sea necesario
GO

-- Crear la tabla "usuarios" con la relación a la tabla "roles"
CREATE TABLE usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Legajo INT NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Contraseña VARCHAR(100) NOT NULL,
    IdRol INT NOT NULL,
    CONSTRAINT FK_Usuarios_Roles FOREIGN KEY (IdRol) REFERENCES roles(IdRol)
);
GO

-- Insertar 5 registros en la tabla "usuarios" con datos inventados
INSERT INTO usuarios (Legajo, Nombre, Apellido, Email, Contraseña, IdRol)
VALUES (01, 'José', 'Luis', 'joseluis@gmail.com', 'contrasena1', 1);

INSERT INTO usuarios (Legajo, Nombre, Apellido, Email, Contraseña, IdRol)
VALUES (02, 'María', 'García', 'mariagarcia@gmail.com', 'contrasena2', 2);

INSERT INTO usuarios (Legajo, Nombre, Apellido, Email, Contraseña, IdRol)
VALUES (03, 'Carlos', 'Rodríguez', 'carlosrodriguez@gmail.com', 'contrasena3', 1);

INSERT INTO usuarios (Legajo, Nombre, Apellido, Email, Contraseña, IdRol)
VALUES (04, 'Ana', 'Martínez', 'anamartinez@gmail.com', 'contrasena4', 2);

INSERT INTO usuarios (Legajo, Nombre, Apellido, Email, Contraseña, IdRol)
VALUES (05, 'David', 'López', 'davidlopez@gmail.com', 'contrasena5', 1);
GO
SELECT * FROM USUARIOS;
SELECT * FROM ROLES;
GO
SELECT Id, Legajo, Nombre, Apellido, Email
FROM usuarios
WHERE IdRol = 1; -- El valor 1 representa el rol de "admin"