using System.Data.Entity.ModelConfiguration;
using BugTrackingSystem.Model;

namespace BugTrackingSystem.Data.Configuration
{
    class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            HasKey(u => u.UserID);
            Property(u => u.FirstName).IsRequired().HasMaxLength(35).HasColumnType("nvarchar");
            Property(u => u.LastName).IsRequired().HasMaxLength(35).HasColumnType("nvarchar");
            Property(u => u.Login).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");
            Property(u => u.Password).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");
            Property(u => u.Email).IsRequired().HasMaxLength(255).HasColumnType("nvarchar");
            Property(u => u.Role).IsRequired().HasColumnType("tinyint");
            Property(u => u.Photo).IsOptional();
            }
    }
}