﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Water;

namespace IrrigationAdvisor.DBContext.Water
{
    public class IrrigationConfiguration:
        EntityTypeConfiguration<Models.Water.Irrigation>
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        public IrrigationConfiguration()
        {
            ToTable("Irrigation");
            HasKey(w => w.WaterInputId);
            Property(w => w.WaterInputId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(w => w.Date)
                .IsRequired();
            Property(w => w.Input)
                .IsRequired();
            
        }



    }
}