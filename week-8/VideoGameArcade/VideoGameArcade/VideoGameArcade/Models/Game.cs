using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoGameArcade.Models
{
    public enum Rating
    {
        EVERYONE = 0,
        TEEN,
        MATURE
    }

    public class Game
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public Rating Rating { get; set; }
    }
}