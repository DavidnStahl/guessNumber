using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Guess a number between 1 and 10: "); // asks the user to guess a number between 1 and 10.
            int numberUser = int.Parse(Console.ReadLine());
            if (numberUser == 3)
            {
                Console.WriteLine("Right guessed!"); // If user guesses number 3
            }
            else
            {
                Console.WriteLine("Absolutely wrong!");  // All other guesses then 3
            }
            Console.ReadLine();

            //If the user guesses 3 it should be shown: "Right guessed!".Guessing on other numbers will show: "Absolutely wrong!".
        }
    }
}
