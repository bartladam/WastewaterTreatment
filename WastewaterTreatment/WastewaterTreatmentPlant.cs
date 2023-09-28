﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class WastewaterTreatmentPlant
    {
        private PreliminaryTreatment preliminary { get; set; }
        private PrimaryTreatments primary { get; set; }
        private SecondaryTreatment secondary { get; set; }
        private TertiaryTreatment? teritary { get; set; }
        public WastewaterTreatmentPlant(PreliminaryTreatment preliminary, PrimaryTreatments primary, SecondaryTreatment secondary, TertiaryTreatment? tertiary)
        {
            this.preliminary = preliminary;
            this.primary = primary;
            this.secondary = secondary;
            this.teritary = teritary;
        }
        public void Treatment(SewageWater water)
        {
            preliminary.Process(water);
            primary.RemoveImpurity(water);
            secondary.RemoveImpurity(water);

        }
    }
}