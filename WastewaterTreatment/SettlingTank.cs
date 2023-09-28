using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SettlingTank
    {
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
