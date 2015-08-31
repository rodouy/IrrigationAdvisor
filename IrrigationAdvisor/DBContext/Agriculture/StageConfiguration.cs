using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class StageConfiguration:
        EntityTypeConfiguration<Stage>
    {
        public StageConfiguration()
        {
            ToTable("Stage");
            HasKey(s => s.StageId);
            Property(s => s.StageId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired().HasMaxLength(50);
            
        }
    }
}