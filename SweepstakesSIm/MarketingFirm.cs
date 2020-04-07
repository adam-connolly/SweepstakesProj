using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesSIm
{
    class MarketingFirm
    {
        ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        public Sweepstakes CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetSweepstakesName());
            return sweepstakes;
        }
        public void AddSweepstakesToManager(Sweepstakes sweepstakes)
        {
            manager.InsertSweepstakes(sweepstakes);
        }
    }
}
