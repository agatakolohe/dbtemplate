using Microsoft.EntityFrameworkCore;
// using ProjectName.Models;

namespace ProjectName.Models //TODO
{
    public class ProjectNametContext : DbContext //TODO class inherits from Entity, ensures all builtin DbContext functionality
    {
        public virtual DbSet<ParentClassName> ParentClassNames { get; set; } //allows lazy loading
        public DbSet<ChildClass> ChildClassNames { get; set; } //represents the db table and lets interaction

        public ProjectNameContext(DbContextOptions options) : base(options) { } //dependency injection, constructor inherits the behavior of its parent class constructor

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //enables lazy-loading
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}