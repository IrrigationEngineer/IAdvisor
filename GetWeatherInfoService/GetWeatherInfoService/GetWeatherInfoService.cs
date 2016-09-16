﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Globalization;
using System.Net.Mail;
using System.Net;

namespace GetWeatherInfoService
{
    public partial class GetWeatherInfoService : ServiceBase
    {
        IrrigationAdvisorEntities context = new IrrigationAdvisorEntities();

        private const string CELSIUS = "C";
        private const string OUTSIDE_TEMP = "Outside Temp";
        private const string OUTSIDE_HUMIDITY = "Outside Humidity";
        private const string BAROMETER = "Barometer";
        private const string DEW_POINT = "Dew Point";
        private const string RAIN = "Rain";
        private const string SOLAR_RADIATION = "Solar Radiation";
        private const string ET = "ET";
        private const string UV_RADIATION = "UV Radiation";
        private const string MILIMETERS = "mm";
        private const string PERCENTAGE = "%";
        private const string MB = "mb";
        private const string WM2 = "W/m2";
        private const string INDEX = "Index";

        private static List<string> errorUrls = new List<string>();

        public GetWeatherInfoService()
        {
            InitializeComponent();
        }

        private string LogFormat(string key, object value)
        {
            string message = string.Format("{0} : {1}. \n",
                                            key,
                                            value.ToString());

            return message;
        }

