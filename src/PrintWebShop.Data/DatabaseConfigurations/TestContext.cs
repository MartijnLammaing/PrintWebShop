using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace PrintWebShop.Data.DatabaseConfigurations
{
    public class TestContext : DbContext
    {
        public DbSet<TestClass> TestClasses { get; set; }

        public TestContext()
        {
            Database.CreateIfNotExists();
        }

        public class TestContextInitializer : DropCreateDatabaseIfModelChanges<TestContext>
        {
            protected override void Seed(TestContext context)
            {
                base.Seed(context);
            }
        }
    }
}
