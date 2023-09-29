using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WastewaterTreatment
{
    internal class SewageSludge
    {
        /// <summary>
        /// Amount collected sewage sludge
        /// </summary>
        private double amountSewageSludge { get; set; }
        /// <summary>
        /// When we separated organic pollutants, so this pollutants are collected here
        /// </summary>
        /// <param name="amount"></param>
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
