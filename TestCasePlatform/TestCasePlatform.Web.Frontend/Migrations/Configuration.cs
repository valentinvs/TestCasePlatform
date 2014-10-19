namespace TestCasePlatform.Web.Frontend.Migrations
{
    using System.Data.Entity.Migrations;
    using Models;

    public class Configuration : DbMigrationsConfiguration<TestCasePlatformDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
