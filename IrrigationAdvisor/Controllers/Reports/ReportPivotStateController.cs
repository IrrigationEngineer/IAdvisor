﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.ViewModels.Reports;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.DBContext.Management;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Reports;
using IrrigationAdvisor.Models.Management;

using IrrigationAdvisor.Models.Utilities;
using System.Web.Helpers;
using System.Collections;
using IrrigationAdvisor.Models;





namespace IrrigationAdvisor.Controllers.Reports
{
    public class ReportPivotStateController : Controller
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        ReportPivotStateViewModel vm = new ReportPivotStateViewModel();
        private static long ciwId = 0;
        

        public ActionResult Index()
        {

            #region userdata
            User lLoggedUser;
            UserConfiguration uc;
            LoginViewModel lLoginViewModel;
            uc = new UserConfiguration();

            LoginViewModel localLgM = ManageSession.GetLoginViewModel();

            if (localLgM == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                lLoginViewModel = ManageSession.GetLoginViewModel();
            }
            lLoggedUser = uc.GetUserByName(lLoginViewModel.UserName);
            vm.IsUserAdministrator = (lLoggedUser.RoleId == (int)Utils.UserRoles.Administrator);
            #endregion

            ciwId = GetCropIrrigationWeatherIdFromURL();

            DailyRecordConfiguration drc = new DailyRecordConfiguration();
            List<DailyRecord> lDailyRecordList = new List<DailyRecord>();

            lDailyRecordList = drc.GetDailyRecordsListDataBy(ciwId);

            double lSumTotalEffectiveRain = 0;
            double lSumTotalEffectiveInputWater = 0;
            double lSumTotalEvapotranspirationCrop = 0;
            string lCropIrrigationWeatherTitle = "";


            foreach (DailyRecord item in lDailyRecordList)
            {
                if (item.Rain != null)
                    lSumTotalEffectiveRain = lSumTotalEffectiveRain + item.Rain.Input + item.Rain.ExtraInput; ;

                if (item.Irrigation != null)
                    lSumTotalEffectiveInputWater = lSumTotalEffectiveInputWater + item.Irrigation.Input + item.Irrigation.ExtraInput;

                lSumTotalEvapotranspirationCrop = item.TotalEvapotranspirationCrop;
                lCropIrrigationWeatherTitle = item.CropIrrigationWeather.ToString();
            }
            vm.TotalEffectiveRain = lSumTotalEffectiveRain;
            vm.TotalEffectiveInputWater = lSumTotalEffectiveInputWater;
            vm.TotalEvapotranspirationCrop = lSumTotalEvapotranspirationCrop;
            vm.Title = lCropIrrigationWeatherTitle;
            vm.CropIrrigationWeatherId = ciwId;
            return View("~/Views/ReportPivotState/ReportPivotState.cshtml", vm);
        }

        public ActionResult GetChart()
        {

            DailyRecordConfiguration drc = new DailyRecordConfiguration();
            List<DailyRecord> lDailyRecordList = new List<DailyRecord>();
            double lRain;
            double lIrrigation;
         

            lDailyRecordList = drc.GetLast30DaysDailyRecordsListDataBy(ciwId, Utils.GetDateOfReference().Value);
            
            ArrayList yArrayRain = new ArrayList();
            ArrayList yArrayIrrigation = new ArrayList();
            ArrayList yArrayETC = new ArrayList();
            ArrayList xValue = new ArrayList();
            int i = 1;

            foreach (DailyRecord item in lDailyRecordList)
            {
                lRain = 0;
                lIrrigation = 0;
                if (item.Rain != null)
                    lRain = item.Rain.Input + item.Rain.ExtraInput;
                if (item.Irrigation != null)
                    lIrrigation = item.Irrigation.ExtraInput + item.Irrigation.Input;

                if (lRain > 0 || lIrrigation > 0)
                {
                yArrayIrrigation.Add(lIrrigation);
                yArrayRain.Add(lRain);
                yArrayETC.Add(item.TotalEvapotranspirationCrop);
                xValue.Add(item.DaysAfterSowing);
                
                 }

            }
            new Chart(width: 1000, height: 400, theme: ChartTheme.Green)
               .AddTitle("Balance de agua últimos 30 días")
               .AddLegend()
               
               .SetYAxis("Cantidad (mm.)")
               .SetXAxis("Días de siembra", double.Parse(xValue[0].ToString())-2)
               .AddSeries("Lluvia", chartType: "Column", xValue: xValue, yValues: yArrayRain, markerStep: 57)
               .AddSeries("Riego", chartType: "Column", xValue: xValue, yValues: yArrayIrrigation, markerStep: 1)
               .AddSeries("ETc Acumulado", chartType: "Line", xValue: xValue, yValues: yArrayETC, markerStep: 1)
               .Write("bmp");
            
            return null;
        }

        public ActionResult CreateCVS()
        {
            ciwId = GetCropIrrigationWeatherIdFromURL();
            CropIrrigationWeatherConfiguration ciwc = new CropIrrigationWeatherConfiguration();

            String lDate = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            
            String lOutPut = ciwc.GetOutputByCropIrrigationWeatherId(ciwId);
            String lFileName = ciwc.GetNameByCropIrrigationWeatherId(ciwId);

            ///TODO implements file chosser
            //Application.StartupPath
            //Environment.CurrentDirectory

            String lFilePath = "C:\\ExitCSV\\";
            lFileName = lFileName + "_" + lDate + ".xls"; //".csv";
            Utils.ExportOutPutToCSV(lOutPut, lFilePath, lFileName);
            return RedirectToAction("Index");
        }

