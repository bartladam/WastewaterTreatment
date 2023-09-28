using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    abstract class Treatment
    {
        public int efficiency { get; private set; }
        public double removedAmount { get; protected set; }
        public Treatment(int efficiency)
        {
            this.efficiency = efficiency;
        }
        public abstract void RemoveImpurity(SewageWater water);
    }
}
