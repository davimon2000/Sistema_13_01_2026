SELECT
	Mantenimiento.Id,
	Mantenimiento.InventarioId,
	RegistroActivos.CodInterno AS Activo,
	Mantenimiento.FechaIngresoMtto,
	Mantenimiento.TipoFalla,
	Mantenimiento.ObsIngreso,
	Mantenimiento.FechaSalidaMtto,
	Mantenimiento.EstadoSalida,
	Mantenimiento.ObsSalida,
	Mantenimiento.TecnicoId

FROM
	Mantenimiento
JOIN
	RegistroActivos ON Mantenimiento.InventarioId = RegistroActivos.Id;