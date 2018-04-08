using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PickUP.Login
{
    public partial class LoginForm : Form
    {
        private Users newUser = null;

        public Users getUsers()
        {
            return newUser;
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string userName = tb_User.Text;
            string password = tb_Password.Text;
            UserCtrl newUserCtrl = new UserCtrl();
            newUser = newUserCtrl.validUser(userName, password);
            if (newUser != null)
                this.Close();
            else
                MessageBox.Show("Not a valid user!");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
