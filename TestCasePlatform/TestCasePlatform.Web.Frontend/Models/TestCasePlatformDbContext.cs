using System.Data.Entity;
using TestCasePlatform.Data;

namespace TestCasePlatform.Web.Frontend.Models
{
    public class TestCasePlatformDbContext : DbContext
    {
        public TestCasePlatformDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<TestProject> TestProjects { get; set; }
    }
}