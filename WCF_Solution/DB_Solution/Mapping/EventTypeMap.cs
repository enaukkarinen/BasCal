using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Solution.Mapping
{
    class EventTypeMap : EntityTypeConfiguration<EventType>
    {
        public EventTypeMap()
        {
            this.HasKey(e => e.TypeId);

            this.Property(e => e.TypeId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(e => e.Name).IsRequired().HasMaxLength(255);

            this.ToTable("EventType");
            this.Property(e => e.TypeId).HasColumnName("TypeId");
            this.Property(e => e.Name).HasColumnName("Name");

        }
    }
}
