using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SandTrap:Treatment
    {
        private SedimentationTank sedimentation { get; set; }
        public SandTrap(int efficiency, SedimentationTank sedimentation) : base(efficiency)
        {
            this.sedimentation = sedimentation;
        }
        public override void RemoveImpurity(SewageWater water)
        {
            removedAmount = sedimentation.Sedimentation(water, efficiency, "sand"); // maybe change
        }
    }
}
