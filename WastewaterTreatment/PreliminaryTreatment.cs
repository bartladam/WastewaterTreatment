using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class PreliminaryTreatment
    {
        private GravelTrap gravelTrap { get; set; }
        private Filtration filtration { get; set; }
        private SandTrap sandTrap { get; set; }
        public PreliminaryTreatment(GravelTrap gravelTrap, Filtration filtration, SandTrap sandTrap)
        {
            this.gravelTrap = gravelTrap;
            this.filtration = filtration;
            this.sandTrap = sandTrap;
        }
        public void Process(SewageWater water)
        {
            gravelTrap.RemoveImpurity(water);
            filtration.RemoveImpurity(water);
            sandTrap.RemoveImpurity(water);
        }
    }
}
