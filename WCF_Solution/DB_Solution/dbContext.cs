using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DB_Solution.Mapping;

namespace DB_Solution
{
    class dbContext : DbContext
    {
        public dbContext()
            : base("HarkkaprojektiDBEntities")
        {

        }
        static dbContext()
        {
            Database.SetInitializer<dbContext>(null);
        }

        public DbSet<Testitaulu> Testit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TestitauluMap());
            modelBuilder.Configurations.Add(new AttendeesMap());
            modelBuilder.Configurations.Add(new AttendeeStatusMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new EventTypeMap());
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new GroupMembersMap());
            modelBuilder.Configurations.Add(new UserMap());
        }


    }
}
