using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Irrigation;

namespace IrrigationAdvisor.DBContext.Irrigation
{
    public class BombConfiguration:
        EntityTypeConfiguration<Bomb>
    {
        public BombConfiguration()
        {
            ToTable("Bomb");
            HasKey(c => c.BombId);
            Property(c => c.BombId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name)
                .IsRequired();
            
        }
    }
}