using System.ComponentModel.DataAnnotations;

namespace BugTrackingSystem.Model
{
    public class Filter
    {
        public int FilterID { get; set; }

        public User User { get; set; }

        public string Project { get; set; }

        public string AssignedUser { get; set; }

        public string Title { get; set; }

        public string Search { get; set; }

        public string Status { get; set; }

        public string BugPriority { get; set; }
    }
}
