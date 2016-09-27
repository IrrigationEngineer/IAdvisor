﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using IrrigationAdvisor.Models.Data;
using NLog;

namespace IrrigationAdvisor.DBContext.Data
{
    public class StatusConfiguration :
        EntityTypeConfiguration<Status>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public StatusConfiguration()
        {
            ToTable("Status");
            HasKey(s => s.StatusId);
            Property(s => s.Name)
                .IsRequired();
            Property(s => s.DateOfReference)
                .IsRequired();
            Property(s => s.WebStatus)
                .IsRequired();

            #region Relationship

            #endregion
        }

        public Status GetStatus(string pName)
        {
            return (from s in db.Status
                    where s.Name.Equals(pName)
                    select s).Single();
        }

        public bool SetStatus(DateTime pDateOfReference, string pName)
        {
            bool lResult = false;
            try
            {
                Status status = GetStatus(pName);
                status.DateOfReference = pDateOfReference;
                db.SaveChanges();
                lResult = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                lResult = false;
            }

            return lResult;
        }
    }
}