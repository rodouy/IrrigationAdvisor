using System;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class CropConfiguration :
        EntityTypeConfiguration<Crop>
    {
        
        public CropConfiguration()
        {
            ToTable("Crop");
            HasKey(c => c.CropId);
            Property(c => c.CropId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);
            Property(c => c.RegionId)
                .IsRequired();
            Property(c => c.SpecieId)
                .IsRequired();
            Property(c => c.MaxEvapotranspirationToIrrigate)
                .IsRequired();
            Property(c => c.MinEvapotranspirationToIrrigate)
                .IsRequired();

            #region Relationship
            HasRequired(l => l.Region)
                .WithRequiredDependent();
            HasRequired(a => a.Specie)
                .WithRequiredDependent();
            HasRequired(a => a.CropCoefficient)
                .WithRequiredDependent();
            HasMany(a => a.StageList)
                .WithOptional();
            HasMany(a => a.PhenologicalStageList)
                .WithOptional();
            #endregion
        }
            
    }
}