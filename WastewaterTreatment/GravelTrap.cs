using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class GravelTrap: Treatment
    {
        public GravelTrap(int efficiency):base(efficiency)
        {

        }
        /// <summary>
        /// Here we are cleaning gravel. Big particles can destroy devices wastewater treatment plant
        /// </summary>
        /// <param name="water"></param>
        public override void RemoveImpurity(SewageWater water)
        {
            water.amountGravel = Math.Round(water.amountGravel * (1d - (efficiency / 100d)));
        }
    }
}
