using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PF02_A1
{
    public class Factorial
    {
        public static long CalcularFactorial(int numero)
        {
            if (numero < 0)
                return -1;

            return numero == 0
                ? 1
                : Enumerable.Range(1, numero).Aggregate(1L, (acc, x) => acc * x);
        }

    }
}
