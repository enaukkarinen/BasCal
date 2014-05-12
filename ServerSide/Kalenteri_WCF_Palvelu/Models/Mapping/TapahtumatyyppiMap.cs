using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WFC_Palvelu.Models.Mapping
{
    public class TapahtumatyyppiMap : EntityTypeConfiguration<Tapahtumatyyppi>
    {
        public TapahtumatyyppiMap()
        {
            this.HasKey(t => t.TyyppiId);

            this.Property(t => t.TyyppiId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Nimi).IsRequired().HasMaxLength(100);

            this.ToTable("Tapahtumatyyppi");
            this.Property(t => t.TyyppiId).HasColumnName("TyyppiId");
            this.Property(t => t.Nimi).HasColumnName("Nimi");         
        }
    }
}