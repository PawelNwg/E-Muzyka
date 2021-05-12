using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Muzyka.ModelDTO
{
    public class AppUserDTO
    {
        [MaxLength(20, ErrorMessage = "Imię może mieć maksymalnie 20 znaków")]
        [Display(Name = "Imię")]
        [RegularExpression(@"^([A-Za-zzżźćńółęąśŻŹĆĄŚĘŁÓŃ]+)$", ErrorMessage = "Niepoprawne imię")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "Nazwisko może mieć maksymalnie 50 znaków")]
        [Display(Name = "Nazwisko")]
        [RegularExpression(@"^([A-Za-zzżźćńółęąśŻŹĆĄŚĘŁÓŃ]+)$", ErrorMessage = "Niepoprawne nazwisko")]
        public string Surname { get; set; }
    }
}