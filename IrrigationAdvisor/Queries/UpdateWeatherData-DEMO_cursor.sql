

USE [IrrigationAdvisor-DEMO];
GO
SET NOCOUNT ON
DECLARE 
    @WeatherDataId			AS BIGINT, 
    @WeatherStationId		AS BIGINT,
    @Date					AS DATETIME,
    @Temperature			AS FLOAT,
    @TemperatureMax			AS FLOAT,
    @TemperatureMin			AS FLOAT,
    @TemperatureDewPoint	AS FLOAT,
    @Humidity				AS FLOAT,
    @HumidityMax			AS FLOAT,
    @HumidityMin			AS FLOAT,
    @Barometer				AS FLOAT,
    @BarometerMax			AS FLOAT,
    @BarometerMin			AS FLOAT,
    @SolarRadiation			AS FLOAT,
    @UVRadiation			AS FLOAT,
    @RainDay				AS FLOAT,
    @RainStorm				AS FLOAT,
    @RainMonth				AS FLOAT,
    @RainYear				AS FLOAT,
    @Evapotranspiration		AS FLOAT,
    @EvapotranspirationMonth		AS FLOAT,
    @EvapotranspirationYear		AS FLOAT,
    @WeatherDataType		AS INT,
    @Observations			AS NVARCHAR(MAX),
    @WindSpeed				AS FLOAT,
    @WeatherDataInputType	AS INT

DECLARE UpdateWeatherData_cursor CURSOR FOR

    SELECT WD.[WeatherDataId]
      ,WD.[WeatherStationId]
      ,WD.[Date]
      ,WD.[Temperature]
      ,WD.[TemperatureMax]
      ,WD.[TemperatureMin]
      ,WD.[TemperatureDewPoint]
      ,WD.[Humidity]
      ,WD.[HumidityMax]
      ,WD.[HumidityMin]
      ,WD.[Barometer]
      ,WD.[BarometerMax]
      ,WD.[BarometerMin]
      ,WD.[SolarRadiation]
      ,WD.[UVRadiation]
      ,WD.[RainDay]
      ,WD.[RainStorm]
      ,WD.[RainMonth]
      ,WD.[RainYear]
      ,WD.[Evapotranspiration]
      ,WD.[EvapotranspirationMonth]
      ,WD.[EvapotranspirationYear]
      ,WD.[WeatherDataType]
      ,WD.[Observations]
      ,WD.[WindSpeed]
      ,WD.[WeatherDataInputType]
  FROM [IrrigationAdvisor].[dbo].[WeatherData] AS WD
  WHERE wd.Date >= '2016-09-01'
  ORDER BY WD.Date
    --WHERE EXISTS
				--  (SELECT wd2.WeatherDataId, wd2.[Date]
				--  FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherData] wd2
				--  WHERE wd2.WeatherStationId = WD.[WeatherStationId]
				--  AND wd2.Date = WD.[Date]) ;
OPEN UpdateWeatherData_cursor;
FETCH FROM UpdateWeatherData_cursor
INTO @WeatherDataId,@WeatherStationId, @Date, @Temperature,
      @TemperatureMax, @TemperatureMin, @TemperatureDewPoint, 
      @Humidity, @HumidityMax, @HumidityMin, 
      @Barometer, @BarometerMax, @BarometerMin, 
      @SolarRadiation, @UVRadiation, 
      @RainDay, @RainStorm, @RainMonth, @RainYear, 
      @Evapotranspiration, @EvapotranspirationMonth, 
      @EvapotranspirationYear, @WeatherDataType, 
      @Observations, @WindSpeed, @WeatherDataInputType

