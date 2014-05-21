using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DB_Solution.Mapping;

namespace DB_Solution
{
    class EventDataContext : DbContext
    {
        public EventDataContext()
            : base("HarkkaprojektiDBEntities")
        {

        }
        static EventDataContext()
        {
            Database.SetInitializer<EventDataContext>(null);
        }

        public DbSet<Testitaulu> Testit { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendees> Attendees { get; set; }
        public DbSet<AttendeeStatus> AttendeeStatusses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupMembers> GroupMembers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TestitauluMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new EventTypeMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new AttendeesMap());
            modelBuilder.Configurations.Add(new AttendeeStatusMap());
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new GroupMembersMap());

        }


    }
}
