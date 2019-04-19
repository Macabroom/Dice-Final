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
            roll.Start();
            

            while (continueRunning)
            {
                // Prompt user if they want to roll again.
                Console.Write("Do you want to roll again? y/n" + " ");
                ConsoleKeyInfo info = Console.ReadKey();
                Console.WriteLine();
                if (info.KeyChar == 'y') // User selected yes.
                {
                    Dice die = new Dice();
                    roll.Start();
                }
                if (info.KeyChar == 'n') // User selected no.
                {
                    continueRunning = false;
                    Console.WriteLine("Thank you for rolling.");
                    Console.WriteLine("Press the Enter key to exit.");
                    Console.ReadLine();
                }

               
            }
        }
       
        // Main program found here.
        class Dice
        {
            // Makes six dice rolls and prints them onto the console.
            public void Start()
            {
                int number_Of_rolls = 0;
                Random rand = new Random();
                int random_Int = rand.Next(1, 11);
                Console.Write("Rolls = ");
                Console.WriteLine(random_Int);
                number_Of_rolls = random_Int;
                List<int> diceResults = new List<int>();

                while (number_Of_rolls > 0)
                {
                    int dice_Number = rand.Next(1, 7);
                    Console.WriteLine(dice_Number);
                    diceResults.Add(dice_Number);
                    number_Of_rolls = number_Of_rolls - 1;
                }
                //Finds the average of the dice rolls and prints it onto the console.
                var List = diceResults.Average();
                Console.WriteLine();
                Console.WriteLine("Average: " +List);
                Console.ReadLine();
                




            }
        }
    }
}

    





