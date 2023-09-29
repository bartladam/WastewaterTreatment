using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    abstract class Treatment
    {
        /// <summary>
        /// How effective is part of treatment
        /// </summary>
        public int efficiency { get; private set; }
        /// <summary>
        /// Amount of materials who is removed during treatment
        /// </summary>
        public double removedAmount { get; protected set; }
        public Treatment(int efficiency)
        {
            this.efficiency = efficiency;
        }
        /// <summary>
        /// Each treatment part is cleaning different folder wastewater
        /// </summary>
        /// <param name="water"></param>
        public abstract void RemoveImpurity(SewageWater water);
    }
}
