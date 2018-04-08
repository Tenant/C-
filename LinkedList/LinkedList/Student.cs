using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    public class Student
    {
        public string no,name;
        public double math, english, computer , total;
        public Student(string no, string name, double math, double  english, double computer)
        {
            this.no = no;
            this.name = name;
            this.math = math;
            this.english = english;
            this.computer = computer;
            this.total = math + english + computer;
        }
    }
}
