using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesSIm
{
    static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            string input;
            Console.WriteLine($"Please enter {prompt}:");
            input = Console.ReadLine();
            return input;
        }
        public static string GetManagerString()
        {
            string userInput;
            do
            {
                Console.WriteLine("Which sweepstakes manager would you like to use?\n" +
                   "Press 1 for Queue Manager\n" +
                   "Press 2 for Stack Manager");
                userInput = Console.ReadLine();
            } 
            while (userInput != "1" && userInput != "2");
            return userInput;
       }
        public static string GetSweepstakesName()
        {
            Console.WriteLine("What would you like to name the sweepstakes?");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
