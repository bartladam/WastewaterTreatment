using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class Filtration:Treatment
    {
        public Filtration(int efficiency): base(efficiency)
        {

        }
        public override void RemoveImpurity(SewageWater water)
        {
            water.largerParticles = water.largerParticles * (1 - (efficiency / 100));
        }
    }
}
