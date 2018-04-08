using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseManagement.TeacherManager
{
    public class Teacher
    {
        public string staffNo, staffName, sex, deptID;
        public Teacher(string staffNo, string staffName, string sex, string deptID)
    {
        this.staffNo=staffNo;
        this.staffName = staffName;
        this.sex = sex;
        this.deptID = deptID;
    }
    }
}
