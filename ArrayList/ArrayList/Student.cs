using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListTest2
{
    public class Student
    {
        public string num,name;
        public double math, english, computer , total;
        public Student(string num, string name, double math, double  english, double computer)
        {
            this.num = num;
            this.name = name;
            this.math = math;
            this.english = english;
            this.computer = computer;
            this.total = math + english + computer;
        }
    }
}
