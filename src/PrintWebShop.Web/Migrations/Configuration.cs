using System.Data.Entity.Migrations;
using PrintWebShop.Data.DatabaseConfigurations;

namespace PrintWebShop.Migrations
{
    public class Configuration : DbMigrationsConfiguration<TestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}