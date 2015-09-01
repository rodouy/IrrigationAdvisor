using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Irrigation;

namespace IrrigationAdvisor.DBContext.Irrigation
{
    public class DripConfiguration:
        EntityTypeConfiguration<Drip>
    {
        public DripConfiguration()
        {
            ToTable("Drip");
            HasKey(c => c.IrrigationUnitId);
            Property(c => c.IrrigationUnitId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name)
                .IsRequired();
        }
    }
}