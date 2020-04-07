using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesSIm
{
    class Simulation
    {
        MarketingFirm marketingFirm;
        public void RunSimluation()
        {
            marketingFirm = CreateMarketingFirmWithManager();
            Sweepstakes boatSweepstakes = marketingFirm.CreateSweepstakes();
            marketingFirm.AddSweepstakesToManager(boatSweepstakes);
            Contestant adam = new Contestant();
            boatSweepstakes.RegisterContestant(adam);
        }

        public MarketingFirm CreateMarketingFirmWithManager()
        {            
            MarketingFirm marketingFirm = new MarketingFirm(ManagerFactory.CreateManager(UserInterface.GetManagerString()));
            return marketingFirm;
        }
    }
}
