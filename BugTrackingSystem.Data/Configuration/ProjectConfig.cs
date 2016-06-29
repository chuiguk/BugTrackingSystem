using System.Data.Entity.ModelConfiguration;
using BugTrackingSystem.Model;

namespace BugTrackingSystem.Data.Configuration
{
    class ProjectConfig : EntityTypeConfiguration<Project>
    {
        public ProjectConfig()
        {
            HasKey(p => p.ProjectID);
            Property(p => p.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
            Property(p => p.Prefix).IsRequired().HasMaxLength(3).HasColumnType("nvarchar");
        }
    }
}