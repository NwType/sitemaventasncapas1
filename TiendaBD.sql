
CREATE TABLE Persona (
    IDPersona INT IDENTITY (1,1) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Apellidos NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20) NOT NULL,
    CI NVARCHAR(20) NOT NULL,
    Correo NVARCHAR(100) NOT NULL,
    Estado NVARCHAR(20) NOT NULL,
    PRIMARY KEY (IDPersona)
);

CREATE TABLE TipoProducto (
    IDTipoProducto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Estado NVARCHAR(20) NOT NULL
);

CREATE TABLE Marca (
    IDMarca INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Estado NVARCHAR(20) NOT NULL
);
CREATE TABLE Producto (
    IDProducto INT IDENTITY(1,1) NOT NULL,
    IDTipoProducto INT NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    CodigoBarras NVARCHAR(50) NOT NULL,
    IDMarca INT NOT NULL,
    Unidad NVARCHAR(20) NOT NULL,
    Descripcion NVARCHAR(MAX),
    Estado NVARCHAR(20) NOT NULL,
    FOREIGN KEY (IDTipoProducto) REFERENCES TipoProducto(IDTipoProducto),
    FOREIGN KEY (IDMarca) REFERENCES Marca(IDMarca),
    PRIMARY KEY(IDProducto)
);

CREATE TABLE Rol (
    IDRol INT IDENTITY(1,1) NOT NULL,
    Nombre NVARCHAR(50) NOT NULL,
    Estado NVARCHAR(20) NOT NULL,
    PRIMARY KEY(IDRol)
);

CREATE TABLE UsuarioLogin (
    IDUsuario INT IDENTITY (1,1) NOT NULL,
    IDPersona INT NOT NULL,
    NombreUsuario NVARCHAR(50) NOT NULL,
    Contrasenia NVARCHAR(50) NOT NULL,
    FechaRegistro DATETIME,
    FOREIGN KEY (IDPersona) REFERENCES Persona(IDPersona),
    PRIMARY KEY (IDUsuario)
);

CREATE TABLE Cliente (
    IDCliente INT IDENTITY (1,1) NOT NULL,
    IDPersona INT NOT NULL,
    TipoCliente NVARCHAR(50) NOT NULL,
    CodigoCliente NVARCHAR(50) NOT NULL,
    Estado NVARCHAR(20) NOT NULL,
    FOREIGN KEY (IDPersona) REFERENCES Persona(IDPersona),
    PRIMARY KEY (IDCliente)
);

CREATE TABLE Venta (
    IDVenta INT IDENTITY (1,1) NOT NULL,
    IDCliente INT NOT NULL,
    IDVendedor INT NOT NULL,
    Fecha DATETIME,
    Total DECIMAL(18, 2),
    Estado NVARCHAR(20),
    FOREIGN KEY (IDCliente) REFERENCES Cliente(IDCliente),
    FOREIGN KEY (IDVendedor) REFERENCES UsuarioLogin(IDUsuario),
    PRIMARY KEY(IDVenta)
);

CREATE TABLE DetalleVenta (
    IDDetalleVenta INT IDENTITY (1,1) PRIMARY KEY,
    IDVenta INT NOT NULL,
    IDProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioVenta DECIMAL(18, 2) NOT NULL,
    Subtotal DECIMAL(18, 2) NOT NULL,
    Estado NVARCHAR(20) NOT NULL,
    FOREIGN KEY (IDVenta) REFERENCES Venta(IDVenta),
    FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto)
);
CREATE TABLE Proveedor (
    IDProveedor INT IDENTITY(1,1) NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20) NOT NULL,
    Direccion NVARCHAR(200) NOT NULL,
    Estado NVARCHAR(20) NOT NULL,
    PRIMARY KEY (IDProveedor)
);
CREATE TABLE Provee (
    IDProvee INT IDENTITY(1,1) PRIMARY KEY,
    IDProducto INT NOT NULL,
    IDProveedor INT NOT NULL,
    Fecha DATETIME NOT NULL,
    Precio DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto),
    FOREIGN KEY (IDProveedor) REFERENCES Proveedor(IDProveedor)
);
CREATE TABLE Ingreso (
    IDIngreso INT IDENTITY(1,1) NOT NULL,
    IDProveedor INT NOT NULL,
    FechaIngreso DATETIME NOT NULL,
    Total DECIMAL(18, 2) NOT NULL,
    Estado NVARCHAR(20) NOT NULL,
    PRIMARY KEY (IDIngreso),
    FOREIGN KEY (IDProveedor) REFERENCES Proveedor(IDProveedor)
);

CREATE TABLE DetalleIngreso (
    IDDetalleIngreso INT IDENTITY(1,1) NOT NULL,
    IDProducto INT NOT NULL,
    IDIngreso INT NOT NULL,
    FechaVencimiento DATETIME NOT NULL,
    Cantidad INT NOT NULL,
    PrecioCosto DECIMAL(18, 2) NOT NULL,
    PrecioVenta DECIMAL(18, 2) NOT NULL,
    Subtotal DECIMAL(18, 2) NOT NULL,
    Estado NVARCHAR(20) NOT NULL,
    PRIMARY KEY (IDDetalleIngreso),
    FOREIGN KEY (IDProducto) REFERENCES Producto(IDProducto),
    FOREIGN KEY (IDIngreso) REFERENCES Ingreso(IDIngreso)
);
