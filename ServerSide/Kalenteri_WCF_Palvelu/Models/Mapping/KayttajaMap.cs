using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WFC_Palvelu.Models.Mapping
{
    public class KayttajaMap : EntityTypeConfiguration<Kayttaja>
    {
        public KayttajaMap()
        {
            this.HasKey(k => k.KayttajaId);

            this.Property(k => k.KayttajaId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(k => k.Etunimi).IsRequired().HasMaxLength(30);
            this.Property(k => k.Sukunimi).IsRequired().HasMaxLength(30);
        }
    }
}