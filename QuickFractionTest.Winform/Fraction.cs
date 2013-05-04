using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFractionTest.Winform
{
    public class Fraction
    {
        public decimal Numerator { get; set; }

        public decimal Denominator { get; set; }

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }
    }
}
