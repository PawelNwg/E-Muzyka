using E_Muzyka.Helpers;
using E_Muzyka.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Muzyka.ModelDTO
{
    public class AlbumDTO
    {
        public int Id { get; set; }

        [Display(Name = "Artysta")]
        public string Artist { get; set; }

        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Display(Name = "Wersja")]
        public string Version { get; set; }

        [Display(Name = "Rok wydania")]
        public int Year { get; set; }

        public List<Track> Tracks { get; set; }

        [Display(Name = "Dostawca")]
        public string Name { get; set; }

        public string Surname { get; set; }
    }
}