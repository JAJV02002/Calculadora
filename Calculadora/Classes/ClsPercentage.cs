using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    class ClsPercentage
    {
        public double Percentage(double N1, double N2)
        {
            double P;
            P = (N1 /100)* N2;
            return P;
        }
    }
}
