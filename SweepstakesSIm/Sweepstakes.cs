using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesSIm
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        string name;
        public string Name { get { return name; } set { name = value; } }
        int startingRegistrationNumber;

        public Sweepstakes(string name)
        {
            Name = name;
            startingRegistrationNumber = 1001;
            contestants = new Dictionary<int, Contestant>();
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestant.FirstName = UserInterface.GetUserInputFor("first name");
            contestant.LastName = UserInterface.GetUserInputFor("last name");
            contestant.EmailAddress = UserInterface.GetUserInputFor("email address");
            contestant.RegistrationNumber = (startingRegistrationNumber += contestants.Count);
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            int winningNumber;
            Random randomRegNum = new Random();
            winningNumber = randomRegNum.Next(startingRegistrationNumber, (startingRegistrationNumber + contestants.Count));
            foreach(KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Key == winningNumber)
                {
                    Console.WriteLine($"{contestant.Key} {contestant.Value} is the winner!");
                    return contestant;
                }
            }
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Sweepstakes Registration Number:\n{contestant.RegistrationNumber}\n" +
                $"First Name:\n{contestant.FirstName}\n" +
                $"Last Name:\n{contestant.LastName}\n" +
                $"Email Address:\n{contestant.EmailAddress}");
        }
    }

}
