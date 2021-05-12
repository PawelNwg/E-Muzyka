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

        public string UserId { get; set; }

        [MaxLength(20, ErrorMessage = "Artysta może mieć maksymalnie 20 znaków")]
        [Display(Name = "Artysta")]
        [RegularExpression(@"^([A-Za-zzżźćńółęąśŻŹĆĄŚĘŁÓŃ]+)$", ErrorMessage = "Niepoprawna nazwa artysta")]
        public string Artist { get; set; }

        [MaxLength(30, ErrorMessage = "Tytuł może mieć maksymalnie 30 znaków")]
        [Display(Name = "Tytuł")]
        [RegularExpression(@"^([A-Za-zzżźćńółęąśŻŹĆĄŚĘŁÓŃ]+)$", ErrorMessage = "Niepoprawny tytuł")]
        public string Title { get; set; }

        [MaxLength(30, ErrorMessage = "Wersja może mieć maksymalnie 20 znaków")]
        [Display(Name = "Wersja")]
        [RegularExpression(@"^([A-Za-zzżźćńółęąśŻŹĆĄŚĘŁÓŃ]+)$", ErrorMessage = "Niepoprawna wersja")]
        public string Version { get; set; }

        [MaxLength(4, ErrorMessage = "Rok wydania może mieć długość 4 znaków")]
        [Display(Name = "Rok wydania")]
        [RegularExpression(Const.OnlyLetters, ErrorMessage = "Niepoprawna data")]
        public int Year { get; set; }

        public virtual List<Track> Tracks { get; set; }

        [Display(Name = "Dostawca")]
        public virtual AppUser AppUser { get; set; }
    }
}