using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA02
{
    class Program
    {
        static void swap(ref int x, ref int y)
        {
            int z;
            z=x;
            x=y;
            y=z;
        }
        static void Main(string[] args)
        {
            int a=10, b=20;
            swap(ref a, ref b);
            Console.WriteLine(a);
            Console .WriteLine(b);
        }
    }
}
