using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using PrintWebShop.Data.Entities;

namespace PrintWebShop.Data.DatabaseConfigurations
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Parameter> Parameters { get; set; }

        public DatabaseContext()
        {
            Database.CreateIfNotExists();
        }
        
        public class ContextInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
        {
            protected override void Seed(DatabaseContext context)
            {
                base.Seed(context);
            }
        }
    }
}
