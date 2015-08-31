using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class CropInformationByDateConfiguration
        : EntityTypeConfiguration<CropInformationByDate>
    {
        public CropInformationByDateConfiguration()
        {

            ToTable("CropInformationByDate");
            HasKey(c => c.CropInformationByDateId);
            Property(c => c.CropInformationByDateId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.CurrentDate)
                .IsRequired();

            #region Relationship
            HasRequired(a => a.Specie)
                .WithRequiredDependent();
            HasRequired(a => a.CropCoefficient)
                .WithRequiredDependent();
            HasRequired(a => a.PhenologicalStageList)
                .WithMany();
            HasRequired(a => a.Stage)
                .WithOptional();
            #endregion
        }
    }
}