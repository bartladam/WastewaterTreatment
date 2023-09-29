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
        /// <summary>
        /// Here we are cleaning sand. Sand is always problem for devices. We have to remove sand with success 98%
        /// </summary>
        /// <param name="water"></param>
        public override void RemoveImpurity(SewageWater water)
        {
            sedimentation.Sedimentation(water, efficiency, "sand"); // maybe change
        }
    }
}
