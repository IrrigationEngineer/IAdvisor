﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Language;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;

using IrrigationAdvisor.DBContext;

using System.Data.Entity;

namespace IrrigationAdvisorConsole
{
    public static class DataEntry
    {

        #region Config Data Crops 2016

        #region Specie
        public static double BaseTemperature_CornSouth_2016 = 10;
        public static double StressTemperature_CornSouth_2016 = 34;
        public static double BaseTemperature_CornNorth_2016 = 8;
        public static double StressTemperature_CornNorth_2016 = 34;

        public static double BaseTemperature_SoyaSouth_2016 = 8;
        public static double StressTemperature_SoyaSouth_2016 = 40;
        public static double BaseTemperature_SoyaNorth_2016 = 8;
        public static double StressTemperature_SoyaNorth_2016 = 40;

        public static double BaseTemperature_SorghumForageSouth_2016 = 8;
        public static double StressTemperature_SorghumForageSouth_2016 = 35;
        public static double BaseTemperature_SorghumForageNorth_2016 = 8;
        public static double StressTemperature_SorghumForageNorth_2016 = 35;

        public static double BaseTemperature_SorghumGrainSouth_2016 = 8;
        public static double StressTemperature_SorghumGrainSouth_2016 = 35;
        public static double BaseTemperature_SorghumGrainNorth_2016 = 8;
        public static double StressTemperature_SorghumGrainNorth_2016 = 35;

        public static double BaseTemperature_AlfalfaSouth_2016 = 8;
        public static double StressTemperature_AlfalfaSouth_2016 = 35;
        public static double BaseTemperature_AlfalfaNorth_2016 = 8;
        public static double StressTemperature_AlfalfaNorth_2016 = 35;

        public static double BaseTemperature_RedCloverForageSouth_2016 = 8;
        public static double StressTemperature_RedCloverForageSouth_2016 = 35;
        public static double BaseTemperature_RedCloverForageNorth_2016 = 8;
        public static double StressTemperature_RedCloverForageNorth_2016 = 35;

        public static double BaseTemperature_RedCloverSeedSouth_2016 = 8;
        public static double StressTemperature_RedCloverSeedSouth_2016 = 35;
        public static double BaseTemperature_RedCloverSeedNorth_2016 = 8;
        public static double StressTemperature_RedCloverSeedNorth_2016 = 35;

        public static double BaseTemperature_FescueForageSouth_2016 = 8;
        public static double StressTemperature_FescueForageSouth_2016 = 35;
        public static double BaseTemperature_FescueForageNorth_2016 = 8;
        public static double StressTemperature_FescueForageNorth_2016 = 35;

        public static double BaseTemperature_FescueSeedSouth_2016 = 8;
        public static double StressTemperature_FescueSeedSouth_2016 = 35;
        public static double BaseTemperature_FescueSeedNorth_2016 = 8;
        public static double StressTemperature_FescueSeedNorth_2016 = 35;

        #endregion

        #region CropIrrigationWeather

        #region Santa Lucia
        //public static DateTime SowingDate_CornSouth_SantaLuciaPivot1_2016 = new DateTime(2016, 10, 01);
        //public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot1_2016 = 15;
        //public static DateOfData SowingDate_CornSouth_SantaLuciaPivot2_2016 = new DateOfData(2016, 9, 16);
        //public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot2_2016 = 15;
        //public static DateOfData SowingDate_CornSouth_SantaLuciaPivot3_2016 = new DateOfData(2016, 9, 16);
        //public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot3_2016 = 15;
        //public static DateOfData SowingDate_CornSouth_SantaLuciaPivot5_2016 = new DateOfData(2016, 9, 16);
        //public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot5_2016 = 15;
        #endregion

        #region DCA - El Paraiso
        public static DateTime SowingDate_FestucaSouth_DCAElParaisoPivot1_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot1_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot1_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_DCAElParaisoPivot2_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot2_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot2_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_DCAElParaisoPivot3_2016 = new DateTime(2012, 9, 16);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot3_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot3_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_LDCAElParaisoPivot4_2016 = new DateTime(2012, 9, 16);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot4_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot4_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_LDCAElParaisoPivot5_2016 = new DateTime(2016, 5, 24);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot5_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot5_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_LDCAElParaisoPivot6_2016 = new DateTime(2016, 5, 24);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot6_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot6_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_LDCAElParaisoPivot7_2016 = new DateTime(2016, 5, 24);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot7_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot7_2016 = 12;
        #endregion

