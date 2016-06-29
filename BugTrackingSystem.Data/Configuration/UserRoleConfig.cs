using System.Data.Entity.ModelConfiguration;
using BugTrackingSystem.Model;

namespace BugTrackingSystem.Data.Configuration
{
    class UserRoleConfig : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfig()
        {
            HasKey(u => u.UserRoleID);
            Property(u => u.Name).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
        }
    }
}