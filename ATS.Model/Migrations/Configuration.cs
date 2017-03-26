namespace test1.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<test1.Context.TrainingManagementDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "test1.Context.TrainingManagementDBContext";
        }

        protected override void Seed(test1.Context.TrainingManagementDBContext db)
        {
            db.Institutes.AddOrUpdate(
                new[]
            {
                new Institute() {Id = 1, Name = "BITM"},
                new Institute() {Id = 2, Name = "TechnoBD"},
                new Institute() {Id = 3, Name = "BASIS"}
            }
            );
            db.Branchs.AddOrUpdate(new[]
                {
               new Branch() {Id = 1, InstituteId = 1, Name = "Dhaka"},
               new Branch() {Id = 2, InstituteId = 1, Name = "CTG"},
               new Branch() {Id = 3, InstituteId = 2, Name = "Dhaka HQ"}
           });

            db.SaveChanges();
        }
    }
}
