namespace ConsoleApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleApplication2.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ConsoleApplication2.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Customers.AddOrUpdate(
                p => p.Name,
                new Customer {Login = "Brainfucker", Name = "Andrew Peters"}
                );
            context.SaveChanges();

            context.Products.AddOrUpdate(
                p => p.ID,
                new Product { ProductName = "Cover", Rate = 4, Price = 1000 },
                new Product { ProductName = "Charger", Rate = 5, Price = 2000 },
                new Product { ProductName = "Battery", Rate = 3, Price = 1000 }
                );
            context.SaveChanges();
        }
    }
}
