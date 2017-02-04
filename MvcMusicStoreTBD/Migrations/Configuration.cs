namespace MvcMusicStoreTBD.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMusicStoreTBD.Models.MusicStoreDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMusicStoreTBD.Models.MusicStoreDBContext";
        }

        //PM> Enable-Migrations -ContextTypeName MvcMusicStoreTBD.Models.MusicStoreDBContext //To generate this

        protected override void Seed(MvcMusicStoreTBD.Models.MusicStoreDBContext context)
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

            context.Users.AddOrUpdate(i => i.FirstName,
                new User
                {
                    FirstName = "Ove",
                    LastName = "Larsen",
                    UserName = "OveLa",
                    Password = "ppp",
                    PasswordComp = "ppp"
                    //Email = "",
                    ,BirthDay = DateTime.Parse("1989-1-11")
                    ,Comment = "My comment to him"
                    ,HashStr = "r3-TD3oerD72hD-c.ewq"
                });


        }
    }
}
