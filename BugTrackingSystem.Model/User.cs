using System.Collections.Generic;

namespace BugTrackingSystem.Model
{
    public class User
    {
        public int UserID { get; set; }

        public ICollection<Project> Projects { get; set; }

        public ICollection<Filter> Filters { get; set; }
        
        public ICollection<Bug> Bugs { get; set; }  

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public byte Role { get; set; }

        public string Photo { get; set; }
    }
}
