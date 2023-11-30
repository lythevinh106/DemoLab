using Microsoft.EntityFrameworkCore;
using ProjectDemo.Models.Contracts;
using ProjectDemo.Models.Modules.User.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDemo.Models
{
    public class ProjectDemoDbContext : DbContext
    {
        public ProjectDemoDbContext()
        {

        }

        public ProjectDemoDbContext(DbContextOptions<ProjectDemoDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entities = typeof(ITable).Assembly.GetTypes().Where(x => typeof(ITable).IsAssignableFrom(x))
                                .Where(x => !x.IsInterface).ToList();
            foreach (var m in entities)
            {
                var entity = modelBuilder.Entity(m);

                if (typeof(ISeedable).IsAssignableFrom(m))
                {
                    var inst = Activator.CreateInstance(m) as ISeedable;
                    var data = inst.Seed();

                    foreach (var d in data)
                        entity.HasData(d);
                }
            }
        }
    }
}
