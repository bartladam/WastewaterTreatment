using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class PreliminaryTreatment
    {
        /// <summary>
        /// Part of preliminary treatment
        /// </summary>
        private GravelTrap gravelTrap { get; set; }
        /// <summary>
        /// Part of preliminary treatment
        /// </summary>
        private Filtration filtration { get; set; }
        /// <summary>
        /// Part of preliminary treatment
        /// </summary>
        private SandTrap sandTrap { get; set; }
        public PreliminaryTreatment(GravelTrap gravelTrap, Filtration filtration, SandTrap sandTrap)
        {
            this.gravelTrap = gravelTrap;
            this.filtration = filtration;
            this.sandTrap = sandTrap;
        }
        /// <summary>
        /// Cleaning in the preliminary part
        /// </summary>
        /// <param name="water"></param>
        public void Process(SewageWater water)
        {
            gravelTrap.RemoveImpurity(water);
            filtration.RemoveImpurity(water);
            sandTrap.RemoveImpurity(water);
        }
    }
}
