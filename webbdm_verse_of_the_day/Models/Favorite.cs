using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webbdm_verse_of_the_day.Models
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }
        public string VerseId { get; set; }
    }
}