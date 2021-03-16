using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webbdm_verse_of_the_day.Models
{
    public class Verse
    {
        [Key]
        public int Id { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Text { get; set; }
    }
}