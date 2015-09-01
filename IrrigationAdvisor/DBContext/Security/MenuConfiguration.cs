using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Security;

namespace IrrigationAdvisor.DBContext.Security
{
    public class MenuConfiguration:
        EntityTypeConfiguration<Menu>
    {
        public MenuConfiguration()
        {
            ToTable("Menu");
            HasKey(s => s.MenuId);
            Property(s => s.MenuId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            
        }
    }
}