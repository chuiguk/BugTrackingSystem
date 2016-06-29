using System.Data.Entity.ModelConfiguration;
using BugTrackingSystem.Model;

namespace BugTrackingSystem.Data.Configuration
{
    class FilterConfig : EntityTypeConfiguration<Filter>
    {
        public FilterConfig()
        {
            HasKey(f => f.FilterID);
            Property(f => f.Project).IsOptional().HasColumnType("nvarchar");
            Property(f => f.AssignedUser).IsOptional().HasColumnType("nvarchar");
            Property(f => f.Title).IsOptional().HasMaxLength(200).HasColumnType("nvarchar");
            Property(f => f.Search).IsOptional().HasMaxLength(200).HasColumnType("nvarchar");
            Property(f => f.BugPriority).IsOptional();
            Property(f => f.Status).IsOptional();
        }
    }
}