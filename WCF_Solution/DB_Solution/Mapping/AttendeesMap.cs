using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Solution.Mapping
{
    class AttendeesMap : EntityTypeConfiguration<Attendees>
    {
        public AttendeesMap()
        {
            this.HasKey(a => new { a.UserId, a.EventId });

            this.Property(a => a.UserId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.EventId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(a => a.AttendeeStatusId).IsRequired();

            this.ToTable("Attendees");
            this.Property(a => a.UserId).HasColumnName("UserId");
            this.Property(a => a.EventId).HasColumnName("EventId");
            this.Property(a => a.AttendeeStatusId).HasColumnName("AttendeeStatusId");

            this.HasRequired(a => a.User).WithMany(u => u.Attendees).HasForeignKey(a => a.UserId);
            this.HasRequired(a => a.Event).WithMany(u => u.Attendees).HasForeignKey(a => a.EventId);
            this.HasRequired(a => a.AttendeeStatus).WithMany(u => u.Attendees).HasForeignKey(a => a.AttendeeStatusId);
        }
    }
}
