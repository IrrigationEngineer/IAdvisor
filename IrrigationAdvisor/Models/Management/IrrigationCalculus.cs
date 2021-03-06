﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Utilities;

namespace IrrigationAdvisor.Models.Management
{
    /// <summary>
    /// Create: 2014-11-12
    /// Author: monicarle
    /// Description: 
    ///     Do the calculus to Irrigate (or not)
    ///     
    /// References:
    ///     CropIrrigationWater
    ///     
    /// Dependencies:
    ///     IrrigationSystem
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///      + cropIrrigationWeather: CropIrrigationWeather
    ///      + hydricBalance: double
    ///      + soilHydricVolume: double
    /// 
    /// Methods:
    ///     - IrrigationCalculus()      -- constructor
    ///     - IrrigationCalculus(name)  -- consturctor with parameters
    ///     - HowMuchToIrrigate(dateTime, cropIrrigationWater)
    /// </summary>
    public class IrrigationCalculus
    {

        #region Consts
        
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - calculusEvapoTraspiration: CalculusEvapoTraspiration
        ///     - calculusAvailableWater: CalculusAvailableWater
        /// </summary>
        private CalculusAvailableWater calculusAvailableWater;

        private CalculusEvapotranspiration calculusEvapotranspiration;

        
        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        /// </summary>

        
        public CalculusAvailableWater CalculusAvailableWater
        {
            get { return calculusAvailableWater; }
            set { calculusAvailableWater = value; }
        }

        public CalculusEvapotranspiration CalculusEvapotranspiration
        {
            get { return calculusEvapotranspiration; }
            set { calculusEvapotranspiration = value; }
        }

        #endregion

        #region Construction
        /// <summary>
        /// Constructor of ClassTemplate
        /// </summary>
        public IrrigationCalculus()
        {
            this.calculusAvailableWater = new CalculusAvailableWater();
            this.calculusEvapotranspiration = new CalculusEvapotranspiration();
        }

        

        #endregion

        #region Private Helpers
        
       
        #endregion

        #region Public Methods
        /// <summary>
        /// Calculate how much to irrigate in a Date.
        /// Use both ways to calculate: by available water and by acumulated evapotranspirationCrop
        /// </summary>
        /// <param name="pName">new name</param>
        public Pair <double,Utils.WaterInputType> HowMuchToIrrigate(CropIrrigationWeather pCropIrrigationWeather)
        {
            Pair<double, Utils.WaterInputType> lReturn; 
            bool lIrrigationByEvapotranspiration;
            bool lIrrigationByHydricBalance;
            double lPercentageAvailableWater;

            lReturn = new Pair<double,Utils.WaterInputType>();
            lIrrigationByEvapotranspiration = CalculusEvapotranspiration.IrrigateByEvapotranspiration(pCropIrrigationWeather);
            lIrrigationByHydricBalance = CalculusAvailableWater.IrrigateByHydricBalance(pCropIrrigationWeather);
            lPercentageAvailableWater = pCropIrrigationWeather.GetPercentageOfAvailableWaterTakingIntoAccointPermanentWiltingPoint();

            //If we need to irrigate by Evapotranspiraton, then Available water has to be lower than 60% 
            if (lIrrigationByEvapotranspiration && lPercentageAvailableWater < InitialTables.PERCENTAGE_OF_AVAILABE_WATER_TO_IRRIGATE)
            {
                lReturn.First = pCropIrrigationWeather.PredeterminatedIrrigationQuantity;
                lReturn.Second = Utils.WaterInputType.IrrigationByETCAcumulated;
            }
            else if (lIrrigationByHydricBalance)
            {
                lReturn.First = pCropIrrigationWeather.PredeterminatedIrrigationQuantity;
                lReturn.Second = Utils.WaterInputType.IrrigationByHydricBalance;
            }

            return lReturn;
        }

        
        #endregion

        #region Overrides

        #endregion
    }
}