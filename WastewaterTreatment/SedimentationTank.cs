using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SedimentationTank
    {
        public double Sedimentation(SewageWater water, int efficiency, string type)
        {
            if(type.Equals("sand"))
                return water.amountSand = (1d - (efficiency / 100d)) * water.amountSand;
            else if(type.Equals("organic"))
               return water.organicPolutants = Math.Round(water.organicPolutants * (1d - (efficiency/100d)));
            return 0;
        }

    }
}
