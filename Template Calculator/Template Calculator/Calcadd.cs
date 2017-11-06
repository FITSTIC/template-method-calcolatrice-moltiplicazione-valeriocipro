using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Calculator
{
    class Calcadd:Calcolatrice
    {
        protected override double Operazione()
        {
            for (int i = 0; i < y; i++)
                risultato += x;

            return risultato;
        }
    }
}