        public void ProcessWeathers()
        {
            try
            {
                List<string> emailLog = new List<string>();
                errorUrls.Clear();
                emailLog.Clear();
                emailLog.Add(LogFormat("Comienzo: ", DateTime.Now));

                var weatherStations = context.WeatherStations.Where(w => w.WebAddress.Length > 0).ToList();
                foreach (var weatherStation in weatherStations)
                {
                    emailLog.Add("\n");
                    try
                    {
                        
                        string weatherStationDescription = string.Format(" {0} {1} \n", weatherStation.Name, weatherStation.WebAddress);
                        emailLog.Add(LogFormat("WeatherStation:", weatherStationDescription));

                        List<string> temperatureValues = GetWeatherLinkValues(weatherStation.WebAddress, OUTSIDE_TEMP);

                        double maxTemperature = GetDoubleValue(temperatureValues.ElementAt(2), CELSIUS);
                        double minTemperature = GetDoubleValue(temperatureValues.ElementAt(4), CELSIUS);

                        List<string> etValues = GetWeatherLinkValues(weatherStation.WebAddress, ET);

                        double evapotranspirationDay = 0;
                        double evapotranspirationMonth = 0;
                        double evapotranspirationYear = 0;

                        if (etValues.Count > 0)
                        {
                            evapotranspirationDay = GetDoubleValue(etValues.ElementAt(2), MILIMETERS);

                            evapotranspirationMonth = GetDoubleValue(etValues.ElementAt(4), MILIMETERS);

                            evapotranspirationYear = GetDoubleValue(etValues.ElementAt(5), MILIMETERS);

                        }


                        List<string> humidityValues = GetWeatherLinkValues(weatherStation.WebAddress, OUTSIDE_HUMIDITY);

                        double maxHumidity = 0;
                        double minHumidity = 0;

                        if (humidityValues.Count > 0)
                        {
                            maxHumidity = GetDoubleValue(humidityValues.ElementAt(2), PERCENTAGE);
                            minHumidity = GetDoubleValue(humidityValues.ElementAt(4), PERCENTAGE);

                        }

                        List<string> barometerValues = GetWeatherLinkValues(weatherStation.WebAddress, BAROMETER);

                        double minBarometer = 0;
                        double maxBarometer = 0;

                        if (barometerValues.Count > 0)
                        {
                            maxBarometer = GetDoubleValue(barometerValues.ElementAt(2), MB);

                            minBarometer = GetDoubleValue(barometerValues.ElementAt(4), MB);

                        }

                        List<string> dewValues = GetWeatherLinkValues(weatherStation.WebAddress, DEW_POINT);

                        double maxDewTemperature = 0;
                        double minDewTemperature = 0;

                        if (dewValues.Count > 0)
                        {
                            maxDewTemperature = GetDoubleValue(dewValues.ElementAt(2), CELSIUS);

                            minDewTemperature = GetDoubleValue(dewValues.ElementAt(4), CELSIUS);

                        }

                        List<string> rainValues = GetWeatherLinkValues(weatherStation.WebAddress, RAIN);
                        double rainDay = 0;
                        double rainMonth = 0;
                        double rainYear = 0;
                        double rainStorm = 0;

                        if (rainValues.Count > 0)
                        {
                            rainDay = GetDoubleValue(rainValues.ElementAt(2), MILIMETERS);

                            rainStorm = GetDoubleValue(rainValues.ElementAt(3), MILIMETERS);

                            rainMonth = GetDoubleValue(rainValues.ElementAt(4), MILIMETERS);

                            rainYear = GetDoubleValue(rainValues.ElementAt(5), MILIMETERS);

                        }

                        List<string> solarRadiationValues = GetWeatherLinkValues(weatherStation.WebAddress, SOLAR_RADIATION);
                        double solarRadiation = 0;

                        if (solarRadiationValues.Count > 0)
                        {
                            solarRadiation = GetDoubleValue(solarRadiationValues.ElementAt(2).Replace("W/m<span class=\"threequarter\"><sup>2</sup></span>", ""), string.Empty);

                        }

                        List<string> uvRadiationValues = GetWeatherLinkValues(weatherStation.WebAddress, UV_RADIATION);
                        double uvRadiation = 0;

                        if (uvRadiationValues.Count > 0)
                        {
                            uvRadiation = GetDoubleValue(uvRadiationValues.ElementAt(2), INDEX);
                        }

                        // Search if the station exists
                        WeatherData existingWeatherData = context.WeatherDatas.Where(w => w.WeatherStationId == weatherStation.WeatherStationId && w.Date.Date == DateTime.Now.Date).FirstOrDefault();

                        if (existingWeatherData == null)
                        {
                            WeatherData newWeatherData = new WeatherData()
                            {
                                Date = DateTime.Now,
                                Temperature = (maxTemperature + minTemperature) / 2,
                                Barometer = (maxBarometer + minBarometer) / 2,
                                BarometerMax = maxBarometer,
                                BarometerMin = minBarometer,
                                Evapotranspiration = evapotranspirationDay,
                                EvapotranspirationMonth = evapotranspirationMonth,
                                EvapotranspirationYear = evapotranspirationYear,
                                Humidity = (minHumidity + maxHumidity) / 2,
                                HumidityMax = maxHumidity,
                                HumidityMin = minHumidity,
                                RainDay = rainDay,
                                RainMonth = rainMonth,
                                RainStorm = rainStorm,
                                RainYear = rainYear,
                                SolarRadiation = solarRadiation,
                                TemperatureDewPoint = (maxDewTemperature + minDewTemperature) / 2,
                                TemperatureMax = maxTemperature,
                                TemperatureMin = minTemperature,
                                UVRadiation = uvRadiation,
                                WeatherDataType = 0,
                                WeatherStationId = weatherStation.WeatherStationId
                            };

                            context.WeatherDatas.Add(newWeatherData);

                            emailLog.Add(LogFormat("EvapotranspirationDay", evapotranspirationDay));
                            emailLog.Add(LogFormat("EvapotranspirationMonth", evapotranspirationMonth));
                            emailLog.Add(LogFormat("EvapotranspirationYear", evapotranspirationYear));
                            emailLog.Add(LogFormat("MaxHumidity", maxHumidity));
                            emailLog.Add(LogFormat("MinHumidity", minHumidity));
                            emailLog.Add(LogFormat("MaxBarometer", maxBarometer));
                            emailLog.Add(LogFormat("MinBarometer", minBarometer));
                            emailLog.Add(LogFormat("MaxDewTemperature", maxDewTemperature));
                            emailLog.Add(LogFormat("MinDewTemperature", minDewTemperature));
                            emailLog.Add(LogFormat("RainDay", rainDay));
                            emailLog.Add(LogFormat("RainStorm", rainStorm));
                            emailLog.Add(LogFormat("RainMonth", rainMonth));
                            emailLog.Add(LogFormat("RainYear", rainYear));
                            emailLog.Add(LogFormat("SolarRadiation", solarRadiation));
                            emailLog.Add(LogFormat("UvRadiation", uvRadiation));
                            emailLog.Add("════════════Fin═══════════════\n\n");
                        }
                        else
                        {
                            existingWeatherData.Date = DateTime.Now;

                            if (existingWeatherData.TemperatureMax < maxTemperature && maxTemperature != 0)
                            {
                                existingWeatherData.TemperatureMax = maxTemperature;
                                emailLog.Add(LogFormat("TemperatureMax", existingWeatherData.TemperatureMax));
                            }


                            if (existingWeatherData.TemperatureMin > minTemperature && minTemperature != 0)
                            {
                                existingWeatherData.TemperatureMin = minTemperature;
                                emailLog.Add(LogFormat("TemperatureMin", existingWeatherData.TemperatureMin));
                            }

                            existingWeatherData.Temperature = (existingWeatherData.TemperatureMax + existingWeatherData.TemperatureMin) / 2;

                            if (existingWeatherData.Evapotranspiration < evapotranspirationDay && evapotranspirationDay != 0)
                            {
                                existingWeatherData.Evapotranspiration = evapotranspirationDay;
                                existingWeatherData.EvapotranspirationMonth = evapotranspirationMonth;
                                existingWeatherData.EvapotranspirationYear = evapotranspirationYear;
                                emailLog.Add(LogFormat("Evapotranspiration", existingWeatherData.Evapotranspiration));
                                emailLog.Add(LogFormat("EvapotranspirationMonth", existingWeatherData.EvapotranspirationMonth));
                                emailLog.Add(LogFormat("EvapotranspirationYear", existingWeatherData.EvapotranspirationYear));
                            }

                            if (existingWeatherData.UVRadiation > uvRadiation && uvRadiation != 0)
                            {
                                existingWeatherData.UVRadiation = uvRadiation;
                                emailLog.Add(LogFormat("UVRadiation", existingWeatherData.UVRadiation));
                            }



                            if (existingWeatherData.SolarRadiation > solarRadiation && solarRadiation != 0)
                            {
                                existingWeatherData.SolarRadiation = solarRadiation;
                                emailLog.Add(LogFormat("SolarRadiation", existingWeatherData.SolarRadiation));
                            }



                            if (existingWeatherData.HumidityMax < maxHumidity && maxHumidity != 0)
                            {
                                existingWeatherData.HumidityMax = maxHumidity;
                                emailLog.Add(LogFormat("HumidityMax", existingWeatherData.HumidityMax));
                            }



                            if (existingWeatherData.HumidityMin > minHumidity && minHumidity != 0)
                            {
                                existingWeatherData.HumidityMin = minHumidity;
                                emailLog.Add(LogFormat("HumidityMin", existingWeatherData.HumidityMin));
                            }


                            existingWeatherData.Humidity = (maxHumidity + minHumidity) / 2;

                            if (existingWeatherData.BarometerMax < maxBarometer && maxBarometer != 0)
                            {
                                existingWeatherData.BarometerMax = maxBarometer;
                                emailLog.Add(LogFormat("BarometerMax", existingWeatherData.BarometerMax));
                            }

                            if (existingWeatherData.BarometerMin > minBarometer && minBarometer != 0)
                            {
                                existingWeatherData.BarometerMin = minBarometer;
                                emailLog.Add(LogFormat("BarometerMin", existingWeatherData.BarometerMin));
                            }

                            existingWeatherData.Barometer = (existingWeatherData.BarometerMax + existingWeatherData.BarometerMin) / 2;

                            if (existingWeatherData.RainDay < rainDay && rainDay != 0)
                            {
                                existingWeatherData.RainDay = rainDay;
                                emailLog.Add(LogFormat("RainDay", existingWeatherData.RainDay));
                                existingWeatherData.RainMonth = rainMonth;
                                emailLog.Add(LogFormat("RainMonth", existingWeatherData.RainMonth));
                                existingWeatherData.RainYear = rainYear;
                                emailLog.Add(LogFormat("RainYear", existingWeatherData.RainYear));
                            }

                            emailLog.Add("════════════Fin═══════════════\n\n");

                        }
                    }
                    catch (Exception ex)
                    {
                        emailLog.Add("\n");
                        errorUrls.Add(weatherStation.WebAddress);
                        emailLog.Add("Error en la carga \n");
                        emailLog.Add(ex.Message + "\n");
                        continue;
                    }
                    
                }

                context.SaveChanges();

                string endMessage = string.Empty;

                foreach (string item in emailLog)
                {
                    endMessage = endMessage + item ;
                }

                 SendEmails("Carga correcta de Weather Data",
                                 endMessage);
            }
            catch (Exception ex)
            {
                //NLog
                 SendEmails("Error en el carga de Weather Data",
                            ex.Message + " | " + ex.StackTrace);
                
            }
        }

