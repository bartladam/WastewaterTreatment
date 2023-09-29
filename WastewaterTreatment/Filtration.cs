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
        /// <summary>
        /// Here we are cleaning large particles. Big particles can destroy devices wastewater treatment plant
        /// </summary>
        /// <param name="water"></param>
        public override void RemoveImpurity(SewageWater water)
        {
            water.largerParticles = Math.Round(water.largerParticles * (1d - (efficiency / 100d)));
        }
    }
}
