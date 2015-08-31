using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class PhenologicalStageConfiguration:
        EntityTypeConfiguration<PhenologicalStage>
    {
        public PhenologicalStageConfiguration()
        {
            ToTable("PhenologicalStage");
            HasKey(s => s.PhenologicalStageId);
            Property(s => s.PhenologicalStageId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.RootDepth)
                .IsRequired();
            Property(s => s.MinDegree)
                .IsRequired();
            Property(s => s.MaxDegree)
                .IsRequired();
        }
    }
}