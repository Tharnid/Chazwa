using SamplesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SamplesData
{
    public class MusicGenreViewModel
    {
        #region Constructor
        public MusicGenreViewModel()
        {
            Genres = new List<MusicGenre>();
            LoadGenres();
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Get/Set the collection of Music Genres
        /// </summary>
        public List<MusicGenre> Genres { get; set; }
        /// <summary>
        /// Get/Set the Selected ID
        /// </summary>
        public int SelectedId { get; set; }
        /// <summary>
        /// Get/Set the Selected Genre
        /// </summary>
        public string SelectedGenre { get; set; }
        #endregion

        #region LoadGenres Method
        public void LoadGenres()
        {
            MusicGenreManager mgr = new MusicGenreManager();

            // Get list of Music Genres
            Genres = mgr.Genres;
        }
        #endregion
    }
}