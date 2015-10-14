using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ProjectManager.Common.DAL;
using ProjectManager.Entity;

namespace ProjectManager.DAL
{
    public class DataContext : DbContext, IDataContext
    {
        public IDbSet<Issue> Issues { get; set; }
        public IDbSet<Project> Projects { get; set; }
        public IDbSet<Sprint> Sprints { get; set; }
        public IDbSet<Team> Teams { get; set; }
        public IDbSet<ApplicationUser> Users { get; set; }
        public IDbSet<ApplicationRole> Roles { get; set; }
        public IDbSet<Comment> Comments { get; set; }
        public IDbSet<Component> Components { get; set; }
        public IDbSet<Attachment> Attachments { get; set; }
 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().
                HasMany<ApplicationRole>(u => u.Roles).
                WithMany(r => r.Users).
                Map(up =>
                {
                    up.MapLeftKey("UserId");
                    up.MapRightKey("RoleId");
                    up.ToTable("UserRole");
                }
            );
            modelBuilder.Entity<Issue>().
                HasMany<Component>(i => i.Components).
                WithMany(c => c.Issues).
                Map(up =>
                {
                    up.MapLeftKey("IssueId");
                    up.MapRightKey("ComponentId");
                    up.ToTable("IssueComponent");
                }              
            );
        }

        public IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public DbEntityEntry Entry(object entity)
        {
            return base.Entry(entity);
        }

        public void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
