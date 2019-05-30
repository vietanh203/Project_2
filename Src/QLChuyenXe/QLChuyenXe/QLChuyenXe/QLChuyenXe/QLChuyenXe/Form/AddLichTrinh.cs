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
    public partial class AddLichTrinh : MetroForm
    {
        public AddLichTrinh()
        {
            InitializeComponent();
            
        }

        public AddLichTrinh(string _machuyenxe, string _diemden, string _diemkhoihanh, string _giokhoihanh, decimal _giave, int _flag)
        {
            InitializeComponent();
            flag = _flag;
            machuyenxe = _machuyenxe;
            diemkhoihanh = _diemkhoihanh;
            diemden = _diemden;
            giokhoihanh = _giokhoihanh;
            giave = _giave;
        }
        public string machuyenxe;
        public int flag;
        public int _idtuyenduong;
        public string diemkhoihanh;
        public String diemden;
        public string giokhoihanh;
        public decimal giave;


        private void AddLichTrinh_Load(object sender, EventArgs e)
        {
            BLLTuyenDuong t = new BLLTuyenDuong();
            cbIDTuyenDuong.DataSource = t.getTenTuyenDuong();
            cbIDTuyenDuong.DisplayMember = "tuyenduong";
            cbIDTuyenDuong.ValueMember = "tuyenduong";
            if (flag == 0)
            {
                cbIDTuyenDuong.Text = diemkhoihanh + "--->" + diemden;
                dpThoiGian.Text = giokhoihanh;
                txtGiaVe.Text = Convert.ToString(giave);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLLChuyenXe c = new BLLChuyenXe();
            BLLTuyenDuong t = new BLLTuyenDuong();
            var x = t.GetTuyenDuong();
            for (int i = 0; i < x.Count; i++)
            {
                var diemkhoihanh = t.GetDiem(x[i].DiemKhoiHanh);
                var diemden = t.GetDiem(x[i].DiemDen);
                string a = diemkhoihanh[0].TenBen + "--->" + diemden[0].TenBen;
                if (a == cbIDTuyenDuong.Text)
                {
                    _idtuyenduong = x[i].IDTuyenDuong;

                }
            }
            if (flag == 1)
            {
                c.ThemChuyenXe(Convert.ToDateTime(dpThoiGian.Text), Convert.ToDecimal(txtGiaVe.Text), _idtuyenduong, 1);
                DialogResult res = MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                    this.Close();
            }
            else
            {
                c.ChinhSuaChuyenXe(Convert.ToInt32(machuyenxe), Convert.ToDateTime(dpThoiGian.Text), Convert.ToDecimal(txtGiaVe.Text), _idtuyenduong, 1);
                DialogResult res = MessageBox.Show("Chỉnh Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                if (res == DialogResult.OK)
                    this.Close();
            }
        }
    }
}
