﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Security;

namespace IrrigationAdvisor.DBContext.Security
{
    public class RoleConfiguration:
        EntityTypeConfiguration<Role>
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        public RoleConfiguration()
        {
            ToTable("Role");
            HasKey(s => s.RoleId);
            Property(s => s.RoleId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);
            
        }

        public List<Role> GetAllRoles()
        {
            return db.Roles.ToList();
        }

    }
}
