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
    public partial class AddTuyenDuong : MetroForm
    {
        public AddTuyenDuong()
        {
            InitializeComponent();
        }

        public AddTuyenDuong(string _diemkhoihanh, string _diemden, int _flag, string _matuyenduong)
        {
            InitializeComponent();
            diemkhoihanh = _diemkhoihanh;
            diemden = _diemden;
            flag = _flag;
            matuyenduong = _matuyenduong;
        }

        public string matuyenduong;
        public string diemkhoihanh;
        public string diemden;
        public int flag;


        private void AddTuyenDuong_Load(object sender, EventArgs e)
        {

            BLLBen b = new BLLBen();
            cbDiemDen.DataSource = b.GetBen();
            cbDiemDen.DisplayMember = "TenBen";
            cbDiemDen.ValueMember = "IDBen";
            cbDiemKhoiHanh.DataSource = b.GetBen();
            cbDiemKhoiHanh.DisplayMember = "TenBen";
            cbDiemKhoiHanh.ValueMember = "IDBen";

            cbDiemKhoiHanh.Text = diemkhoihanh;
            cbDiemDen.Text = diemden;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLLTuyenDuong t = new BLLTuyenDuong();
            BLLBen b = new BLLBen();
            var x = b.GetBen();
            for (int i = 0; i < x.Count; i++)
            {
                if (x[i].TenBen == cbDiemKhoiHanh.Text)
                {
                    diemkhoihanh = x[i].IDBen;
                }
                if (x[i].TenBen == cbDiemDen.Text)
                {
                    diemden = x[i].IDBen;
                }
            }
            if (flag == 1)
            {
                t.ThemTuyenDuong(diemkhoihanh, diemden);
                DialogResult res = MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                    this.Close();
            }
            else
            {
                t.ChinhSuaTuyenDuong(Convert.ToInt32(matuyenduong), diemkhoihanh, diemden);
                DialogResult res = MessageBox.Show("Chỉnh Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
