using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SecondaryTreatment:Treatment
    {
        /// <summary>
        /// Aeration tank is important for cleaning by microorganism. 
        /// </summary>
        private AerationTank aerationTank { get; set; }
        /// <summary>
        /// Surplus microorganism are separated and sended to sewage sludge tank
        /// </summary>
        private SewageSludge sewageSludge { get; set; }
        /// <summary>
        /// Separation surplus microorganism from water
        /// </summary>
        private SettlingTank settlingTank { get; set; }
        public SecondaryTreatment(int efficiency, AerationTank aerationTank, SewageSludge sewageSludge, SettlingTank settlingTank) : base(efficiency)
        {
            this.sewageSludge = sewageSludge;
            this.settlingTank = settlingTank;
            this.aerationTank = aerationTank;
        }
        /// <summary>
        /// Process for cleaning water from organic pollutants
        /// </summary>
        /// <param name="water"></param>
        public override void RemoveImpurity(SewageWater water)
        {
            aerationTank.Aeration(water, efficiency, settlingTank, sewageSludge);
        }
    }
}
