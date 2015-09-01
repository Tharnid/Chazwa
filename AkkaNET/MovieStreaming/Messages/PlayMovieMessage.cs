using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStreaming.Messages
{
    public class PlayMovieMessage
    {
        public string MovieTitle { get; private set; }  // private makes them immutable..cannot be changed
        public int UserId { get; private set; }

        public PlayMovieMessage(string movieTitle, int userId)
        {
            MovieTitle = movieTitle;
            UserId = userId;
        }
    }
}
