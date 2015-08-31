using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Security;

namespace IrrigationAdvisor.DBContext.Security
{
    public class SiteItemConfiguration:
        EntityTypeConfiguration<SiteItem>
    {
        public SiteItemConfiguration()
        {
            ToTable("SiteItem");
            HasKey(s => s.SiteItemId);
            Property(s => s.SiteItemId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            
        }
    }
}