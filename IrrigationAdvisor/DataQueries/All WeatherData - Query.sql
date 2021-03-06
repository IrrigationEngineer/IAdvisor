/****** Script for SelectTopNRows command from SSMS  ******/
SELECT 
	  WS.Name  AS 'Estacion'
	  ,Case WS.StationType
	  when 1 then 'INIA'
	  when 2 then 'WeatherLink'
	  else 'NoWebInformation' end  AS 'Tipo'
	  ,WS.WebAddress AS 'Web'
	  ,WS.UpdateTime  AS 'Ultima actualizacion'
	  ,WD.[Date] AS 'Fecha'
      ,WD.[Temperature] AS 'Temperatura'
      ,WD.[TemperatureMax] AS 'Max Temp'
      ,WD.[TemperatureMin] AS 'Min Temp'
      ,WD.[TemperatureDewPoint] AS 'Temp Rocio'
      ,WD.[RainDay] AS 'Lluvia'
      ,WD.[RainStorm] AS 'Lluvia Tormenta'
      ,WD.[RainMonth] AS 'Lluvia Mes'
      ,WD.[RainYear] AS 'Lluvia Anio'
      ,WD.[Evapotranspiration] AS 'Evapotranspiracion'
      ,WD.[EvapotranspirationMonth] AS 'ET Mes'
      ,WD.[EvapotranspirationYear] AS 'ET Anio'
      ,WD.[Humidity] AS 'Humedad'
      ,WD.[HumidityMax] AS 'Max Hum'
      ,WD.[HumidityMin] AS 'Min Hum'
      ,WD.[Barometer] AS 'Presion'
      ,WD.[BarometerMax] AS 'Max Pre'
      ,WD.[BarometerMin] AS 'Min Pre'
      ,WD.[SolarRadiation] AS 'Radiacion Solar'
      ,WD.[UVRadiation] AS 'Radiacion UV'
      ,WD.[WeatherDataType] AS 'Tipo WD'
      ,WD.[Observations] AS 'Observaciones'
      ,WD.[WeatherDataId] AS 'WD Id'
      ,WD.[WeatherStationId] AS 'WS Id'
      
  FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherData] WD
  INNER JOIN [IrrigationAdvisor-DEMO].[dbo].[WeatherStation] WS
	ON WD.WeatherStationId = WS.WeatherStationId
  WHERE WD.Date >= '2016-09-01'  
  ORDER BY WD.Date DESC, WS.WeatherDataType, WD.WeatherStationId
