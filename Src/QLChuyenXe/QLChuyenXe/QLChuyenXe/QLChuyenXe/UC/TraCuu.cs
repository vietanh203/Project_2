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
    public partial class TraCuu : MetroUserControl
    {
        BLTraCuu frm = new BLTraCuu();
        public TraCuu()
        {
            InitializeComponent();
        }

        private void TraCuu_Load(object sender, EventArgs e)
        {
            dvgChuyenXe.DataSource = frm.getCXTT();

            this.cbDiemKhoiHanh.DataSource = frm.getTuyenDuong();
            this.cbDiemKhoiHanh.DisplayMember = "DiemKhoiHanh";
            this.cbDiemKhoiHanh.ValueMember = "DiemKhoiHanh";

            dgvHanhKhach.DataSource = frm.getKhachHang();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dvgChuyenXe.DataSource = frm.getCXTT();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dvgChuyenXe.DataSource = frm.getNgayKhoiHanh(Convert.ToInt32(cbDiemDen.SelectedValue.ToString()));
        }

        private void cbDiemKhoiHanh_SelectedValueChanged(object sender, EventArgs e)
        {
            var listDiemDen = frm.getDiemDen(cbDiemKhoiHanh.SelectedValue.ToString());
            this.cbDiemDen.DataSource = listDiemDen;
            this.cbDiemDen.DisplayMember = "DiemDen";
            this.cbDiemDen.ValueMember = "IDTuyenDuong"; // int
        }

        private void cbDiemDen_SelectedValueChanged(object sender, EventArgs e)
        {
            //var listNgayKhoiHanh = frm.getNgayKhoiHanh(Convert.ToInt32(cbDiemDen.SelectedValue.ToString()));
            //this.cbNgayKhoiHanh.DataSource = listNgayKhoiHanh;
            //cbNgayKhoiHanh.DisplayMember = "NgayKhoiHanh";
            //cbNgayKhoiHanh.ValueMember = "NgayKhoiHanh";
        }

        private void cbDiemDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listNgayKhoiHanh = frm.getNgayKhoiHanh(Convert.ToInt32(cbDiemDen.SelectedValue.ToString()));
            this.cbNgayKhoiHanh.DataSource = listNgayKhoiHanh;
            cbNgayKhoiHanh.DisplayMember = "NgayKhoiHanh";
            cbNgayKhoiHanh.ValueMember = "NgayKhoiHanh";
        }

        private void dgvHanhKhach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = dgvHanhKhach.CurrentCell.RowIndex;
            ThongTinDatve frmdv = new ThongTinDatve();
            frmdv.getid = dgvHanhKhach.Rows[r].Cells[0].Value.ToString();
            frmdv.gettenkh = dgvHanhKhach.Rows[r].Cells[1].Value.ToString();
            frmdv.getsdt = dgvHanhKhach.Rows[r].Cells[2].Value.ToString();

            //--------------------------------------------------------



            frmdv.ShowDialog();
        }
    }
}
