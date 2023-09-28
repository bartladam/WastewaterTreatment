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
        public override void RemoveImpurity(SewageWater water)
        {
            water.amountGravel = water.amountGravel * (1 - (efficiency / 100));
        }
    }
}
