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
                int numberOfRolls = 0;
                Random rand = new Random();
                int randomInt = rand.Next(1, 11);
                Console.Write("Rolls = ");
                Console.WriteLine(randomInt);
                numberOfRolls = randomInt;
                List<int> diceResults = new List<int>();

                while (numberOfRolls > 0)
                {
                    int diceNumber = rand.Next(1, 7);
                    Console.WriteLine(diceNumber);
                    diceResults.Add(diceNumber);
                    numberOfRolls = numberOfRolls - 1;
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

    





