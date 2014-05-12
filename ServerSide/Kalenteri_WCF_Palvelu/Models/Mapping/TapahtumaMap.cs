using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WFC_Palvelu.Models.Mapping
{
    public class TapahtumaMap : EntityTypeConfiguration<Tapahtuma>
    {
        public TapahtumaMap()
        {
            this.HasKey(t => t.TapahtumaId);

            this.Property(t => t.TapahtumaId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.TyyppiId).IsRequired();
            this.Property(t => t.AlkamisAika).IsRequired();
            this.Property(t => t.PaattymisAika).IsRequired();
            this.Property(t => t.Paikka).IsOptional().HasMaxLength(100);
            this.Property(t => t.Nimi).IsRequired().HasMaxLength(100);
            this.Property(t => t.Kuvaus).IsOptional().HasMaxLength(300);

            this.ToTable("Tapahtuma");
            this.Property(t => t.TapahtumaId).HasColumnName("TapahtumaId");
            this.Property(t => t.TyyppiId).HasColumnName("TyyppiId");
            this.Property(t => t.AlkamisAika).HasColumnName("AlkamisAika");
            this.Property(t => t.PaattymisAika).HasColumnName("PaattymisAika");
            this.Property(t => t.Paikka).HasColumnName("Paikka");
            this.Property(t => t.Nimi).HasColumnName("Nimi");
            this.Property(t => t.Kuvaus).HasColumnName("Kuvaus");

            this.HasRequired(t => t.TapahtumaTyyppi).WithMany(t => t.Tapahtumat).HasForeignKey(d => d.TyyppiId);
        }
    }
}