using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class AerationTank
    {
        /// <summary>
        /// Important part of secondary cleaning. Microorganisms eat organic pollutants
        /// </summary>
        public int microorganism { get; set; }
        public AerationTank(int microorganism)
        {
            this.microorganism = microorganism;
        }
        /// <summary>
        /// Cleaning process water with microorganisms
        /// </summary>
        /// <param name="water"></param>
        /// <param name="efficiency"></param>
        /// <param name="settlingTank"></param>
        /// <param name="sewageSludge"></param>
        public void Aeration(SewageWater water, int efficiency, SettlingTank settlingTank, SewageSludge sewageSludge)
        {
            double currentStatus = water.organicPollutants;
            water.organicPollutants = Math.Round(water.organicPollutants * (1d - (efficiency / 100d)));
            microorganism += ((int)currentStatus - (int)water.organicPollutants) / 3;
            sewageSludge.addSludge(settlingTank.Sedimentation(microorganism, this));
        }
    }
}
