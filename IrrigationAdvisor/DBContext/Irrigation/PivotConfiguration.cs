using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Irrigation;

namespace IrrigationAdvisor.DBContext.Irrigation
{
    public class PivotConfiguration:
        EntityTypeConfiguration<Pivot>
    {
        public PivotConfiguration()
        {
            ToTable("Pivot");
            HasKey(p => p.IrrigationUnitId);
            Property(p => p.IrrigationUnitId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Name)
                .IsRequired();
            
        }
    }
}