using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Solution.Mapping
{
    class GroupMap : EntityTypeConfiguration<Group> 
    {
        public GroupMap()
        {
            this.HasKey(g => g.GroupId);

            this.Property(g => g.GroupId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(g => g.Name).IsRequired().HasMaxLength(255);

            this.ToTable("Group");
            this.Property(g => g.GroupId).HasColumnName("GroupId");
            this.Property(g => g.Name).HasColumnName("Name");
        }
    }
}
