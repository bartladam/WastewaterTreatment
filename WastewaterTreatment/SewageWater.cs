using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SewageWater
    {
        public int amountSand { get; set; }
        public int amountGravel { get; set; }
        public int largerParticles { get; set; }
        public int organicPolutants { get; set; }
        public SewageWater(int amountSand, int amountGravel, int largerParticles, int organicPolutants)
        {
            this.amountSand = amountSand;
            this.amountGravel = amountGravel;
            this.largerParticles = largerParticles;
            this.organicPolutants = organicPolutants;
        }
    }
}
