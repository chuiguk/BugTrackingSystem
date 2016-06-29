using System.Data.Entity;
using BugTrackingSystem.Data.Configuration;
using BugTrackingSystem.Model;

namespace BugTrackingSystem.Data.Context
{
    public class AsignarContext : DbContext
    {
        public AsignarContext(string connectionString)
            : base(connectionString)
        {
            this.Database.CommandTimeout = 1800;
            
        }
        public AsignarContext()
        {

        }

        public DbSet<Bug> Bugs { get; set; }

        public DbSet<BugAttachment> BugAttachments { get; set; }

        public DbSet<Filter> Filters { get; set; }

        public DbSet<Priority> Priorities { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BugConfig());
            modelBuilder.Configurations.Add(new BugAttachmentConfig());
            modelBuilder.Configurations.Add(new FilterConfig());
            modelBuilder.Configurations.Add(new PriorityConfig());
            modelBuilder.Configurations.Add(new ProjectConfig());
            modelBuilder.Configurations.Add(new UserConfig());
            modelBuilder.Configurations.Add(new StatusConfig());
            modelBuilder.Configurations.Add(new UserRoleConfig());
        }
    }
}
