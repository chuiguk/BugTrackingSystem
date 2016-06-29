using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugTrackingSystem.Model
{
    public class Bug
    {
        public Bug()
        {
            BugAttachments = new HashSet<BugAttachment>();
        }
        public int BugID { get; set; }

        public User User { get; set; }

        public Project Project { get; set; }

        public int Number { get; set; }

        public string Subject { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModificationDate { get; set; }

        public byte Status { get; set; }

        public byte Priority { get; set; }

        public string Description { get; set; }

        public virtual ICollection<BugAttachment> BugAttachments { get; set; }

        public string Comments { get; set; }
    }
}
