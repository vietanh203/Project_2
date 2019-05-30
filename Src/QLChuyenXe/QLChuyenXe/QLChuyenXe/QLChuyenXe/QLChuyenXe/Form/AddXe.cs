using BusinessLogic;
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

namespace QLChuyenXe
{
    public partial class AddXe : MetroForm
    {
        BLXe x = new BLXe();
        Xe xe = new Xe();
        public int mode = 0;
        public string getid;
        public string getbienso;
        public string getmaloai;
        public string getidben;
        public string getstatus;
        public AddXe()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {

                if (x.SearchDanhSachXeTheoBienSo(this.txtSoXe.Text).Count != 0)
                    MessageBox.Show("Xe đã có trong danh sách.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                {

                    x.themXe(txtSoXe.Text, cbHangXe.SelectedValue.ToString(), cbBen.SelectedValue.ToString());
                    MessageBox.Show("Đã thêm xong !", "Thông Báo", MessageBoxButtons.OK);

                }
            }
            else
            {

                x.suaXe(Convert.ToInt32(getid), txtSoXe.Text, cbHangXe.Text, cbBen.Text, Convert.ToInt32(getstatus));
                MessageBox.Show("Đã sữa xong !", "Thông Báo", MessageBoxButtons.OK);

            }
        }

        private void AddXe_Load(object sender, EventArgs e)
        {
            this.cbBen.DataSource = x.getBenXe();
            this.cbBen.DisplayMember = "TenBen";
            this.cbBen.ValueMember = "IDBen";
            //----------------------------------------------
            this.cbHangXe.DataSource = x.getLoaiXe();
            this.cbHangXe.DisplayMember = "HangXe";
            this.cbHangXe.ValueMember = "MaLoai";
            //----------------------------------------------

            if (mode == 0)
            {

                this.cbBen.DataSource = x.getBenXe();
                this.cbBen.DisplayMember = "TenBen";
                this.cbBen.ValueMember = "IDBen";
                //----------------------------------------------
                this.cbHangXe.DataSource = x.getLoaiXe();
                this.cbHangXe.DisplayMember = "HangXe";
                this.cbHangXe.ValueMember = "MaLoai";

            }
            else
            {
                // Lấy dữ liệu
                txtSoXe.Text = getbienso;
                cbHangXe.SelectedValue = getmaloai;
                cbBen.SelectedValue = getidben;


                cbHangXe.Enabled = false;
                cbBen.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
