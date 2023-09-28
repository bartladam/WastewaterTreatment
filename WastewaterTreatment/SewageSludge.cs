using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SewageSludge
    {
        private int amountSewageSludge { get; set; }
        public void addSludge(int amount)
        {
            amountSewageSludge += amount;
        }
    }
}
