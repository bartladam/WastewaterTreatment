using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SedimentationTank
    {
        /// <summary>
        /// Part when heavier particles are sedimentation to bottom
        /// </summary>
        /// <param name="water"></param>
        /// <param name="efficiency"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public double Sedimentation(SewageWater water, int efficiency, string type)
        {
            if(type.Equals("sand"))
                return water.amountSand = Math.Round((1d - (efficiency / 100d)) * water.amountSand);
            else if(type.Equals("organic"))
               return water.organicPollutants = Math.Round(water.organicPollutants * (1d - (efficiency/100d)));
            return 0;
        }

    }
}
