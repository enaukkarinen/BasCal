using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WFC_Palvelu.Models.Mapping
{
    public class KayttajanTapahtumatMap : EntityTypeConfiguration<KayttajanTapahtumat>
    {
        public KayttajanTapahtumatMap()
        {
            this.HasKey(k => new { k.KayttajaId, k.TapahtumaId});

            this.Property(k => k.TapahtumaId).IsRequired();
            this.Property(k => k.KayttajaId).IsRequired();

            this.ToTable("KayttajanTapahtumat");
            this.Property(k => k.TapahtumaId).HasColumnName("TapahtumaId");
            this.Property(k => k.KayttajaId).HasColumnName("KayttajaId");

            this.HasRequired(k => k.Kayttaja).WithMany(k => k.KayttajanTapahtumat).HasForeignKey(d => d.KayttajaId);
            this.HasRequired(k => k.Tapahtuma).WithMany(k => k.KayttajanTapahtumat).HasForeignKey(d => d.TapahtumaId);
        }
    }
}