namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Zero_Hunger.EF.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Zero_Hunger.EF.ZeroContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Zero_Hunger.EF.ZeroContext context)
        {
            //  This method will be called after migrating to the latest version.
            // Generate data for Collection
            /*     for (int i = 1; i <= 10; i++)
                    {
                        context.Collections.AddOrUpdate(
                            new Collection
                            {
                                Name = "Collection " + i
                            }
                        );
                    }

                    // Generate data for Employee
                    for (int i = 1; i <= 10; i++)
                    {
                        context.Employees.AddOrUpdate(
                            new Employee
                            {
                                Name = "Employee " + i,
                                CollectionId = i // Assign appropriate CollectionId
                            }
                        );
                    }

                   // Generate data for Restaurant
                    for (int i = 1; i <= 10; i++)
                    {
                        context.Restaurants.AddOrUpdate(
                            new Restaurant
                            {
                                Name = "Restaurant " + i,
                                CollectionId = i // Assign appropriate CollectionId
                            }
                        );
                    }*/

            // Generate data for Distribution


            //context.SaveChanges();

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
