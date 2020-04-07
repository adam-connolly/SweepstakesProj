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

        }
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetSweepstakesName());            
        }
        public void AddSweepstakesToManager(Sweepstakes sweepstakes)
        {
            manager.InsertSweepstakes(sweepstakes);
        }
    }
}
