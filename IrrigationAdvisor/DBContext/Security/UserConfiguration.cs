using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Security;

namespace IrrigationAdvisor.DBContext.Security
{
    public class UserConfiguration:
        EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("User");
            HasKey(s => s.UserId);
            Property(s => s.UserId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            Property(s => s.Surname)
                .IsRequired()
                .HasMaxLength(50);
            Property(s => s.UserName)
                .IsRequired()
                .HasMaxLength(50);
            Property(s => s.Password)
                .IsRequired()
                .HasColumnType("Password");
            Property(s => s.Phone)
                .IsRequired();

            
        }
    }
}