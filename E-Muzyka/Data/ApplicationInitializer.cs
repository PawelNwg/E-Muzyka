using E_Muzyka.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Muzyka.Data
{
    public class ApplicationInitializer
    {
        public static async Task Initialize(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
                return;

            var user = new AppUser { UserName = "pawelnwg@gmail.com", Email = "pawelnwg@gmail.com", Name = "Paweł", Surname = "Niewęgłowski", EmailConfirmed = true };
            await userManager.CreateAsync(user, "Haslo1234%");

            var Albums = new Album[]
            {
                new Album{Artist = "Taco Hemingway", Title = "Flagey", Version = "Bonus", Year = 2018, AppUser = user},
                new Album{Artist = "Taco Hemingway", Title = "Trójkąt Warszawski", Version = "Standard", Year = 2011, AppUser = user},
                new Album{Artist = "Taco Hemingway", Title = "Marmur", Version = "Standard", Year = 2016, AppUser = user},
                new Album{Artist = "Queen", Title = "Queen", Version = "Remaster", Year = 2011, AppUser = user},
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
                new Track{Title = "Marmur", Artist = "Taco Hemingway", Year = 2016, Duration = new TimeSpan(0,5,10), AlbumId = 3},
                new Track{Title = "Witaj w hotelu Marmur", Artist = "Taco Hemingway", Year = 2016, Duration = new TimeSpan(0,0,50), AlbumId = 3},
                new Track{Title = "Żyrandol", Artist = "Taco Hemingway", Year = 2016, Duration = new TimeSpan(0,3,50), AlbumId = 3},
                new Track{Title = "Krwawa Jesień", Artist = "Taco Hemingway", Year = 2016, Duration = new TimeSpan(0,4,22), AlbumId = 3},
                new Track{Title = "Grubo-chude psy", Artist = "Taco Hemingway", Year = 2016, Duration = new TimeSpan(0,2,49), AlbumId = 3},
                new Track{Title = "Portier!", Artist = "Taco Hemingway", Year = 2016, Duration = new TimeSpan(0,0,50), AlbumId = 3},
                new Track{Title = "Mgła I", Artist = "Taco Hemingway", Year = 2016, Duration = new TimeSpan(0,3,54), AlbumId = 3},
                new Track{Title = "Mgła II", Artist = "Taco Hemingway", Year = 2016, Duration = new TimeSpan(0,3,43), AlbumId = 3},
                new Track{Title = "Świecące prostokąty", Artist = "Taco Hemingway", Year = 2016, Duration = new TimeSpan(0,4,17), AlbumId = 3},
                new Track{Title = "Tsunami blond", Artist = "Taco Hemingway", Year = 2016, Duration = new TimeSpan(0,2,56), AlbumId = 3},
                new Track{Title = "Deszcz na betonie", Artist = "Taco Hemingway", Year = 2016, Duration = new TimeSpan(0,3,53), AlbumId = 3},
                new Track{Title = "Keep Yourself Alive", Artist = "Queen", Year = 2011, Duration = new TimeSpan(0,3,47), AlbumId = 4},
                new Track{Title = "Doing Alright", Artist = "Queen", Year = 2011, Duration = new TimeSpan(0,4,09), AlbumId = 4},
                new Track{Title = "Liar", Artist = "Queen", Year = 2011, Duration = new TimeSpan(0,6,23), AlbumId = 4},
            };
            foreach (Track t in Tracks)
            {
                context.Tracks.Add(t);
            }
            context.SaveChanges();
        }
    }
}