        public void SendEmails(string subject, string body)
        {
            try
            {
                string smtpAddress = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["smtpAddress"]);
                int portNumber = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["smtpPort"]);
                bool enableSSL = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["ssl"]);
                string emailFrom = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailFrom"]);
                string password = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["password"]);
                string emailTo = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailTo"]);


                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false;

                    foreach (var item in errorUrls)
                    {
                        WebClient wc = new WebClient();
                        byte[] raw = wc.DownloadData(item);

                        //Get the html text from the web.
                        string webData = Encoding.UTF8.GetString(raw);

                        string path = Path.GetTempFileName().Replace(".tmp",".html");
                        using (StreamWriter file = new StreamWriter(path, true))
                        {
                            file.WriteLine(webData);
                        }

                        mail.Attachments.Add(new Attachment(path));
                    }
                        
                    // Can set to false, if you are sending pure text.


                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }

            }
            catch (Exception)
            {
                //NLog
            }

        }

        protected override void OnStart(string[] args)
        {
            ProcessWeathers();
        }

        private double GetDoubleValue(string value, string toRemovedString)
        {
            string preValue = value;
            if (!string.IsNullOrEmpty(toRemovedString))
            {
                preValue = value.Trim().Replace(toRemovedString, "");
            }
            
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            double doubleValue = Convert.ToDouble(preValue, provider);

            return doubleValue;
        }

        protected override void OnStop()
        {
            try
            {

            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.GetType().ToString(),
                                  ex.Message,
                                  EventLogEntryType.Error);
            }
        }
 
        /// <summary>
        /// Get value from the Weather link table
        /// </summary>
        /// <param name="url">Url from the Weather Link page</param>
        /// <param name="keyName">Key Name. Example 'ET'</param>
        /// <param name="valueCount">Count of the consecutive values. For default 6</param>
        private static List<string> GetWeatherLinkValues(
            string url,
            string keyName,
            short valueCount = 6,
            string htmlTag = "td",
            string className = "summary_data")
        {
            List<string> result = new List<string>();

            WebClient wc = new WebClient();
            byte[] raw = wc.DownloadData(url);

            //Get the html text from the web.
            string webData = Encoding.UTF8.GetString(raw);
            // Search an specific value from the html file
            HtmlDocument html = new HtmlDocument();
            html.LoadHtml(webData);
            HtmlNodeCollection htmlNodes = html.DocumentNode.SelectNodes(string.Format("//{0}[@class='{1}']",
                                                                                        htmlTag,
                                                                                        className));
            bool weFound = false;
            short count = 0;
            foreach (var item in htmlNodes)
            {
                if (item.InnerHtml.Equals(keyName) || weFound && count < valueCount)
                {
                    count++;
                    weFound = true;
                    result.Add(item.InnerHtml);
                }
            }

            return result;
        }
    }
}