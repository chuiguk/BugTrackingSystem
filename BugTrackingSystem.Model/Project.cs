using System.Collections.Generic;

namespace BugTrackingSystem.Model
{
    public class Project
    {
        public Project()
        {
            Users = new HashSet<User>();
            Bugs = new HashSet<Bug>();
        }
        public int ProjectID { get; set; }

        public string Name { get; set; }

        public string Prefix { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual  ICollection<Bug> Bugs { get; set; } 
    }
}
