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
            Console.WriteLine("Please enter first name:");
            FirstName = Console.ReadLine();
            Console.WriteLine("Please enter last name:");
            LastName = Console.ReadLine();
            Console.WriteLine("Please enter email address:");
            EmailAddress = Console.ReadLine();
        }
    }
}
