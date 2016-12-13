//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POCInia
{
    using System;
    using System.Collections.Generic;
    
    public partial class WeatherData
    {
        public long WeatherDataId { get; set; }
        public long WeatherStationId { get; set; }
        public System.DateTime Date { get; set; }
        public double Temperature { get; set; }
        public double TemperatureMax { get; set; }
        public double TemperatureMin { get; set; }
        public double TemperatureDewPoint { get; set; }
        public double Humidity { get; set; }
        public double HumidityMax { get; set; }
        public double HumidityMin { get; set; }
        public double Barometer { get; set; }
        public double BarometerMax { get; set; }
        public double BarometerMin { get; set; }
        public double SolarRadiation { get; set; }
        public double UVRadiation { get; set; }
        public double RainDay { get; set; }
        public double RainStorm { get; set; }
        public double RainMonth { get; set; }
        public double RainYear { get; set; }
        public double Evapotranspiration { get; set; }
        public double EvapotranspirationMonth { get; set; }
        public double EvapotranspirationYear { get; set; }
        public int WeatherDataType { get; set; }
        public string Observations { get; set; }
        public double WindSpeed { get; set; }
        public int WeatherDataInputType { get; set; }
    
        public virtual WeatherStation WeatherStation { get; set; }
    }
}
