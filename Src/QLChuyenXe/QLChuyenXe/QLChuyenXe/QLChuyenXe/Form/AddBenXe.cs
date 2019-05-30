using MetroFramework.Forms;
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

namespace QLChuyenXe
{
    public partial class AddBenXe : MetroForm
    {
        public AddBenXe()
        {
            InitializeComponent();
        }

        public AddBenXe(string maben, string tenben, int _flag)
        {
            InitializeComponent();
            txtIDBen.Text = maben;
            txtTenBen.Text = tenben;
            flag = _flag;
        }
        public int flag;

        private void AddBenXe_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLLBen b = new BLLBen();
            // Thêm bến
            if (flag == 1)
            {
                b.ThemBen(txtIDBen.Text, txtTenBen.Text);
                DialogResult res = MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                    this.Close();
            }
            // chỉnh sửa bến
            if (flag == 0)
            {
                b.ChinhSuaBen(txtIDBen.Text, txtTenBen.Text);
                DialogResult res = MessageBox.Show("Chỉnh Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                    this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
