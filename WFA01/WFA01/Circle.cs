using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA01
{
    class Circle
    {
        private double r ;
        public Circle (double r) //构造函数
        { this.r = r; }
        public double getArea()
        { return 3.14*r*r ;}
        public double getGirth ()
        { return 2*3.14*r ; }
    }
}
