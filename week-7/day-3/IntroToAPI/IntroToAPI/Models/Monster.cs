using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroToAPI.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Horns { get; set; }

        [DefaultValue(2)]
        public int NumberOfEyes { get; set; }

        [MaxLength(25)]
        public string SkinType { get; set; }

        public string Size { get; set; }
    }
}