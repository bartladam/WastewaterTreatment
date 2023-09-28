using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SedimentationTank
    {
        public int Sedimentation(SewageWater water, int efficiency, string type)
        {
            if(type.Equals("sand"))
                return water.amountSand = water.amountSand * (1 - (efficiency / 100));
            else if(type.Equals("organic"))
                return water.organicPolutants = water.organicPolutants * (1 - (efficiency / 100));
            return 0;
        }

    }
}
