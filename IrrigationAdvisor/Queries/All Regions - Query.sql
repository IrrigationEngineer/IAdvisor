/****** Script for Select Region  ******/
SELECT  r.[RegionId] As 'Id'
      ,r.[Name] As 'Nombre'
      ,p.Latitude As 'Latitud'
      ,p.Longitude As 'Longitud'
      ,p.Name As 'Nombre Posicion'
      ,c.Name As 'Pais'
  FROM [IrrigationAdvisor].[dbo].[Region] r
  INNER JOIN [IrrigationAdvisor].[dbo].[Position] p
  ON p.PositionId = r.PositionId
  INNER JOIN [IrrigationAdvisor].[dbo].[Country] c
  ON c.CountryId = r.Country_CountryId
  
  /*
  Select *
  From [IrrigationAdvisor].[dbo].[Position]
  
  Select *
  From [IrrigationAdvisor].[dbo].[Country]
  */