using System.ComponentModel.DataAnnotations;

namespace BugTrackingSystem.Model
{
    public class BugAttachment
    {
        public int BugAttachmentID { get; set; }

        public Bug Bug { get; set; }

        public string Attachment { get; set; }
    }
}
