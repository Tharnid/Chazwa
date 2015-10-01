using Akka.Actor;
using MovieStreaming.Actors;
using MovieStreaming.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStreaming
{
    class Program
    {
        private static ActorSystem MovieStreamingActorSystem;

        static void Main(string[] args)
        {
            MovieStreamingActorSystem = ActorSystem.Create("MovieStreamingActorSystem");
            Console.WriteLine("Yo...the Actor has been created!!!");

            // Props
            Props playbackActorProps = Props.Create<PlaybackActor>();

            IActorRef playbackActorRef = MovieStreamingActorSystem.ActorOf(playbackActorProps, "PlaybackActor");

            // Tell actor to do something
            // playbackActorRef.Tell("Akka.Net: The Movie");

            playbackActorRef.Tell(new PlayMovieMessage("Akka.Net: The Movie", 42));

            //playbackActorRef.Tell(42);

            //// will produce exception
            //playbackActorRef.Tell('c');



            Console.ReadLine();

            MovieStreamingActorSystem.Shutdown();
        }
    }
}
