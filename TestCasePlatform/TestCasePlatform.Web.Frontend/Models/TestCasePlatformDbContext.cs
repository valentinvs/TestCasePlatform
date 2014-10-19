using System.Data.Entity;
using TestCasePlatform.Data;
using TestCasePlatform.Web.Frontend.Migrations;

namespace TestCasePlatform.Web.Frontend.Models
{
    public class TestCasePlatformDbContext : DbContext
    {
        public TestCasePlatformDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<TestProject> TestProjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TestCasePlatformDbContext, Configuration>());
        }
    }
}