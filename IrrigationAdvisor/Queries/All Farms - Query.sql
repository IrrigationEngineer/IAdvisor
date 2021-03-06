/****** Script for Select Farm  ******/
SELECT f.[FarmId] As 'Id'
      ,f.[Name] As 'Nombre'
      ,f.[Company]
      ,f.[Address]
      ,f.[Phone]
      ,p.Latitude As 'Latitud'
      ,p.Longitude As 'Longitud'
      ,p.Name As 'Nombre Posicion'
      ,f.[Has]
      ,c.Name As 'Ciudad'
      ,w.Name As 'Estacion Meteorologica'
  FROM [IrrigationAdvisor].[dbo].[Farm] f
  INNER JOIN [IrrigationAdvisor].[dbo].[City] c
  ON c.CityId = f.CityId
  INNER JOIN [IrrigationAdvisor].[dbo].[Position] p
  ON p.PositionId = f.PositionId
  INNER JOIN [IrrigationAdvisor].[dbo].[WeatherStation] w
  ON w.WeatherStationId = f.WeatherStationId
  
  /*
  Select *
  From [IrrigationAdvisor].[dbo].[WeatherStation]
  
  Select *
  From [IrrigationAdvisor].[dbo].[Position]
  
  Select *
  From [IrrigationAdvisor].[dbo].[City]
  */
  
  