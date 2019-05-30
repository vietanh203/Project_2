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

namespace QLChuyenXe
{
    public partial class LichTrinh : MetroUserControl
    {
        public string maben;
        public string _diemkhoihanh;
        public string _diemden;
        public string diemden1;
        public string matuyenduong;
        public int idtuyenduong;
        public string machuyenxe;
        public string _giokhoihanh;
        public decimal _giave;

        public LichTrinh()
        {
            InitializeComponent();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thembenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbBen.Items.Clear();
            lbTuyen.Items.Clear();
            LoadBen();
            LoadTuyenDuong();
            LoadLichTrinh();
            LoadLichTrinh();
        }

        private void LichTrinh_Load(object sender, EventArgs e)
        {
            LoadBen();
            LoadTuyenDuong();
            LoadLichTrinh();
        }

        // bến
        void LoadBen()
        {
            BLLBen b = new BLLBen();
            var x = b.GetBen();
            for (int i = 0; i < x.Count; i++)
            {
                lbBen.Items.Add(x[i].TenBen);
            }
        }
        // tuyến đường
        void LoadTuyenDuong()
        {
            BLLTuyenDuong t = new BLLTuyenDuong();
            //x la bien cua list<tuyenduong>
            var x = t.GetTuyenDuong();
            for (int i = 0; i < x.Count; i++)
            {
                var diemKhoiHanh = t.GetDiem(x[i].DiemKhoiHanh);
                var diemDen = t.GetDiem(x[i].DiemDen);
                if (x[i].Status == 1)
                {
                    lbTuyen.Items.Add(diemKhoiHanh[0].TenBen + "--->" + diemDen[0].TenBen);
                }

            }
        }
        // lịch trình
        void LoadLichTrinh()
        {
            BLLChuyenXe c = new BLLChuyenXe();
            dgvLichChay.DataSource = c.GetChuyenXe();
        }


        // click vào bến để tìm tuyến đường

