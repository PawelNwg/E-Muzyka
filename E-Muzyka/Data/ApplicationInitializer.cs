using E_Muzyka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Muzyka.Data
{
    public class ApplicationInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
                return;

            var Users = new AppUser[]
            {
                new AppUser{UserName = "Pawel", Name = "Pawel", Surname = "Nieweglowski", PhoneNumber = "123456789" },
            };
            foreach (AppUser a in Users)
            {
                context.Users.Add(a);
            }
            context.SaveChanges();

            var Albums = new Album[]
            {
                new Album{Artist = "Taco Hemingway", Title = "Flagey", Version = "Bonus", Year = 2018},
                new Album{Artist = "Taco Hemingway", Title = "Trójkąt Warszawski", Version = "Standard", Year = 2014},
            };
            foreach (Album a in Albums)
            {
                context.Albums.Add(a);
            }
            context.SaveChanges();

            var Tracks = new Track[]
            {
                new Track{Title = "900729", Artist = "Taco Hemingway", Year = 2014, Duration = new TimeSpan(0,5,04), AlbumId = 1},
                new Track{Title = "Mięso", Artist = "Taco Hemingway", Year = 2014, Duration = new TimeSpan(0,4,19), AlbumId = 1},
                new Track{Title = "Wszystko jedno", Artist = "Taco Hemingway", Year = 2014, Duration = new TimeSpan(0,5,12), AlbumId = 1},
                new Track{Title = "Marsz, marsz", Artist = "Taco Hemingway", Year = 2014, Duration = new TimeSpan(0,3,53), AlbumId = 1},
                new Track{Title = "Szlugi i kalafiory", Artist = "Taco Hemingway", Year = 2014, Duration = new TimeSpan(0,3,07), AlbumId = 1},
                new Track{Title = "Bakayoko", Artist = "Taco Hemingway", Year = 2018, Duration = new TimeSpan(0,3,39), AlbumId = 2},
                new Track{Title = "Pokedex", Artist = "Taco Hemingway", Year = 2018, Duration = new TimeSpan(0,3,35), AlbumId = 2},
                new Track{Title = "Anja", Artist = "Taco Hemingway", Year = 2018, Duration = new TimeSpan(0,3,10), AlbumId = 2},
                new Track{Title = "Czarna kawa czeka", Artist = "Taco Hemingway", Year = 2018, Duration = new TimeSpan(0,3,30), AlbumId = 2},
                new Track{Title = "Italodisco", Artist = "Taco Hemingway", Year = 2018, Duration = new TimeSpan(0,2,56), AlbumId = 2},
            };
            foreach (Track t in Tracks)
            {
                context.Tracks.Add(t);
            }
            context.SaveChanges();
        }
    }
}