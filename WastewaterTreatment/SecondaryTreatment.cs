using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SecondaryTreatment:Treatment
    {
        private AerationTank aerationTank { get; set; }
        private SewageSludge sewageSludge { get; set; }
        private SettlingTank settlingTank { get; set; }
        public SecondaryTreatment(int efficiency, AerationTank aerationTank, SewageSludge sewageSludge, SettlingTank settlingTank) : base(efficiency)
        {
            this.sewageSludge = sewageSludge;
            this.settlingTank = settlingTank;
            this.aerationTank = aerationTank;
        }
        public override void RemoveImpurity(SewageWater water)
        {
            aerationTank.Aeration(water, efficiency, settlingTank, sewageSludge);
        }
    }
}
