using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public partial class Calculator
    {
        public double A { get; set; }
        public double B { get; set; }

        public Calculator(double a, double b)
        {
            A = a;
            B = b;
        }
    }
}
