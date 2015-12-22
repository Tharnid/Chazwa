using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video11
{
    class Program
    {
        static void Main(string[] args)
        {
            //var player = new Player();
            //player.Name = "Your Mom";

            var player = new Player("Han");

            var game = new Hangman();

            game.Player = player;
            game.Guess('a');
        }
    }
}