        private void lbBen_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbBen.SelectedItem != null)
            {
                lbTuyen.Items.Clear();
                //a là tên biến để lấy bến 
                string a = lbBen.SelectedItem.ToString();
                BLLTuyenDuong t = new BLLTuyenDuong();
                var x = t.GetTuyenDuong();
                for (int i = 0; i < x.Count; i++)
                {
                    var diemkhoihanh = t.GetDiem(x[i].DiemKhoiHanh);
                    var diemden = t.GetDiem(x[i].DiemDen);
                    if (a == diemkhoihanh[0].TenBen)
                    {
                        lbTuyen.Items.Add(diemkhoihanh[0].TenBen + "--->" + diemden[0].TenBen);
                    }
                }
            }
        }

        private void pictureReload1_Click(object sender, EventArgs e)
        {
            lbBen.Items.Clear();
            lbTuyen.Items.Clear();
            LoadBen();
            LoadTuyenDuong();
            LoadLichTrinh();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLLBen a = new BLLBen();
            var x = a.GetBen();
            for (int i = 0; i < x.Count; i++)
            {
                if (x[i].TenBen == lbBen.SelectedItem.ToString())
                {
                    maben = x[i].IDBen;
                    break;
                }
            }
            //
            AddBenXe b = new AddBenXe(maben, lbBen.SelectedItem.ToString(), 0);
            b.ShowDialog();
            lbBen.Items.Clear();
            lbTuyen.Items.Clear();
            LoadBen();
            LoadTuyenDuong();
            LoadLichTrinh();
        }
        ////Thêm bến 
        private void chToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBenXe b = new AddBenXe("", "", 1);
            b.ShowDialog();
            lbBen.Items.Clear();
            lbTuyen.Items.Clear();
            LoadBen();
            LoadTuyenDuong();
            LoadLichTrinh();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddTuyenDuong t = new AddTuyenDuong("", "", 1, "");
            t.ShowDialog();
            lbBen.Items.Clear();
            lbTuyen.Items.Clear();
            LoadBen();
            LoadTuyenDuong();
            LoadLichTrinh();
            LoadLichTrinh();
        }
        //chỉnh sửa tuyến đường
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BLLTuyenDuong t = new BLLTuyenDuong();
            var x = t.GetTuyenDuong();
            for (int i = 0; i < x.Count; i++)
            {
                var diemkhoihanh = t.GetDiem(x[i].DiemKhoiHanh);
                var diemden = t.GetDiem(x[i].DiemDen);
                string a = diemkhoihanh[0].TenBen + "--->" + diemden[0].TenBen;
                if (a == lbTuyen.Text)
                {
                    _diemkhoihanh = diemkhoihanh[0].TenBen;
                    _diemden = diemden[0].TenBen;
                    matuyenduong = Convert.ToString(x[i].IDTuyenDuong);
                    break;
                }
            }
            AddTuyenDuong b = new AddTuyenDuong(_diemkhoihanh, _diemden, 0, matuyenduong);
            b.ShowDialog();
            lbBen.Items.Clear();
            lbTuyen.Items.Clear();
            LoadBen();
            LoadTuyenDuong();
            LoadLichTrinh();
            LoadLichTrinh();
        }
        // reset tuyến đường
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbBen.Items.Clear();
            lbTuyen.Items.Clear();
            LoadBen();
            LoadTuyenDuong();
            LoadLichTrinh();
            LoadLichTrinh();
        }

        // thêm lịch trình 
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            AddLichTrinh l = new AddLichTrinh("", "", "", "", 0, 1);
            l.ShowDialog();
            LoadLichTrinh();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            AddLichTrinh l = new AddLichTrinh(machuyenxe, _diemkhoihanh, diemden1, _giokhoihanh, _giave, 0);
            l.ShowDialog();
            LoadLichTrinh();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            lbBen.Items.Clear();
            lbTuyen.Items.Clear();
            LoadBen();
            LoadTuyenDuong();
            LoadLichTrinh();
            LoadLichTrinh();
        }

        private void lbTuyen_MouseClick(object sender, MouseEventArgs e)
        {
            BLLChuyenXe c = new BLLChuyenXe();
            BLLTuyenDuong t = new BLLTuyenDuong();
            var x = t.GetTuyenDuong();
            for (int i = 0; i < x.Count; i++)
            {
                var diemkhoihanh = t.GetDiem(x[i].DiemKhoiHanh);
                var diemden = t.GetDiem(x[i].DiemDen);
                string a = diemkhoihanh[0].TenBen + "--->" + diemden[0].TenBen;
                if (a == lbTuyen.Text)
                {
                    _diemkhoihanh = diemkhoihanh[0].TenBen;
                    _diemden = diemden[0].TenBen;
                    break;
                }
            }
            if (lbTuyen.SelectedItem != null)
            {
                dgvLichChay.DataSource = c.LayChuyenXeTheoTuyen(_diemkhoihanh, _diemden);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadLichTrinh();
        }

        private void dgvLichChay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLichChay.CurrentCell.RowIndex;
            machuyenxe = dgvLichChay.Rows[r].Cells[0].Value.ToString();
            _giokhoihanh = dgvLichChay.Rows[r].Cells[1].Value.ToString();
            _giave = Convert.ToDecimal(dgvLichChay.Rows[r].Cells[2].Value.ToString());
            _diemkhoihanh = dgvLichChay.Rows[r].Cells[3].Value.ToString();
            diemden1 = dgvLichChay.Rows[r].Cells[4].Value.ToString();
        }

        private void txtLichChay_KeyPress(object sender, KeyPressEventArgs e)
        {
            BLLChuyenXe c = new BLLChuyenXe();
            dgvLichChay.DataSource = c.TimChuyenXe(txtLichChay.Text);
        }

        private void txtBenTuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                for (int i = 0; i < lbBen.Items.Count; i++)
                {
                    if (txtBenTuyen.Text == lbBen.Items[i].ToString())
                    {
                        lbBen.Items.Clear();
                        lbBen.Items.Add(txtBenTuyen.Text);
                        TimTuyen(txtBenTuyen.Text);
                        break;
                    }
                }
            }
        }

        void TimTuyen(string tenben)
        {
            lbTuyen.Items.Clear();
            //a là tên biến để lấy bến 
            BLLTuyenDuong t = new BLLTuyenDuong();
            var x = t.GetTuyenDuong();
            for (int i = 0; i < x.Count; i++)
            {
                var diemkhoihanh = t.GetDiem(x[i].DiemKhoiHanh);
                var diemden = t.GetDiem(x[i].DiemDen);
                if (tenben == diemkhoihanh[0].TenBen)
                {
                    lbTuyen.Items.Add(diemkhoihanh[0].TenBen + "--->" + diemden[0].TenBen);
                }
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            BLLChuyenXe c = new BLLChuyenXe();
            BLLTuyenDuong t = new BLLTuyenDuong();
            var x = t.GetTuyenDuong();
            for (int i = 0; i < x.Count; i++)
            {
                var diemkhoihanh = t.GetDiem(x[i].DiemKhoiHanh);
                var diemden = t.GetDiem(x[i].DiemDen);
                if (_diemkhoihanh == diemkhoihanh[0].TenBen && diemden1 == diemden[0].TenBen)
                {
                    idtuyenduong = x[i].IDTuyenDuong;

                }
            }
            c.XoaChuyenXe(Convert.ToInt32(machuyenxe), Convert.ToDateTime(_giokhoihanh), Convert.ToDecimal(_giave), idtuyenduong, 0);
            LoadLichTrinh();
        }


    }
}
