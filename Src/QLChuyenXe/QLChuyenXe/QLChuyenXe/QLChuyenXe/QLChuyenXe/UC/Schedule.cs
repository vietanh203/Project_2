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
    public partial class Schedule : MetroUserControl
    {

        BLDatVe blDatVe = new BLDatVe();
        public Schedule()
        {
            InitializeComponent();
            dgvLichTrinh.AutoGenerateColumns = false;
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            cbDiemKhoiHanh.DataSource = blDatVe.getALLBenXe();
            cbDiemKhoiHanh.DisplayMember = "TenBen";
            cbDiemKhoiHanh.ValueMember = "IDBen";
        }

        private void cbDiemKhoiHanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idDiemKhoiHanh = cbDiemKhoiHanh.SelectedValue.ToString();
            cbDiemDen.DataSource = blDatVe.getTuyenDuongByDiemKhoiHanh2(idDiemKhoiHanh);
            cbDiemDen.ValueMember = "IDTuyenDuong";
            cbDiemDen.DisplayMember = "TENDIEMDEN";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvLichTrinh.DataSource = blDatVe.getAllChuyenXeByTuyenDuong(Convert.ToInt32(cbDiemDen.SelectedValue));
        }

        private void dgvLichTrinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                formDatVe frm = new formDatVe();
                frm._diemKhoiHanh = this.cbDiemKhoiHanh.GetItemText(this.cbDiemKhoiHanh.SelectedItem);
                frm._diemDen = this.cbDiemDen.GetItemText(this.cbDiemDen.SelectedItem);
                frm._idChuyenXe = Convert.ToInt32(dgvLichTrinh.Rows[e.RowIndex].Cells[0].Value.ToString());
                //frm._gioKhoiHanh = Convert.ToDateTime(dgvLichTrinh.Rows[e.RowIndex].Cells[1].Value.ToString());
                frm._idTuyenDuong= Convert.ToInt32(dgvLichTrinh.Rows[e.RowIndex].Cells[3].Value.ToString());
                frm.mode = 1;
                frm.Show();
            }
        }
    }
}
