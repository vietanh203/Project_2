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
using DataProvider.Model;
using System.IO;


namespace QLChuyenXe
{
    public partial class AddNV : MetroForm
    {
        private BLNhanSu db = new BLNhanSu();
        NHANSU nhansu = new NHANSU();
        bool add = true;
        public AddNV()
        {
            InitializeComponent();
        }

        private void AddNV_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            var list = db.getAllTD();
            var result = list.Select(x => new
            {
                IDTuyenDuong = x.IDTuyenDuong,
                NameTuyenDuong = x.DiemKhoiHanh + "-" + x.DiemDen
            });
            cbTuyenDuong.DataSource = result.ToList();
            cbTuyenDuong.ValueMember = "IDTuyenDuong";
            cbTuyenDuong.DisplayMember = "NameTuyenDuong";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime dt = dtNgaySinh.Value.Date;

            int tuyenduong = Convert.ToInt32(cbTuyenDuong.SelectedValue);
            string ten = txtHoTen_in4.Text;
            string cmnd = txtCMND_in4.Text;
            string que = txtQuequan_in4.Text;

            int loaiNV;

            if (cbLoaiNV.Text == "Quản lí")
            {
                loaiNV = 1;



            }
            else if (cbLoaiNV.Text == "Nhân viên")
            {
                loaiNV = 2;

            }
            else
            {
                loaiNV = 0;
            }



            string err = "";
            string pro = "";

            if (add)
            {
                if (pictureBox1.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    nhansu.image = ms.ToArray();
                }
                else
                    nhansu.image = null;

                if (!db.InsertNS(ten, dt, cmnd, que, tuyenduong, nhansu.image, loaiNV))
                {

                    MessageBox.Show(err);
                }

                else
                {
                    MessageBox.Show("Insert success");

                }

            }
            cbLoaiNV.ResetText();
            txtHoTen_in4.ResetText();
            dtNgaySinh.ResetText();
            txtCMND_in4.ResetText();
            txtQuequan_in4.ResetText();
            cbTuyenDuong.ResetText();
            pictureBox1.Image = null;
        }
        string imgLoc = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png| All Files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                pictureBox1.ImageLocation = imgLoc;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLoaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiNV.Text == "Quản lí")
            {

                cbTuyenDuong.Visible = false;

                lblTuyenDuong.Visible = false;


            }
            else if (cbLoaiNV.Text == "Nhân viên")
            {
                cbTuyenDuong.Visible = false;
                lblTuyenDuong.Visible = false;


            }
            else
            {
                cbTuyenDuong.Visible = true;
                lblTuyenDuong.Visible = true;
            }
        }
    }
}
