using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab4ZadDom.Models
{
    public class SongViewModel
    {
        //parameterless constructor
        public SongViewModel()
        {
            Title = "";
            Vocalist = "";
            Tab = "";
            Notes = "";
            Lyrics = "";
        }

        //costructor with title, vocalist, tab, notes and lyrics parameters
        public SongViewModel(string title, string vocalist, string tab, string notes, string lyrics)
        {
            Title = title;
            Vocalist = vocalist;
            Tab = tab;
            Notes = notes;
            Lyrics = lyrics;
        }

        //title property
        public string Title { get; set; }
        //vocalist property
        public string Vocalist { get; set; }
        //tab property
        public string Tab { get; set; }
        //notes property
        public string Notes { get; set; }
        //lyrics property
        public string Lyrics { get; set; }
    }
}
