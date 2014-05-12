using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WFC_Palvelu.Models.Mapping
{
    public class RyhmanJasenetMap : EntityTypeConfiguration<RyhmanJasenet>
    {
        public RyhmanJasenetMap()
        {
            this.HasKey(r => new { r.KayttajaId, r.RyhmaId});

            this.Property(r => r.KayttajaId).IsRequired();
            this.Property(r => r.RyhmaId).IsRequired();
            this.Property(r => r.Rooli).IsOptional().HasMaxLength(50);

            this.ToTable("RyhmanJasenet");
            this.Property(r => r.KayttajaId).HasColumnName("KayttajaId");
            this.Property(r => r.RyhmaId).HasColumnName("RyhmaId");
            this.Property(r => r.Rooli).HasColumnName("Rooli");

            this.HasRequired(r => r.Kayttaja).WithMany(r => r.RyhmanJasenet).HasForeignKey(d => d.KayttajaId);
            this.HasRequired(r => r.Ryhma).WithMany(r => r.RyhmanJasenet).HasForeignKey(d => d.RyhmaId);
        }
    }
}