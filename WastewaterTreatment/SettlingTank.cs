using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SettlingTank
    {
        /// <summary>
        /// Process of separation surplus microorganism from water
        /// </summary>
        /// <param name="microorganism"></param>
        /// <param name="aeration"></param>
        /// <returns></returns>
        public double Sedimentation(int microorganism, AerationTank aeration)
        {
            double sewageSludgeAmount = 0;
            if(microorganism > 100)
            {
                sewageSludgeAmount = microorganism - 100;
                aeration.microorganism = 100;
            }
            return sewageSludgeAmount;
        }
    }
}