        #region DCA - San Jose
        public static DateTime SowingDate_CornSouth_DCASanJosePivot1_2016 = new DateTime(2016, 9, 19);
        public static DateTime HarvestDate_CornSouth_DCASanJosePivot1_2016 = new DateTime(2017, 2, 20);
        public static Double PredeterminatedIrrigationQuantity_DCASanJosePivot1_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCASanJosePivot2_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCASanJosePivot2_2016 = new DateTime(2017, 2, 20);
        public static Double PredeterminatedIrrigationQuantity_DCASanJosePivot2_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCASanJosePivot3_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCASanJosePivot3_2016 = new DateTime(2017, 2, 20);
        public static Double PredeterminatedIrrigationQuantity_DCASanJosePivot3_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCASanJosePivot4_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCASanJosePivot4_2016 = new DateTime(2017, 2, 20);
        public static Double PredeterminatedIrrigationQuantity_DCASanJosePivot4_2016 = 14;
        #endregion

        #region DCA - La Perdiz
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot1_2016 = new DateTime(2016, 9, 23);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot1_2016 = new DateTime(2017, 02, 20); 
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot1_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot2_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot2_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot2_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot3_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot3_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot3_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot4_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot4_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot4_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot5_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot5_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot5_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot6_2016 = new DateTime(2016, 9, 23);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot6_2016 = new DateTime(2017, 04, 5);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot6_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot7_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot7_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot7_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot8_2016 = new DateTime(2016, 8, 20);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot8_2016 = new DateTime(2017, 04, 5);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot8_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot9_2016 = new DateTime(2016, 8, 20);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot9_2016 = new DateTime(2017, 04, 5);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot9_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot10a_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot10a_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot10a_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot10b_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot10b_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot10b_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot11_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot11_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot11_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot12_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot12_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot12_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot13_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot13_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot13_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot14_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot14_2016 = new DateTime(2017, 04, 05);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot14_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot15_2016 = new DateTime(2016, 9, 23);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot15_2016 = new DateTime(2017, 04, 05);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot15_2016 = 14;
        #endregion

        #region Del Lago - San Pedro
        
        #endregion

        #region Del Lago - El Mirador
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot1_2016 = new DateTime(2016, 09, 20); //1
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot1_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot1_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot2_2016 = new DateTime(2016, 09, 20); //2
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot2_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot2_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot3_2016 = new DateTime(2016, 09, 20); //3
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot3_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot3_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot4_2016 = new DateTime(2016, 09, 20); //4
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot4_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot4_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot5_2016 = new DateTime(2016, 10, 03); //5
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot5_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot5_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot6_2016 = new DateTime(2016, 10, 03); //6
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot6_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot6_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot7_2016 = new DateTime(2016, 10, 03); //7
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot7_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot7_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot8_2016 = new DateTime(2016, 10, 03); //8
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot8_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot8_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot9_2016 = new DateTime(2016, 10, 03); //9
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot9_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot9_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot10_2016 = new DateTime(2016, 10, 03); //10
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot10_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot10_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot11_2016 = new DateTime(2016, 10, 03); //11
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot11_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot11_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot12_2016 = new DateTime(2016, 10, 03); //12
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot12_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot12_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot13_2016 = new DateTime(2016, 10, 03); //13
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot13_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot13_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot14_2016 = new DateTime(2016, 10, 03); //14
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot14_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot14_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot15_2016 = new DateTime(2016, 10, 03); //15
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot15_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot15_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivotChaja1_2016 = new DateTime(2016, 10, 03); //Chaja 1
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivotChaja1_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivotChaja1_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivotChaja2_2016 = new DateTime(2016, 10, 03); //Chaja 2
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivotChaja2_2016 = new DateTime(2017, 02, 10); 
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivotChaja2_2016 = 14;
        #endregion

