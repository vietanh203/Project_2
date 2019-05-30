using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using BusinessLogic;
using DataProvider.Model;
using System.IO;

namespace QLChuyenXe
{
    public partial class NhanVien : MetroUserControl
    {
        private BLNhanSu db = new BLNhanSu();
        NHANSU nhansu = new NHANSU();


        bool add = true;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_in4.Enabled = false;
            dgvNhanSu.AutoGenerateColumns = false;

            int r = dgvNhanSu.CurrentCell.RowIndex;



            txtID_in4.Text = dgvNhanSu.Rows[r].Cells[0].Value.ToString();
            txtHoTen_in4.Text = dgvNhanSu.Rows[r].Cells[1].Value.ToString();
            txtLoaiNV_in4.Text = dgvNhanSu.Rows[r].Cells[7].Value.ToString();
            txtNgaySinh_in4.Text = dgvNhanSu.Rows[r].Cells[2].Value.ToString();
            txtCMND_in4.Text = dgvNhanSu.Rows[r].Cells[3].Value.ToString();
            txtQuequan_in4.Text = dgvNhanSu.Rows[r].Cells[4].Value.ToString();
            txtTuyenDuong_in4.Text = dgvNhanSu.Rows[r].Cells[5].Value.ToString();
            //pictureBox.Image = dgvNhanSu.Rows[r].Cells[6].Value.ToString();
        }

        void loadDataTD()
        {
            var list = db.getAllTD();
            var result = list.Select(x => new
            {
                IDTuyenDuong = x.IDTuyenDuong,
                NameTuyenDuong = x.DiemKhoiHanh + "-" + x.DiemDen
            });
            IDTuyenDuong.DataSource = result.ToList();
            IDTuyenDuong.ValueMember = "IDTuyenDuong";
            IDTuyenDuong.DisplayMember = "NameTuyenDuong";


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddNV addnv = new AddNV();
            addnv.Show();
            loadData();
        }

        string imgLoc = "";

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png| All Files (*.*)|*.*";
            // dlg.Title="Select "
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLoc = dlg.FileName.ToString();
                pictureBox.ImageLocation = imgLoc;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length > 0)
            {
                dgvNhanSu.DataSource = db.getNhanSuByNhanViens(Convert.ToInt32(txtID.Text));
                dgvNhanSu_CellClick(null, null);

            }
            else if (txtHoTen.Text.Length > 0)
            {
                dgvNhanSu.DataSource = db.searchByKey(txtHoTen.Text);
                dgvNhanSu_CellClick(null, null);

            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtHoTen.Text = " ";
        }

        private void dgvNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID_in4.Enabled = false;
            dgvNhanSu.AutoGenerateColumns = false;

            int r = dgvNhanSu.CurrentCell.RowIndex;



            txtID_in4.Text = dgvNhanSu.Rows[r].Cells[0].Value.ToString();
            txtHoTen_in4.Text = dgvNhanSu.Rows[r].Cells[1].Value.ToString();
            txtLoaiNV_in4.Text = dgvNhanSu.Rows[r].Cells[7].Value.ToString();
            txtNgaySinh_in4.Text = dgvNhanSu.Rows[r].Cells[2].Value.ToString();
            txtCMND_in4.Text = dgvNhanSu.Rows[r].Cells[3].Value.ToString();
            txtQuequan_in4.Text = dgvNhanSu.Rows[r].Cells[4].Value.ToString();
            txtTuyenDuong_in4.Text = dgvNhanSu.Rows[r].Cells[5].Value.ToString();
            //pictureBox.Image = dgvNhanSu.Rows[r].Cells[6].Value.ToString();
        }

        private void metroComboBox1_TextChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "Admin")
            {
                dgvNhanSu.DataSource = db.searchByStatus(1);
            }
            else if (metroComboBox1.Text == "Nhân Viên")
            {
                dgvNhanSu.DataSource = db.searchByStatus(2);
            }
            else if (metroComboBox1.Text == "Tài Xế")
            {
                dgvNhanSu.DataSource = db.searchByStatus(0);
            }
            else
            {
                dgvNhanSu.DataSource = db.searchByStatus(-1);
            }
            txtID.ResetText();
            txtHoTen.ResetText();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadNhanSu();
            txtID.Clear();
            txtHoTen.Clear();
            dgvNhanSu_CellClick(null, null);
            loadDataTD();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void loadNhanSu()
        {
            dgvNhanSu.DataSource = db.Select_NS();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadData();
            loadDataTD();
        }

        private void loadData()
        {

            txtID_in4.Enabled = false;
            dgvNhanSu.AutoGenerateColumns = false;
            var res = db.Select_NS();
            dgvNhanSu.DataSource = res;
            txtID_in4.DataBindings.Clear();
            txtHoTen_in4.DataBindings.Clear();
            txtNgaySinh_in4.DataBindings.Clear();
            txtCMND_in4.DataBindings.Clear();
            txtQuequan_in4.DataBindings.Clear();
            txtTuyenDuong_in4.DataBindings.Clear();
            pictureBox.DataBindings.Clear();
            txtLoaiNV_in4.DataBindings.Clear();

            txtID_in4.DataBindings.Add("Text", res, "IDNhanVien");
            txtHoTen_in4.DataBindings.Add("Text", res, "HoTen");
            txtNgaySinh_in4.DataBindings.Add("Text", res, "NgaySinh");
            txtCMND_in4.DataBindings.Add("Text", res, "Cmnd");
            txtQuequan_in4.DataBindings.Add("Text", res, "QueQuan");
            txtTuyenDuong_in4.DataBindings.Add("Text", res, "IDTuyenDuong");
            pictureBox.DataBindings.Add("Image", res, "image", true);
            txtLoaiNV_in4.DataBindings.Add("Text", res, "loainv");

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            string err = "";
            int IDNhanVien = Convert.ToInt32(txtID_in4.Text);
            try
            {
                DialogResult tl;
                tl = MessageBox.Show("Bạn có chắc chắn không", "Thông báo", MessageBoxButtons.OKCancel);
                if (tl == DialogResult.OK)
                {
                    db.deleteNS(IDNhanVien);
                    MessageBox.Show("Xóa xong");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa đc");
            }
            loadData();
            //loadDataTD();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID_in4.Text);
            DateTime dt = Convert.ToDateTime(txtNgaySinh_in4.Text);

            int tuyenduong = Convert.ToInt32(txtTuyenDuong_in4.Text);
            string ten = txtHoTen_in4.Text;
            string cmnd = txtCMND_in4.Text;
            string que = txtQuequan_in4.Text;

            int loaiNV = Convert.ToInt32(txtLoaiNV_in4.Text);

            string err = "";
            string pro = "";

            if (add)
            {
                if (pictureBox.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    nhansu.image = ms.ToArray();
                }
                else
                    nhansu.image = null;

                if (!db.updateNS(id, ten, dt, cmnd, que, tuyenduong, nhansu.image, loaiNV))
                    MessageBox.Show(err);
                else
                {
                    MessageBox.Show("Update success");

                }

            }
            loadData();
        }


    }
}
