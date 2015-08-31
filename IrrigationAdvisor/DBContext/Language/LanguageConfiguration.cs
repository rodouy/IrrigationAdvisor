using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor;

namespace IrrigationAdvisor.DBContext.Language
{
    public class LanguageConfiguration:
        EntityTypeConfiguration<Models.Language.Language>
    {
        public LanguageConfiguration()
        {
            ToTable("Language");
            HasKey(l => l.LanguageId);
            Property(l => l.LanguageId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(50);
            
        }
    }
}