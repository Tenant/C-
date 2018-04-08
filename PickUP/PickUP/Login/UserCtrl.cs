using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TJU.SoftCourse;
using System.Data.OleDb;

namespace PickUP.Login
{
    public class UserCtrl
    {
        public Users validUser(string userName, string password)
        {
            OleDbConnection conn = OleDbConn.getConn();
            string sql = "select * from tbl_Account where userName='" + userName + "' AND  password='" + password + "'";
            List<object[]> result = OleDbConn.execQuery(sql);
            if (result.Count == 0)
                return null;
            Users user = new Users(userName, password);
            return user;
        }
    }
}
