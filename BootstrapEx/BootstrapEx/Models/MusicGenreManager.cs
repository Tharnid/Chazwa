using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace SamplesData
{
    public class MusicGenreManager
    {
        public MusicGenreManager()
        {
            Genres = new List<MusicGenre>();
            LoadAllMock();
        }

        public List<MusicGenre> Genres { get; set; }

        protected void LoadAllMock()
        {
            Genres.Add(new MusicGenre(1, "Jazz"));
            Genres.Add(new MusicGenre(2, "Country"));
            Genres.Add(new MusicGenre(3, "Rock"));
            Genres.Add(new MusicGenre(4, "Blues"));
            Genres.Add(new MusicGenre(5, "Alternative Rock"));
        }
    }
}