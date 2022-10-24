using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskPattern
{
    public class Account
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void CalculateInterest(ICalculator calculator) 
        {
            calculator.CalculateInterest(this);
        }
    }
}
    