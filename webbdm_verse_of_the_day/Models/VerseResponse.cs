using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webbdm_verse_of_the_day.Models
{
    public class VerseResponse
    {
        public List<Verse> verses { get; set; }
    }
}