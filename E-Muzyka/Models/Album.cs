using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Muzyka.Models
{
    public class Album
    {
        public Album()
        {
            Tracks = new HashSet<Track>();
        }

        public int Id { get; set; }

        public string Artist { get; set; }

        public string Title { get; set; }

        public string Version { get; set; }

        public int Year { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
        public string AppUserId { get; internal set; }
    }
}