using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DB_Solution.Mapping
{
    class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasKey(u => u.UserId);

            this.Property(u => u.UserId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(u => u.UserName).IsRequired().HasMaxLength(255);

            this.ToTable("User");
            this.Property(u => u.UserId).HasColumnName("UserId");
            this.Property(u => u.UserName).HasColumnName("UserName");

        }
    }
}
