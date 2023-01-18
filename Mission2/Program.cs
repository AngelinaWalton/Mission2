//Writer: Angelina Walton
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //create array
            int[] array1 = new int[11];

            //create integers
            int rolNum = 0;
            int roll1 = 0;
            int roll2 = 0;

            //create random numbers
            Random randNum1 = new Random();

            //interact with user
            Console.Write("Welcome to the dice throwing Simulator! " + '\n');
            Console.Write("How many dice roles would you like to simulate: ");


            //set user input to a variable and display text above results
            rolNum = int.Parse(Console.ReadLine());
            Console.WriteLine('\n' + "Dice Rolling Simulation Results: ");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls. ");
            Console.WriteLine("Total Number of Rolls = " + rolNum);

            //use a for loop to generate random numbers for each dice roll, calcualte the total amount rolled, AssemblyLoadEventHandler place it in an array
            for (int j = 0; j < rolNum; j++)
            {
                roll1 = randNum1.Next(1,7);
                roll2 = randNum1.Next(1,7);

                int total = roll1 + roll2;

                array1[total - 2]++;
            }

            //use a for loop to calaculate the percent rolled for each number, and put a '*' for each percent a number was rolled
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine();
                Console.Write((i + 2) + ":");
                int percent = ((array1[i] * 100) / rolNum);
                for (int x = 0; x < (percent + 1); x++)
                {
                    Console.Write("*");
                }

            }
            Console.WriteLine('\n');
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye! ");

        }
    }
}
