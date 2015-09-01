using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using IrrigationAdvisor.Models.Weather;


namespace IrrigationAdvisor.Templates
{
    public class ConfigurationTemplate :
        EntityTypeConfiguration<ClassTemplate>
    {
        
        public ConfigurationTemplate()
        {
            ToTable("ClassTemplate");
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired();

            #region Relationship

            #endregion
        }
    
    }
}