using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Solution.Mapping
{
    class EventMap :EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            this.HasKey(e => e.EventId);

            this.Property(e => e.EventId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.TypeId).IsRequired();
            this.Property(e => e.Name).IsRequired().HasMaxLength(255);
            this.Property(e => e.Summary).IsOptional().HasMaxLength(255);
            this.Property(e => e.Location).IsOptional().HasMaxLength(255);
            this.Property(e => e.StartTime).IsRequired();
            this.Property(e => e.EndTime).IsRequired();

            this.ToTable("Event");
            this.Property(e => e.EventId).HasColumnName("EventId");
            this.Property(e => e.TypeId).HasColumnName("TypeId");
            this.Property(e => e.Name).HasColumnName("Name");
            this.Property(e => e.Summary).HasColumnName("Summary");
            this.Property(e => e.Location).HasColumnName("Location");
            this.Property(e => e.StartTime).HasColumnName("StartTime");
            this.Property(e => e.EndTime).HasColumnName("EndTime");

            this.HasRequired(e => e.EventType).WithMany(e => e.Events).HasForeignKey(e => e.TypeId);
        }
    }
}
