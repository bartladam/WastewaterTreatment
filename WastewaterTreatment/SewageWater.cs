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
        /// <summary>
        /// Amount sand in wastewater
        /// </summary>
        public double amountSand { get; set; }
        /// <summary>
        /// Amount gravel in wastewater
        /// </summary>
        public double amountGravel { get; set; }
        /// <summary>
        /// Amount larger particles in wastewater
        /// </summary>
        public double largerParticles { get; set; }
        /// <summary>
        /// The big part of wastewater are organic pollutants
        /// </summary>
        public double organicPollutants { get; set; }
        public SewageWater(int amountSand, int amountGravel, int largerParticles, double organicPollutants)
        {
            this.amountSand = amountSand;
            this.amountGravel = amountGravel;
            this.largerParticles = largerParticles;
            this.organicPollutants = organicPollutants;
        }
    }
}
