using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class PrimaryTreatments:Treatment
    {
        private SedimentationTank sedimentation { get; set; }
        private SewageSludge sewageSludge { get; set; }
        public PrimaryTreatments(int efficiency, SedimentationTank sedimentation, SewageSludge sewageSludge) : base(efficiency)
        {
            this.sedimentation = sedimentation;
            this.sewageSludge = sewageSludge;
        }
        public override void RemoveImpurity(SewageWater water)
        {
            removedAmount = sedimentation.Sedimentation(water, efficiency, "organic");
            sewageSludge.addSludge(removedAmount);
        }

    }
}
