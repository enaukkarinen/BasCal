using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Solution.Mapping
{
    class AttendeeStatusMap : EntityTypeConfiguration<AttendeeStatus>
    {
        public AttendeeStatusMap()
        {
            this.HasKey(a => a.StatusId);

            this.Property(a => a.StatusId).IsRequired();
            this.Property(a => a.Name).IsRequired().HasMaxLength(255);

            this.ToTable("AttendeeStatus");
            this.Property(a => a.StatusId).HasColumnName("StatusId");
            this.Property(a => a.Name).HasColumnName("Name");
        }
    }
}
