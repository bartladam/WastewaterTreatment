using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class PrimaryTreatments:Treatment
    {
        /// <summary>
        /// Organic pollutants sedimentation to bottom
        /// </summary>
        private SedimentationTank sedimentation { get; set; }
        /// <summary>
        /// We are collecting organic pollutants for different uses (agriculture etc.)
        /// </summary>
        private SewageSludge sewageSludge { get; set; }
        public PrimaryTreatments(int efficiency, SedimentationTank sedimentation, SewageSludge sewageSludge) : base(efficiency)
        {
            this.sedimentation = sedimentation;
            this.sewageSludge = sewageSludge;
        }
        /// <summary>
        /// Removed organic pollutants
        /// </summary>
        /// <param name="water"></param>
        public override void RemoveImpurity(SewageWater water)
        {
            removedAmount = sedimentation.Sedimentation(water, efficiency, "organic"); 
            sewageSludge.addSludge(removedAmount);
        }

    }
}
