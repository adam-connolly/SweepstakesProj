﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesSIm
{
    class Program
    {
        static void Main(string[] args)
        {

            MarketingFirm firm = new MarketingFirm(new SweepstakesQueueManager());
        }
    }
}
