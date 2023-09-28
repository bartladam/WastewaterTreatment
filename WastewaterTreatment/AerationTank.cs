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
            water.organicPolutants = water.organicPolutants * (1 - (efficiency / 100));
            sewageSludge.addSludge(settlingTank.Sedimentation(microorganism, this));
        }
    }
}
