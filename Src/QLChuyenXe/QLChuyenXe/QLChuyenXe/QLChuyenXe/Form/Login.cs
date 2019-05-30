using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using MetroFramework.Forms;

namespace QLChuyenXe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = panel;
        }
        BLNhanSu ns = new BLNhanSu();
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
            if (KiemTra(txtUsername.Text, txtPassword.Text) == true)
            {
                FormMain frm = new FormMain();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Focus();
            }
        }


        private bool KiemTra(string user, string pass)
        {
            var tk = ns.getUserByIdPass(user, pass);
            if (tk.Count == 0)
                return false;
            if (tk[0].username == user && tk[0].password == pass)
            {
                FormMain f = new FormMain();
                this.Hide();
                f.ShowDialog();
                return true;
            }
            return false;
        }
    }
}
