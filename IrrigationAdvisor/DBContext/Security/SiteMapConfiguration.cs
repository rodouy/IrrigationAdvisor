using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Security;

namespace IrrigationAdvisor.DBContext.Security
{
    public class SiteMapConfiguration:
        EntityTypeConfiguration<Models.Security.SiteMap>
    {
        public SiteMapConfiguration()
        {
            ToTable("SiteMap");
            HasKey(s => s.SiteMapId);
            Property(s => s.SiteMapId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);
            
        }
    }
}