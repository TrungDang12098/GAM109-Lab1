using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public partial class Calculator
    {
        public double Cong()
        {
            return A + B;
        }

        public double Tru()
        {
            return A - B;
        }

        public double Nhan()
        {
            return A * B;
        }

        public double Chia()
        {
            if (B != 0)
                return A / B;
            else
                throw new DivideByZeroException("Không thể chia cho 0.");
        }
    }

}
