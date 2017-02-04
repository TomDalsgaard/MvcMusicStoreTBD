using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStoreTBD.Models
{
    public class MusicStoreDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDBContext>
    {
        protected override void Seed(MusicStoreDBContext context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan"
            });

            context.Artists.Add(new Models.Artist { Name = "Gasolin" });
            //context.Artists.Add(new Models.Artist { Name = "Bach" });
            context.Genres.Add(new Genre { Name = "Folk Rock", Description="Folk descr" });
            context.Albums.Add(new Album
            {
                Title= "Moonlight sonate",
                Artist= new Artist { Name="Bethoven"},
                Genre = new Genre { Name="Classic", Description = "You Know Classic descr" },
                Price = 7.95m
            });

            //var bach = context.Artists.Find(3);
            //var bach = new Artist();
            //var bach = new Models.Artist();
            //bach = context.Artists.Find(3);
            //bach = context.Artists.Find("ArtistID= 3");
            //var clas = context.Genres.Find(3);

            context.Albums.Add(new Album
            {
                Title = "dgdg",
                Artist = new Artist { Name = "Bach" },
                //Artist = bach, //new Artist(context.Artists.Find(4)),
                //Genre = clas, // context.Genres.Find(4),
                Genre = new Genre { Name = "Classic", Description = "You Know Classic descr" }, // context.Genres.Find(4),
                Price = 7.95m
            });

            //context.Users.Add(new User
            //{
            //    FirstName="Ove",
            //    LastName="Larsen",
            //    UserName="OveLa",
            //    Password="ppp"
            //});

            context.Users.Add(new User
            {
                FirstName = "Otto",
                LastName = "Nielsen",
                UserName = "Otto",
                Password = "ppp",
                PasswordComp = "ppp"
                ,BirthDay = DateTime.Parse("1979-10-05")
            });

            context.Users.Add(new User
            {
                FirstName = "Hans Christian"
                ,LastName = "Greve"
                ,UserName = "Hans"
                ,Password = "ppp"
                ,PasswordComp = "ppp"
                ,BirthDay = DateTime.Parse("1965-12-05")
            });

            base.Seed(context);
        }
    }
}