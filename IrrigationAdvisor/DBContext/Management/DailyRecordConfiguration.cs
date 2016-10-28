﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using IrrigationAdvisor.Models.Management;

namespace IrrigationAdvisor.DBContext.Management
{
    public class DailyRecordConfiguration:
        EntityTypeConfiguration<DailyRecord>
    {
        public DailyRecordConfiguration()
        {
            ToTable("DailyRecord");
            HasKey(m => m.DailyRecordId);
            Property(m => m.DailyRecordId)
                .IsRequired();
            Property(c => c.DailyRecordDateTime)
                .IsRequired();
            Property(c => c.CropIrrigationWeatherId)
                .IsRequired();
            
        }
    }
}