using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNameSpace
{
    public class Student
    {
        private string no,name;
        private double math, english, computer , total;
        public Student(string no, string name, double math, double  english, double computer)
        {
            this.no = no;
            this.name = name;
            this.math = math;
            this.english = english;
            this.computer = computer;
            this.total = math + english + computer;
        }
        public string getNo()
        {
            return this.no;
        }
        public string getName()
        {
            return this.name;
        }
        public double getMath()
        {
            return this.math;
        }
        public double getEnglish()
        {
            return this.english;
        }
        public double getComputer()
        {
            return this.computer;
        }
        public double getTotal()
        {
            return this.total;
        }
    }
}
