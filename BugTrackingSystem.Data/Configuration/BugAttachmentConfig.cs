using System.Data.Entity.ModelConfiguration;
using BugTrackingSystem.Model;

namespace BugTrackingSystem.Data.Configuration
{
    class BugAttachmentConfig : EntityTypeConfiguration<BugAttachment>
    {
        public BugAttachmentConfig()
        {
            HasKey(b => b.BugAttachmentID);
            Property(b => b.Attachment).IsRequired().HasMaxLength(1100);
        }
    }
}