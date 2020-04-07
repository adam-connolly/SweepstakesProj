using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesSIm
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue;
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
    }
}
