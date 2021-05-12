using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Muzyka.Models
{
    public class Track
    {
        public int Id { get; set; }

        public int AlbumId { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        public int Year { get; set; }
        public TimeSpan Duration { get; set; }
        public virtual Album Album { get; set; }
    }
}