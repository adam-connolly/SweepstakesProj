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
    }
}
