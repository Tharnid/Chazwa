using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video11
{
    class Hangman
    {
        public Player Player { get; set; }

        // poor choice we will discover why
        public List<string> WorldList { get; set; }
        public string Word { get; set; }
        public Outcome Outcome { get; set; }

        public void Guess (char letter)
        {
            // Game logic for a players guess goes here
        }
    }
}
