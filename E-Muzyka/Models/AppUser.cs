using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Muzyka.Models
{
    public class AppUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public AppUser()
        {
            Albums = new HashSet<Album>();
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}