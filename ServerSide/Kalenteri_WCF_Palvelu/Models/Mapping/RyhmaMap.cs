using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WFC_Palvelu.Models.Mapping
{
    public class RyhmaMap : EntityTypeConfiguration<Ryhma>
    {
        public RyhmaMap()
        {
            this.HasKey(r => r.RyhmaId);

            this.Property(r => r.RyhmaId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(r => r.Nimi).IsRequired().HasMaxLength(100);

            this.ToTable("Ryhma");
            this.Property(r => r.RyhmaId).HasColumnName("RyhmaId");
            this.Property(r => r.Nimi).HasColumnName("Nimi");
        }
    }
}