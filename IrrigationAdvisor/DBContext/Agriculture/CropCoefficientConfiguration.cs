using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class CropCoefficientConfiguration
        : EntityTypeConfiguration<CropCoefficient>
    {
        public CropCoefficientConfiguration()
        {
            ToTable("CropCoefficient");
            HasKey(c => c.CropCoefficientId);
            Property(c => c.CropCoefficientId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            #region Relationship

            #endregion
        }
    }
}