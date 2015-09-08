using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using MovieStreaming.Messages;

namespace MovieStreaming.Actors
{
    public class PlaybackActor : ReceiveActor // Refactor to Receive Actor UntypedActor
    {

        public PlaybackActor()
        {
            Console.WriteLine("\n Creating PlaybackActor!!!");

            // using ReceiveActor API

            Receive<PlayMovieMessage>(message => HandlePlayMovieMessage(message), message => message.UserId == 42);
        }

        private void HandlePlayMovieMessage(PlayMovieMessage message)
        {
            Console.WriteLine("\n UserId: " + message.MovieTitle);
            Console.WriteLine("\n UserId: " + message.UserId);
        }

        //protected override void OnReceive(object message)
        //{
        //    //if (message is string)
        //    //{
        //    //    Console.WriteLine("\n Received movie: " + message);
        //    //}
        //    //else
        //    //{
        //    //    Unhandled(message);
        //    //}

        //    if (message is PlayMovieMessage)
        //    {
        //        var m = message as PlayMovieMessage;

        //        Console.WriteLine("\n Received movie: " + m.MovieTitle);
        //        Console.WriteLine("\n UserId: " + m.UserId);
        //    }
        //    else
        //    {
        //        Unhandled(message);
        //    }
        //}o
    }
}
