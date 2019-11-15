namespace AppG2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppG2.Model.AppG2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppG2.Model.AppG2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.StudentDbSet.AddOrUpdate(new Model.Student
            {
                IDStudent = "16T1021165",
                FirstName = "Thang",
                LastName = "Hung",
                DOB = new DateTime(2000, 1, 1),
                POB = "hue",
                Gender = Model.GENDER.Male
            },
            new Model.Student
            {
                IDStudent = "16T1021166",
                FirstName = "Thang",
                LastName = "Hung",
                DOB = new DateTime(2000, 1, 1),
                POB = "hue",
                Gender = Model.GENDER.Male
            }


            );
           

            for (int i = 0; i < 12; i++)
            {
                context.HistoryLearningsDbSet.AddOrUpdate(
                  new Model.HistoryLearning
                  {
                      IDStudent = "16T1021165",
                      IDHistoryLearning = Guid.NewGuid().ToString(),
                      Address = "Hue",
                      YearFrom = 2010,
                      YearEnd = 2020
                  }               
                  ) ;

            }
            context.SaveChanges();

        }
    }
}
