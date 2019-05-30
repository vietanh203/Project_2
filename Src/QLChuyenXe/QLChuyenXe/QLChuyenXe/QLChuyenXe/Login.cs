using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLChuyenXe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = panel;
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Text = "";
            //lbUsername.Text = "";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            //if (txtPassword.Text == "Password")
            //{
            //    txtPassword.Text = "";
            //    txtPassword.PasswordChar = '•';
            //}
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
               txtUsername.Text = "Username";
            if (txtPassword.Text == "Password")
            {

                txtPassword.Clear();
                txtPassword.PasswordChar = '•';
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
            }
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

       

       
    }
}
