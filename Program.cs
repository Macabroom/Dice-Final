using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {

        // Program starts here!
        public static void Main(string[] args)
        {

            bool continueRunning = true;

            // Run program for the first time.
            Dice roll = new Dice();
            roll.Man();


            while (continueRunning)
            {
                // Prompt user if they want to roll again.
                Console.WriteLine("Do you want to roll again? Y/N");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.KeyChar == 'y') // User selected yes.
                {
                    Dice die = new Dice();
                    roll.Man();
                }
                if (info.KeyChar == 'n') // User selected no.
                {
                    continueRunning = false;
                    Console.WriteLine("Thank you for rolling.");
                    Console.ReadLine();
                }

               
            }
        }
       
        // Main program found here.
        class Dice
        {
            public void Dog() { }

            // Makes six dice rolls and prints them onto the console.
            public void Man()
            {
                int number_of_rolls = 0;
                Random rand = new Random();
                int random_int = rand.Next(1, 11);
                Console.WriteLine(random_int);
                number_of_rolls = random_int;
                List<int> list = new List<int>();

                while (number_of_rolls > 0)
                {
                    int dice_number = rand.Next(1, 7);
                    Console.WriteLine(dice_number);
                    list.Add(dice_number);
                    number_of_rolls = number_of_rolls - 1;
                }
                var List = list.Average();
                Console.WriteLine(List);
                Console.ReadLine();





            }
        }
    }
}

    





