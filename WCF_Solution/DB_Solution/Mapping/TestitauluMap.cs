using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Solution.Mapping
{
    class TestitauluMap : EntityTypeConfiguration<Testitaulu> 
    {
        public TestitauluMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Nimi).IsRequired().HasMaxLength(20);

            this.ToTable("Testitaulu");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nimi).HasColumnName("Nimi");
        }
    }
}
