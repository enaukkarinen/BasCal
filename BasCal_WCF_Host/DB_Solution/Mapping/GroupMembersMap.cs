using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Solution.Mapping
{
    class GroupMembersMap : EntityTypeConfiguration<GroupMembers>
    {
        public GroupMembersMap()
        {
            this.HasKey(g => new { g.GroupId, g.UserId});

            this.Property(g => g.GroupId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(g => g.UserId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(g => g.Role).IsOptional().HasMaxLength(50);

            this.ToTable("GroupMembers");
            this.Property(g => g.GroupId).HasColumnName("GroupId");
            this.Property(g => g.UserId).HasColumnName("UserId");
            this.Property(g => g.Role).HasColumnName("Role");

            this.HasRequired(g => g.Group).WithMany(g => g.GroupMembers).HasForeignKey(d => d.GroupId);
            this.HasRequired(g => g.User).WithMany(g => g.GroupMembers).HasForeignKey(d => d.UserId);
        }
    }
}
