using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using MovieStreaming.Messages;

namespace MovieStreaming.Actors
{
    public class PlaybackActor : UntypedActor
    {

        public PlaybackActor()
        {
            Console.WriteLine("\n Creating PlaybackActor!!!");
        }

        protected override void OnReceive(object message)
        {
            //if (message is string)
            //{
            //    Console.WriteLine("\n Received movie: " + message);
            //}
            //else
            //{
            //    Unhandled(message);
            //}

            if (message is PlayMovieMessage)
            {
                var m = message as PlayMovieMessage;

                Console.WriteLine("\n Received movie: " + m.MovieTitle);
                Console.WriteLine("\n UserId: " + m.UserId);
            }
            else
            {
                Unhandled(message);
            }
        }
    }
}
