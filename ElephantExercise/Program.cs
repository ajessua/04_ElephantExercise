using System;

namespace ElephantExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { name = "Lucinda", earSize = 33 };
            Elephant lloyd = new Elephant() { name = "Lloyd", earSize = 40 };



            while (true)
            {
                Console.WriteLine("Press:\n\n[1] for Lloyd,\n[2] for Lucinda,\n[3] to Swap");
                byte response = byte.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("You pressed: " + response);

                if (response == 1)
                {
                    lloyd.WhoAmI();
                    // lloyd.HearMessage("Hi", lucinda);
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (response == 2)
                {
                    lucinda.WhoAmI();
                    lloyd.SpeakTo(lucinda, "Hi Lucinda!");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (response == 3)
                {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                    Console.WriteLine("References have been swapped");
                    Console.ReadLine();
                    Console.Clear();
                }

                else return;
                //Console.WriteLine();







            }






        }
    }
}
