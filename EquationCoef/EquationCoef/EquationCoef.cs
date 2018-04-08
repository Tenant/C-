using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquationCoef
{
    class EquationCoef
    {
       double a, b, c;
       public double root1, root2;
      public EquationCoef(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool getRoot( out double  root1 , out double root2 )
        {
            double delta = b * b - 4 * a * c;
            root1 = 0;
            root2 = 0;
            if ( delta < 0)
                return false;
            else
            {
                root1=( - b +Math.Sqrt( delta )) / ( 2 * a );
                root1=( - b -Math.Sqrt( delta )) / ( 2 * a );
                return true;
            }
        }

    }

}
