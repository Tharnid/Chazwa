using System;
using Akka.Actor;

namespace MovieStreaming.Console
{
    class Program
    {
        private static ActorSystem MovieStreamingActorSystem;

        static void Main(string[] args)
        {
            MovieStreamingActorSystem = ActorSystem.Create("MovieStreamingActorSystem");

            Console.ReadLine();

            MovieStreamingActorSystem.Shutdown();
        }
    }
}
