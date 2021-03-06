/****** Script for Select Soil  ******/
SELECT s.[SoilId] As 'Id'
      ,s.[Name] As 'Nombre'
      ,s.[Description] As 'Descripcion'
      ,p.Latitude As 'Latitud'
      ,p.Longitude As 'Longitud'
      ,s.[TestDate] As 'Fecha de Visita'
      ,s.[DepthLimit] As 'Limite de Profundidad'
      ,f.Name As 'Establecimiento'
  FROM [IrrigationAdvisor].[dbo].[Soil] s
  INNER JOIN [IrrigationAdvisor].[dbo].[Position] p
  ON p.PositionId = s.PositionId
  INNER JOIN [IrrigationAdvisor].[dbo].[Farm] f
  ON f.FarmId = s.Farm_FarmId
  
  
  /*
  
  Select *
  From [IrrigationAdvisor].[dbo].[Farm]
  
  Select *
  From [IrrigationAdvisor].[dbo].[Position]
  
  */
  
  
  