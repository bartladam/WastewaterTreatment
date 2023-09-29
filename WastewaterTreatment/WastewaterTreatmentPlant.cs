using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class WastewaterTreatmentPlant
    {
        /// <summary>
        /// In this part we are removing the bigger particles
        /// </summary>
        private PreliminaryTreatment preliminary { get; set; }
        /// <summary>
        /// In this part we are removing organic pollutants
        /// </summary>
        private PrimaryTreatments primary { get; set; }
        /// <summary>
        /// We are removing with microorganism remains organic pollutants
        /// </summary>
        private SecondaryTreatment secondary { get; set; }
        public WastewaterTreatmentPlant(PreliminaryTreatment preliminary, PrimaryTreatments primary, SecondaryTreatment secondary)
        {
            this.preliminary = preliminary;
            this.primary = primary;
            this.secondary = secondary;
        }
        /// <summary>
        /// The process treatment wastewater
        /// </summary>
        /// <param name="water"></param>
        public void Treatment(SewageWater water)
        {
            preliminary.Process(water);
            primary.RemoveImpurity(water);
            secondary.RemoveImpurity(water);

        }
    }
}
