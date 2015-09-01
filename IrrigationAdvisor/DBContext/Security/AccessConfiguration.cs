using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Security;

namespace IrrigationAdvisor.DBContext.Security
{
    public class AccessConfiguration:
        EntityTypeConfiguration<Access>
    {
        public AccessConfiguration()
        {
            ToTable("Access");
            HasKey(s => s.AccessId);
            Property(s => s.AccessId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            
        }
    }
}