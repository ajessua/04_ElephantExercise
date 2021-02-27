using System;
using System.Collections.Generic;
using System.Text;

namespace ElephantExercise
{
    class Elephant
    {
        public int earSize;
        public string name;

        public void WhoAmI()
        {
            Console.WriteLine("\nMy name is " + name);
            Console.WriteLine("My ears are " + earSize + " inches tall");

        }

        public void HearMessage(string message, Elephant whoSaidit)
        {
            Console.WriteLine(name + " heard a message");
            Console.WriteLine(whoSaidit.name + " said this: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }



    }
}