WHILE (@@FETCH_STATUS = 0)
BEGIN
	
	SELECT
	@WeatherDataId,@WeatherStationId, @Date, @Temperature,
      @TemperatureMax, @TemperatureMin, @TemperatureDewPoint, 
      @Humidity, @HumidityMax, @HumidityMin, 
      @Barometer, @BarometerMax, @BarometerMin, 
      @SolarRadiation, @UVRadiation, 
      @RainDay, @RainStorm, @RainMonth, @RainYear, 
      @Evapotranspiration, @EvapotranspirationMonth, 
      @EvapotranspirationYear, @WeatherDataType, 
      @Observations, @WindSpeed, @WeatherDataInputType
    
    IF((SELECT COUNT(1)
		FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherData] 
		WHERE --WeatherStationId = @WeatherDataId AND
			 WeatherStationId = @WeatherStationId AND
			 DAY(Date) = DAY(@Date) AND
			 MONTH(Date) = MONTH(@Date) AND
			 YEAR(Date) = YEAR(@Date) )>0)
	BEGIN
				SELECT WD.[WeatherDataId]
					  ,WD.[WeatherStationId]
					  ,WD.[Date]
					  ,RTRIM(LTRIM(WD.[Observations])) as obs
					  ,WD.[WindSpeed]
					  ,WD.[WeatherDataInputType]
				  FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherData] AS WD
					WHERE --WeatherStationId = @WeatherDataId AND
						 WeatherStationId = @WeatherStationId AND
						 DAY(Date) = DAY(@Date) AND
						 MONTH(Date) = MONTH(@Date) AND
						 YEAR(Date) = YEAR(@Date)
			
			--UPDATE [IrrigationAdvisor-DEMO].[dbo].[WeatherData] 
			--SET Temperature = @Temperature, TemperatureMax = @TemperatureMax, 
			--  TemperatureMin = @TemperatureMin, TemperatureDewPoint = @TemperatureDewPoint, 
			--  Humidity = @Humidity, HumidityMax = @HumidityMax, HumidityMin = @HumidityMin, 
			--  Barometer = @Barometer, BarometerMax = @BarometerMax, BarometerMin = @BarometerMin, 
			--  SolarRadiation = @SolarRadiation, UVRadiation = @UVRadiation, 
			--  RainDay = @RainDay, RainStorm = @RainStorm, RainMonth = @RainMonth, RainYear = @RainYear, 
			--  Evapotranspiration = @Evapotranspiration, EvapotranspirationMonth = @EvapotranspirationMonth, 
			--  EvapotranspirationYear = @EvapotranspirationYear, WeatherDataType = @WeatherDataType, 
			--  Observations = @Observations, WindSpeed = @WindSpeed, WeatherDataInputType = @WeatherDataInputType
			--  WHERE --WeatherStationId = @WeatherDataId AND
			--	 WeatherStationId = @WeatherStationId AND
			--	 DAY(Date) = DAY(@Date) AND
			--	 MONTH(Date) = MONTH(@Date) AND
			--	 YEAR(Date) = YEAR(@Date) 
	END
	ELSE
	BEGIN
		
		SELECT @WeatherDataId = (MAX(WeatherDataId) + 1)
		FROM [IrrigationAdvisor-DEMO].[dbo].[WeatherData] 
		
			INSERT INTO [IrrigationAdvisor-DEMO].[dbo].[WeatherData] 
			(WeatherStationId, Date, Temperature, TemperatureMax,
			TemperatureMin, TemperatureDewPoint, Humidity, HumidityMax, HumidityMin,
			Barometer, BarometerMax, BarometerMin, SolarRadiation, UVRadiation,
			RainDay, RainStorm, RainMonth, RainYear, Evapotranspiration,
			EvapotranspirationMonth, EvapotranspirationYear, WeatherDataType,
			Observations, WindSpeed, WeatherDataInputType)
			  SELECT
			  @WeatherStationId, @Date, @Temperature,
			  @TemperatureMax, @TemperatureMin, @TemperatureDewPoint, 
			  @Humidity, @HumidityMax, @HumidityMin, 
			  @Barometer, @BarometerMax, @BarometerMin, 
			  @SolarRadiation, @UVRadiation, 
			  @RainDay, @RainStorm, @RainMonth, @RainYear, 
			  @Evapotranspiration, @EvapotranspirationMonth, 
			  @EvapotranspirationYear, @WeatherDataType, 
			  @Observations, @WindSpeed, @WeatherDataInputType
	END
	
	
	FETCH NEXT FROM UpdateWeatherData_cursor
    INTO @WeatherDataId,@WeatherStationId, @Date, @Temperature,
      @TemperatureMax, @TemperatureMin, @TemperatureDewPoint, 
      @Humidity, @HumidityMax, @HumidityMin, 
      @Barometer, @BarometerMax, @BarometerMin, 
      @SolarRadiation, @UVRadiation, 
      @RainDay, @RainStorm, @RainMonth, @RainYear, 
      @Evapotranspiration, @EvapotranspirationMonth, 
      @EvapotranspirationYear, @WeatherDataType, 
      @Observations, @WindSpeed, @WeatherDataInputType
END

CLOSE UpdateWeatherData_cursor;
DEALLOCATE UpdateWeatherData_cursor;
GO
