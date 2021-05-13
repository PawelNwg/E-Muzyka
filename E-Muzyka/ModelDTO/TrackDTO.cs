using E_Muzyka.Helpers;
using E_Muzyka.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Muzyka.ModelDTO
{
    public class TrackDTO
    {
        public int Id { get; set; }

        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Display(Name = "Artysta")]
        public string Artist { get; set; }

        [Display(Name = "Rok wydania")]
        public int Year { get; set; }

        [Display(Name = "Czas trwania")]
        public TimeSpan Duration { get; set; }

        [Display(Name = "Tytuł albumu")]
        public string AlbumTitle { get; set; }
    }
}