using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class AerationTank
    {
        public int microorganism { get; set; }
        public AerationTank(int microorganism)
        {
            this.microorganism = microorganism;
        }
        public void Aeration(SewageWater water, int efficiency, SettlingTank settlingTank, SewageSludge sewageSludge)
        {
            double currentStatus = water.organicPolutants;
            water.organicPolutants = Math.Round(water.organicPolutants * (1d - (efficiency / 100d)));
            microorganism += ((int)currentStatus - (int)water.organicPolutants) / 3;
            sewageSludge.addSludge(settlingTank.Sedimentation(microorganism, this));
        }
    }
}
