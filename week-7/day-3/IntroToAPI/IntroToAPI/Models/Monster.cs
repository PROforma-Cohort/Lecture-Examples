using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroToAPI.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Horns { get; set; }
        public int NumberOfEyes { get; set; }
        public string SkinType { get; set; }
        public string Size { get; set; }
    }
}