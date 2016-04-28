using AngularTest.Models;

namespace AngularTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularTest.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AngularTest.Models.ApplicationDbContext context)
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

            context.Cars.AddOrUpdate(x=> new { x.Make, x.Model, x.Year},
                    new Car() { Make = "Honda", Model = "Accord", Year = 2009, Color = "HellifIknow"},
                    new Car() { Make = "Nissian", Model = "Sentra", Year = 2012, Color = "Definately Blue"}
            );

            context.SaveChanges();
        }
    }
}