        #region GMO - La Palma
        public static DateTime SowingDate_CornSouth_GMOLaPalmaPivot1_2016 = new DateTime(2015, 06, 30);
        public static DateTime HarvestDate_CornSouth_GMOLaPalmaPivot1_2016 = new DateTime(2017, 04, 30);
        public static Double PredeterminatedIrrigationQuantity_GMOLaPalmaPivot1_2016 = 14;
        public static DateTime SowingDate_CornSouth_GMOLaPalmaPivot2_2016 = new DateTime(2016, 09, 26);
        public static DateTime HarvestDate_CornSouth_GMOLaPalmaPivot2_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOLaPalmaPivot2_2016 = 14;
        public static DateTime SowingDate_CornSouth_GMOLaPalmaPivot3_2016 = new DateTime(2016, 09, 25);
        public static DateTime HarvestDate_CornSouth_GMOLaPalmaPivot3_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOLaPalmaPivot3_2016 = 14;
        public static DateTime SowingDate_CornSouth_GMOLaPalmaPivot4_2016 = new DateTime(2016, 09, 24);
        public static DateTime HarvestDate_CornSouth_GMOLaPalmaPivot4_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOLaPalmaPivot4_2016 = 14;
        public static DateTime SowingDate_CornSouth_GMOLaPalmaPivot5_2016 = new DateTime(2016, 09, 24);
        public static DateTime HarvestDate_CornSouth_GMOLaPalmaPivot5_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOLaPalmaPivot5_2016 = 14;
        #endregion

        #region GMO - El Tacuru
        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot1_2016 = new DateTime(2016, 10, 15);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot1_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot1_2016 = 14;

        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot2_2016 = new DateTime(2016, 09, 21);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot2_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot2_2016 = 14;
        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot3_2016 = new DateTime(2016, 09, 19);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot3_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot3_2016 = 14;
        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot4_2016 = new DateTime(2016, 09, 17);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot4_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot4_2016 = 14;

        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot5_2016 = new DateTime(2016, 10, 15);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot5_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot5_2016 = 14;
        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot6_2016 = new DateTime(2016, 10, 15);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot6_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot6_2016 = 14;
        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot7_2016 = new DateTime(2016, 10, 15);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot7_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot7_2016 = 14;
        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot8_2016 = new DateTime(2016, 10, 15);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot8_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot8_2016 = 14;
        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot9_2016 = new DateTime(2016, 10, 15);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot9_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot9_2016 = 14;
        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot10_2016 = new DateTime(2016, 10, 15);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot10_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot10_2016 = 14;
        #endregion

        #endregion

        #endregion

        #region RainData

        #region Santa Lucia

        #endregion

        #region DCA El Paraiso

        #region 2016

        public static void AddRainDataDCAElParaisoPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso7
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region DCA San Jose

        #region 2016

        public static void AddRainDataDCASanJosePivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCASanJosePivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCASanJosePivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCASanJosePivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region DCA La Perdiz

        #region 2016

        public static void AddRainDataDCALaPerdizPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz7
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz8
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz9
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz10a
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot11_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz11
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot12_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz12
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot13_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz13
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot14_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz14
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz15
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region Del Lago - San Pedro

        #endregion

        #region Del Lago - El Mirador

        #region 2016

        public static void AddRainDataDelLagoElMiradorPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.SowingDate <= pDateOfReference
                                          && ciw.HarvestDate >= pDateOfReference
                                      select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador7
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador8
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador9
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador10
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot11_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador11
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot12_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador12
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot13_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador13
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot14_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador14
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador15
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivotChaja1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMiradorChaja1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivotChaja2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMiradorChaja2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rains
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region GMO - La Palma

        #region 2016

        public static void AddRainDataGMOLaPalmaPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/07 - 6
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 3
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 23
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 10
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOLaPalmaPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/07 - 6
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 3
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 23
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 10
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOLaPalmaPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/07 - 6
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 3
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 23
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 10
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOLaPalmaPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/07 - 6
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 3
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 23
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 10
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }
        
        
        #endregion

        #endregion

        #region GMO - El Tacuru

        #region 2016

        public static void AddRainDataGMOElTacuruPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaNorthMedium
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru7
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru8
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru9
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru10
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        /// <summary>
        /// Example for Add RainQuantity Data
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainData(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz3
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 1), 10 );

        }

        #endregion

        #region IrrigationData

        #region DCA El Paraiso

        #region 2016

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - El Paraiso Pivot 3 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCAElParaisoPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/09/29 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 29);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/03 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 03);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/06 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 06);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/09 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 09);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - El Paraiso Pivot 4 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCAElParaisoPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/09/29 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 29);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/03 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 03);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/06 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 06);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        #endregion

        #endregion

        #region DCA San Jose

        #region 2016

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCASanJosePivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/09/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/09/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 30);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/05 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 4 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCASanJosePivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/09/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/09/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 30);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/05 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        #endregion

        #endregion

        #region DCA La Perdiz

        #region 2016

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/05 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 15;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 6 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/05 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 15;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 15 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz15
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/05 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 15;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        #endregion

        #endregion

        #region Del Lago - El Mirador

        #region 2016

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.SowingDate <= pDateOfReference
                                          && ciw.HarvestDate >= pDateOfReference
                                      select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 2 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 3 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 4 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 5 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/??/?? 0 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 10, 17);
            //    lIrrigationQuantity = 10;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 6 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/??/?? 0 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 10, 17);
            //    lIrrigationQuantity = 10;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 7 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador7
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 8 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador8
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/?? 0 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 10, 17);
            //    lIrrigationQuantity = 10;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 9 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador9
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 10 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador10
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/17 10 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 10, 17);
            //    lIrrigationQuantity = 10;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 11 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot11_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador11
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/?? 0 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 10, 17);
            //    lIrrigationQuantity = 10;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 12 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot12_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador12
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/?? 0 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 10, 17);
            //    lIrrigationQuantity = 10;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 13 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot13_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador13
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/?? 0 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 10, 17);
            //    lIrrigationQuantity = 10;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 14 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot14_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador14
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/?? 0 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 10, 17);
            //    lIrrigationQuantity = 10;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 15 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador15
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/?? 0 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 10, 17);
            //    lIrrigationQuantity = 10;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot Chaja 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivotChaja1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMiradorChaja1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/?? 0 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 10, 17);
            //    lIrrigationQuantity = 10;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot Chaja 2 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivotChaja2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMiradorChaja2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/?? 0 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 10, 17);
            //    lIrrigationQuantity = 10;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            
        }

        #endregion

        #endregion

        #region GMO - La Palma

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/10/08 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 08);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 2 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #region Irrigation 2016/09/29 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 29);
                lIrrigationQuantity = 16;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/05 8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 3 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #region Irrigation 2016/09/27 7 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 27);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/06 7 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 06);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 4 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #region Irrigation 2016/09/27 7 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 27);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/06 7 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 06);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        #endregion

        #region GMO - El Tacuru

        #region 2016
        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            
            #region Irrigation 2016/09/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 2 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/09/27 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 27);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 3 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/09/26 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 26);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 3 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();

            #region Irrigation 2016/09/28 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 28);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/01 7 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 01);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }
        #endregion

        #endregion

        #endregion

        #region PhenologicalStage

        #region DCA La Perdiz

        #region 2016
        public static void AddPhenologicalStageAdjustementsLaPerdizPivot2_2015(IrrigationAdvisorContext context)
        {
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            WeatherStation lWeatherStationMain = null;
            CropIrrigationWeather lCropIrrigationWeather = null;
            String lName = "";
            DateTime lDateTimeToChange;
            PhenologicalStage lPhenologicalStage;
            Stage lStageToChange;
            String lObservation = "";

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();


            //First Change
            lStageToChange = (from stage in context.Stages 
                      where stage.Name.Contains(Utils.NameStagesCorn + " V4") 
                      select stage).FirstOrDefault();
            lPhenologicalStage = (from phenologicalstage in context.PhenologicalStages
                                  where phenologicalstage.SpecieId.Equals(lCrop.SpecieId) 
                                  && phenologicalstage.StageId.Equals(lStageToChange.StageId)
                                  select phenologicalstage).FirstOrDefault();
            lDateTimeToChange = new DateTime(2015, 11, 20);
            lObservation = "Real Stage is "  + lStageToChange.Name 
                + ", " + lStageToChange.Description + "." ;
            lName = "Adjustement " + lStageToChange.Name + " "
                                                + lDateTimeToChange.ToString();
            
            lCropIrrigationWeather.AddPhenologicalStageAdjustmentToList(lName, lCrop, lDateTimeToChange, 
                                                            lStageToChange, lPhenologicalStage, lObservation);

        }

        public static void AddPhenologicalStageAdjustementsLaPerdizPivot3_2015(IrrigationAdvisorContext context)
        {
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            WeatherStation lWeatherStationMain = null;
            CropIrrigationWeather lCropIrrigationWeather = null;
            String lName = "";
            DateTime lDateTimeToChange;
            PhenologicalStage lPhenologicalStage;
            Stage lStageToChange;
            String lObservation = "";

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz3
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();


            //First Change
            lStageToChange = (from stage in context.Stages
                              where stage.Name.Contains(Utils.NameStagesCorn + " V4")
                              select stage).FirstOrDefault();
            lPhenologicalStage = (from phenologicalstage in context.PhenologicalStages
                                  where phenologicalstage.SpecieId.Equals(lCrop.SpecieId)
                                  && phenologicalstage.StageId.Equals(lStageToChange.StageId)
                                  select phenologicalstage).FirstOrDefault();
            lDateTimeToChange = new DateTime(2015, 11, 20);
            lObservation = "Real Stage is " + lStageToChange.Name
                + ", " + lStageToChange.Description + ".";
            lName = "Adjustement " + lStageToChange.Name + " "
                                                + lDateTimeToChange.ToString();

            lCropIrrigationWeather.AddPhenologicalStageAdjustmentToList(lName, lCrop, lDateTimeToChange,
                                                            lStageToChange, lPhenologicalStage, lObservation);

        }

        public static void AddPhenologicalStageAdjustementsLaPerdizPivot5_2015(IrrigationAdvisorContext context)
        {
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            WeatherStation lWeatherStationMain = null;
            CropIrrigationWeather lCropIrrigationWeather = null;
            String lName = "";
            DateTime lDateTimeToChange;
            PhenologicalStage lPhenologicalStage;
            Stage lStageToChange;
            String lObservation = "";

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz5
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();


            //First Change
            lStageToChange = (from stage in context.Stages
                              where stage.Name.Contains(Utils.NameStagesCorn + " V4")
                              select stage).FirstOrDefault();
            lPhenologicalStage = (from phenologicalstage in context.PhenologicalStages
                                  where phenologicalstage.SpecieId.Equals(lCrop.SpecieId)
                                  && phenologicalstage.StageId.Equals(lStageToChange.StageId)
                                  select phenologicalstage).FirstOrDefault();
            lDateTimeToChange = new DateTime(2015, 11, 20);
            lObservation = "Real Stage is " + lStageToChange.Name
                + ", " + lStageToChange.Description + ".";
            lName = "Adjustement " + lStageToChange.Name + " "
                                                + lDateTimeToChange.ToString();

            lCropIrrigationWeather.AddPhenologicalStageAdjustmentToList(lName, lCrop, lDateTimeToChange,
                                                            lStageToChange, lPhenologicalStage, lObservation);

        }
        #endregion
        #endregion

        #endregion

        #region Information To IrrigationUnits

        #region Demo1 - La Perdiz

        /// <summary>
        /// Add Information To IrrigationUnits - Demo1 - La Perdiz Pivot 11 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo1Pivot11_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo11
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo11
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo11)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 128)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All 
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    context.SaveChanges();
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo1 - La Perdiz Pivot 12 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo1Pivot12_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo12
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo12
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo12)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All 
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo1 - La Perdiz Pivot 13 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo1Pivot13_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo13
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo13
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo13)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All 
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo1 - La Perdiz Pivot 15 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo1Pivot15_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo15
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList)
                                 .FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo15
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo15)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All 
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #region Demo2 - Santa Lucia

        /// <summary>
        /// Add Information To IrrigationUnits - Demo2 - Santa Lucia Pivot 21 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo2Pivot21_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo2
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo21
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo21
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo21)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 128)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    context.SaveChanges();
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo2 - Santa Lucia Pivot 22 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo2Pivot22_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo2
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo22
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo22
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo22)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All 
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo2 - Santa Lucia Pivot 23 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo2Pivot23_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo2
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo23
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo23
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo23)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All 
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo2 - Santa Lucia Pivot 24 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo2Pivot24_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo2
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo24
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo24
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo24)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo2 - Santa Lucia Pivot 25 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo2Pivot25_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo2
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo25
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList)
                                 .FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo25
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo25)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All 
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #region Demo3 - La Palma

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 31 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot31_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo31
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo31
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo31)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 128)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    context.SaveChanges();
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 32A 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot32A_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo32A
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo32A
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo32A)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 33 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot33_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo33
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo33
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo33)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 34 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot34_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo34
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo34
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo34)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 342 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot342_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo34
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo34
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo34)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 35 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot35_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo35
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList)
                                 .FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo35
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo35)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #region DCA El Paraiso

        #region 2016
        #endregion

        #endregion

        #region DCA San Jose

        #region 2016

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - San Jose Pivot 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCASanJosePivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationSanFernando
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCASanJose1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCASanJose1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCASanJose)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - San Jose Pivot 4 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCASanJosePivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose4
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationSanFernando
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCASanJose4
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCASanJose4)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCASanJose)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #endregion

        #region DCA La Perdiz

        #region 2016

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - La Perdiz Pivot 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCALaPerdizPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCALaPerdiz1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCALaPerdiz)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - La Perdiz Pivot 6 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCALaPerdizPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz6
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCALaPerdiz6
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz6)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCALaPerdiz)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - La Perdiz Pivot 15 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCALaPerdizPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz15
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCALaPerdiz15
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz15)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCALaPerdiz)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #endregion

        #region Del Lago - San Pedro

        #region 2016

        #endregion

        #endregion

        #region Del Lago - El Mirador

        #region 2016

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 2 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador2
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador2)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 3 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador3
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador3
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador3)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 4 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador4
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador4
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador4)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 5 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador5
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador5
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador5)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 6 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador6
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador6
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador6)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 7 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador7
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador7
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador7)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 8 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador8
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador8
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador8)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 9 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador9
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador9
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador9)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 10 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador10
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador10
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador10)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 11 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot11_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador11
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador11
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador11)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 12 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot12_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador12
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador12
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador12)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 13 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot13_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador13
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador13
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador13)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 14 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot14_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador14
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador14
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador14)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 15 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador15
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador15
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador15)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot Chaja 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivotChaja1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMiradorChaja1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMiradorChaja1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMiradorChaja1)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot Chaja 2 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivotChaja2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMiradorChaja2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.SowingDate <= pDateOfReference
                                          && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMiradorChaja2
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMiradorChaja2)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #endregion

        #region GMO - La Palma

        #region 2016

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - La Palma Pivot 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOLaPalmaPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieAlfalfaSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesAlfalfa)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.SowingDate <= pDateOfReference
                                          && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieAlfalfaSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieAlfalfaSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOLaPalma1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOLaPalma)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - La Palma Pivot 2 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOLaPalmaPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.SowingDate <= pDateOfReference
                                          && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOLaPalma2
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma2)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOLaPalma)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - La Palma Pivot 3 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOLaPalmaPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma3
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate &&
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year &&
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOLaPalma3
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma3)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOLaPalma)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - La Palma Pivot 4 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOLaPalmaPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma4
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate &&
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year &&
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOLaPalma4
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma4)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOLaPalma)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #endregion

        #region GMO - El Tacuru

        #region 2016

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieAlfalfaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesAlfalfa)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationZanjaHonda
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                            && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                            && ciw.SowingDate <= pDateOfReference
                                            && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieAlfalfaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieAlfalfaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieAlfalfaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 2 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationZanjaHonda
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                            && ciw.SowingDate <= pDateOfReference
                                            && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru2
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru2)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 3 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru3
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationZanjaHonda
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru3
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru3)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 4 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru4
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationZanjaHonda
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru4
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru4)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 5 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru5
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationZanjaHonda
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru5
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru5)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 6 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru6
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationZanjaHonda
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru6
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru6)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 7 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru7
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationZanjaHonda
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru7
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru7)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 8 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru8
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationZanjaHonda
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru8
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru8)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 9 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru9
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationZanjaHonda
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru9
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru9)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 10 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru10
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationZanjaHonda
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru10
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru10)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #endregion

        #endregion

    }

}
