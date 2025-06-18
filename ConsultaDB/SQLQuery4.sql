SELECT 
    RegistroActivos.CodInterno,
    RegistroActivos.Serial,
	RegistroActivos.Marca,
    Marcas.Marca AS nombreMarca,
	RegistroActivos.FechaCompra,
	RegistroActivos.FechaRegistro

FROM 
    RegistroActivos
JOIN 
    Marcas ON RegistroActivos.Marca = marcas.id;