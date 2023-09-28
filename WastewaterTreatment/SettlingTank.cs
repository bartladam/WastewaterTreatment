using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SettlingTank
    {
        public int Sedimentation(int microorganism, AerationTank aeration)
        {
            int sewageSludgeAmount = 0;
            if(microorganism > 100)
            {
                sewageSludgeAmount = microorganism - 100;
                aeration.microorganism = 100;
            }
            return sewageSludgeAmount;
        }
    }
}
