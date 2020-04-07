using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesSIm
{
    class ManagerFactory
    {
        public static ISweepstakesManager CreateManager(string userInput)
        {
            ISweepstakesManager manager;
            switch (userInput)
            {
                case "1":
                    manager = new SweepstakesQueueManager();
                    return manager;
                case "2":
                    manager = new SweepstakesStackManager();
                    return manager;
                default:
                    manager = new SweepstakesQueueManager();
                    return manager;
            }
        }
    }
}
