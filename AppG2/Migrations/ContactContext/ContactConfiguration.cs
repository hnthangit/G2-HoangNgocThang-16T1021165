namespace AppG2.Migrations.ContactContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ContactConfiguration : DbMigrationsConfiguration<AppG2.Model.ContactG2Context>
    {
        public ContactConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ContactContext";
        }

        protected override void Seed(AppG2.Model.ContactG2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.ContactDbSet.AddOrUpdate(new Model.Contact
            {
                Id = "1",
                Name = "Thang",
                Phone = "123123",
                Email = "t@gmail.com",
                IdUser = "1"
            },
            new Model.Contact
            {
                Id = "2",
                Name = "Thanh",
                Phone = "123123",
                Email = "t@gmail.com",
                IdUser = "2"
            },
            new Model.Contact
            {
                Id = "3",
                Name = "huy",
                Phone = "123123",
                Email = "t@gmail.com",
                IdUser = "1"
            },
            new Model.Contact
            {
                Id = "4",
                Name = "Dung",
                Phone = "123123",
                Email = "t@gmail.com",
                IdUser = "2"
            },
            new Model.Contact
            {
                Id = "5",
                Name = "khai",
                Phone = "123123",
                Email = "t@gmail.com",
                IdUser = "1"
            },
            new Model.Contact
            {
                Id = "6",
                Name = "minh",
                Phone = "123123",
                Email = "t@gmail.com",
                IdUser = "2"
            },
            new Model.Contact
            {
                Id = "7",
                Name = "binh",
                Phone = "123123",
                Email = "t@gmail.com",
                IdUser = "1"
            },
            new Model.Contact
            {
                Id = "8",
                Name = "xuan",
                Phone = "123123",
                Email = "t@gmail.com",
                IdUser = "2"
            },
            new Model.Contact
            {
                Id = "9",
                Name = "yen",
                Phone = "123123",
                Email = "t@gmail.com",
                IdUser = "1"
            },
            new Model.Contact
            {
                Id = "10",
                Name = "dat",
                Phone = "123123",
                Email = "t@gmail.com",
                IdUser = "2"
            }
            );

            context.UserDbSet.AddOrUpdate(new Model.User
            {
                IdUser = "1",
                Username = "abc",
                Password = "123"
            },
            new Model.User
            {
                IdUser = "2",
                Username = "def",
                Password = "456"
            }
            );
        
            context.SaveChanges();
        }
    }
}
