using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA01
{
    class Program
    {
        static void calculate(int x, int y, out int quotient, out int remainder)
        {
            quotient = x / y;
            remainder = x % y;
        }
        static void Main(string[] args)
        {
            int quotient, remainder;
            calculate(20, 6, out quotient, out remainder);
                Console.WriteLine (quotient );
            Console.WriteLine(remainder );
        }
    }
}
