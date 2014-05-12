using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WFC_Palvelu.Models.Mapping;

namespace WFC_Palvelu.Models
{
    public partial class KalenteriContext : DbContext
    {
        public KalenteriContext()
            : base("HarkkaprojektiDB")
        {

        }

        static KalenteriContext()
        {
            Database.SetInitializer<KalenteriContext>(null);
        }

        // Ominaisuudet
        public DbSet<Tapahtumatyyppi> TapahtumaTyypit { get; set; }
        public DbSet<Tapahtuma> Tapahtumat { get; set; }
        public DbSet<KayttajanTapahtumat> KayttajanTapahtumat { get; set; }
        public DbSet<Kayttaja> Kayttajat { get; set; }
        public DbSet<RyhmanJasenet> RyhmanJasenet { get; set; }
        public DbSet<Ryhma> Ryhmat { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new TapahtumatyyppiMap());
            modelBuilder.Configurations.Add(new TapahtumaMap());
            modelBuilder.Configurations.Add(new KayttajanTapahtumatMap());
            modelBuilder.Configurations.Add(new KayttajaMap());
            modelBuilder.Configurations.Add(new RyhmanJasenetMap());
            modelBuilder.Configurations.Add(new RyhmaMap());
        }
    }
}