/****** Script for Select Stage  ******/
SELECT st.[StageId] As 'Id'
      ,st.[Name] As 'Nombre'
      ,st.[ShortName] As 'Nom'
      ,st.[Description] As 'Descripcion'
      ,st.[Order] As 'Orden'
      ,c.Name As 'Cultivo'
  FROM [IrrigationAdvisor].[dbo].[Stage] st
  INNER JOIN [IrrigationAdvisor].[dbo].[Crop] c
  ON st.Crop_CropId = c.CropId
  
  /*
  
  Select c.*, st.Name
  From [IrrigationAdvisor].[dbo].[Crop] c
  INNER JOIN [IrrigationAdvisor].[dbo].[Stage] st
  ON st.Crop_CropId = c.CropId
  
  
  
  */