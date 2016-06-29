using System.Data.Entity.ModelConfiguration;
using BugTrackingSystem.Model;

namespace BugTrackingSystem.Data.Configuration
{
    class BugConfig : EntityTypeConfiguration<Bug>
    {
        public BugConfig()
        {
            HasKey(b => b.BugID);
            Property(b => b.Subject).IsRequired().HasMaxLength(200).HasColumnType("nvarchar");
            Property(b => b.CreationDate).HasColumnType("datetime2").IsRequired();
            Property(b => b.ModificationDate).HasColumnType("datetime2").IsRequired();
            Property(b => b.Status).IsRequired().HasColumnType("tinyint");
            Property(b => b.Priority).IsRequired().HasColumnType("tinyint");
            Property(b => b.Description).IsRequired().HasColumnType("nvarchar");
            Property(b => b.Comments).IsOptional();
        }
    }
}