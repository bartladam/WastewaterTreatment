using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SewageSludge
    {
        private double amountSewageSludge { get; set; }
        public void addSludge(double amount)
        {
            amountSewageSludge += amount;
        }
        public override string ToString()
        {
            return amountSewageSludge.ToString();
        }
    }
}
