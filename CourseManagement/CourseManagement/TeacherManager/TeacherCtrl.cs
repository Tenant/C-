using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.OleDb;
using TJU.SoftCourse;

namespace CourseManagement.TeacherManager
{
    public class TeacherCtrl : OleDbConn
    {
        public static Hashtable getDeptList()
        {
            Hashtable ht = new Hashtable();
            string sql = "select deptId,deptName from Department order by deptId ";
            List<object[]> list = OleDbConn.execQuery(sql);
            for (int i = 0; i < list.Count; i++)
            {
                Object[] o = list[i];
                ht.Add(o[1].ToString(), o[0].ToString());
            }
            return ht;
        }
        //
        private Teacher newteacher;
        //
        public void InputTeacher(Teacher newteacher)
        {
            this.newteacher = newteacher;
        }
        public bool saveDataBase()
        {
            string sql = "insert tblTeacher(StaffNo, StaffName, sex, deptId) values('" + newteacher.staffNo;
            sql += "','" + newteacher.staffName + "','" + newteacher.sex;
            sql += "','" + newteacher.deptID + "')";
            return execNonQuery(sql);
        }
        //

    }
}