        [ChildActionOnly]
        public PartialViewResult ReportPivotStateHeaderPartial()
        {
            return PartialView("_ReportPivotStateHeaderPartial", GetGridDailyRecordIrrigationResumeTitles());
        }

        [ChildActionOnly]
        public PartialViewResult ReportPivotStatePartial()
        {
            return PartialView("_ReportPivotStatePartial", GetGridDailyRecordIrrigationResume());
        }

        /// <summary>
        /// Return Grid Datail from dailyrecord days
        /// </summary>
        /// <returns></returns>
        public List<GridDailyRecordIrrigationResume> GetGridDailyRecordIrrigationResumeTitles()
        {

            #region Local Variables
            List<GridDailyRecordIrrigationResume> lGridDailyRecordIrrigationResumeList = new List<GridDailyRecordIrrigationResume>();
            GridDailyRecordIrrigationResume lGridDailyRecordIrrigationResume;
            User lLoggedUser;


            #endregion

            #region Configuration Variables
            UserConfiguration uc;
            #endregion

            try
            {

                #region Configuration - Instance
                uc = new UserConfiguration();
                #endregion
                //Obtain logged user
                lLoggedUser = uc.GetUserByName(ManageSession.GetUserName());
                lGridDailyRecordIrrigationResume = new GridDailyRecordIrrigationResume("Día","Fecha", "Riego", "Lluvia");

                lGridDailyRecordIrrigationResumeList.Add(lGridDailyRecordIrrigationResume);

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in Reports.GetGridDailyRecordIrrigationResumeTitles");
                throw ex;
            }

            return lGridDailyRecordIrrigationResumeList;

        }


        /// <summary>
        /// Return Grid Datail from dailyrecord days
        /// </summary>
        /// <returns></returns>
        public List<GridDailyRecordIrrigationResume> GetGridDailyRecordIrrigationResume()
        {
            #region Local Variables

            List<GridDailyRecordIrrigationResume> lGridIrrigationUnitList = new List<GridDailyRecordIrrigationResume>();
            List<GridDailyRecordIrrigationResume> lGridDailyRecordIrrigationResumeList = new List<GridDailyRecordIrrigationResume>();
            GridDailyRecordIrrigationResume lGridDailyRecordIrrigationResume = null;

            string lEffectiveRain;
            string lEffectiveInputWater;
            double lEffectiveRainDouble;
            double lEffectiveInputWaterDouble;

            List<DailyRecord> lDailyRecordList;
            DailyRecordConfiguration drc;
            #endregion

            try
            {
                drc = new DailyRecordConfiguration();

                lDailyRecordList = drc.GetDailyRecordsListDataBy(ciwId);

                foreach (var lDailyRecordUnit in lDailyRecordList)
                {
                    lEffectiveRain = "";
                    lEffectiveInputWater = "";
                    lEffectiveRainDouble = 0;
                    lEffectiveInputWaterDouble = 0;

                    if (lDailyRecordUnit.Rain != null)
                    {
                        lEffectiveRainDouble = lDailyRecordUnit.Rain.ExtraInput + lDailyRecordUnit.Rain.Input;
                    }

                    if (lDailyRecordUnit.Irrigation != null)
                    {
                        lEffectiveInputWaterDouble = lDailyRecordUnit.Irrigation.ExtraInput + lDailyRecordUnit.Irrigation.Input;
                    }
                    if (lEffectiveRainDouble + lEffectiveInputWaterDouble > 0) // not input
                    {
                        if (lEffectiveRainDouble != 0)
                            lEffectiveRain = lEffectiveRainDouble.ToString();

                        if (lEffectiveInputWaterDouble != 0)
                            lEffectiveInputWater = lEffectiveInputWaterDouble.ToString();

                        lGridDailyRecordIrrigationResume = new GridDailyRecordIrrigationResume(lDailyRecordUnit.DaysAfterSowing.ToString(),lDailyRecordUnit.DailyRecordDateTime.ToShortDateString(), lEffectiveRain, lEffectiveInputWater);
                        lGridDailyRecordIrrigationResumeList.Add(lGridDailyRecordIrrigationResume);

                    }
                }
            }


            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotState.GetGridDailyRecordIrrigationResume \n {0} ");
                throw ex;
            }

            return lGridDailyRecordIrrigationResumeList;

        }

        private long GetCropIrrigationWeatherIdFromURL()
        {
            long retorno = 0;

            string lURL = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
            Uri lMyUri = new Uri(lURL);
            string lcurrentCiwViaUrl = System.Web.HttpUtility.ParseQueryString(lMyUri.Query).Get("ciw");

            if (!String.IsNullOrEmpty(lcurrentCiwViaUrl))
            {
                ciwId = Convert.ToInt32(lcurrentCiwViaUrl);
                retorno = ciwId;
            }
            else
            {
                retorno = ciwId;
            }
            return ciwId;
        }

    }
}
