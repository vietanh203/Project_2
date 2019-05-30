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
    public partial class Xe : MetroUserControl
    {
        BLXe frm = new BLXe();
        public Xe()
        {
            InitializeComponent();
        }

        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvXe.DataSource = frm.getDanhSachXe();
        }

        private void txtBenXe_TextChanged(object sender, EventArgs e)
        {
            dgvBX.DataSource = frm.searchBenXeTheoTenBenXe(txtBenXe.Text);
        }

        private void txtXe_TextChanged(object sender, EventArgs e)
        {
            //dgvDsachXe.DataSource = frm.getXeTheoIDBenXe(txtXe.Text);
            dgvXe.DataSource = frm.SearchDanhSachXeTheoBienSo(txtXe.Text);
        }

        private void Xe_Load(object sender, EventArgs e)
        {
            dgvBX.DataSource = frm.getBenXe();
            dgvXe.DataSource = frm.getDanhSachXe();
        }

        private void dgvBX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành  
            int r = dgvBX.CurrentCell.RowIndex;
            string getDuLieu;

            getDuLieu = dgvBX.Rows[r].Cells[0].Value.ToString();
            dgvXe.DataSource = frm.getXeTheoIDBenXe(getDuLieu);
        }

        private void menuThem_Click(object sender, EventArgs e)
        {
            AddXe xe = new AddXe();
            xe.mode = 0;
            xe.ShowDialog();
        }

        private void menuChinhSua_Click(object sender, EventArgs e)
        {
            int r = dgvXe.CurrentCell.RowIndex;

            AddXe xe = new AddXe();
            xe.mode = 1;
            xe.getid = dgvXe.Rows[r].Cells[0].Value.ToString();
            xe.getbienso = dgvXe.Rows[r].Cells[1].Value.ToString();
            xe.getmaloai = dgvXe.Rows[r].Cells[2].Value.ToString();
            xe.getidben = dgvXe.Rows[r].Cells[3].Value.ToString();
            xe.getstatus = dgvXe.Rows[r].Cells[4].Value.ToString();
            xe.ShowDialog();
        }

        private void menuXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa dữ liệu này không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int r = dgvXe.CurrentCell.RowIndex;
                string getid = dgvXe.Rows[r].Cells[0].Value.ToString();
                dgvXe.CurrentCell = null;
                dgvXe.Rows[r].Visible = false;
                //frm.xoaXe(Convert.ToInt32(getid));
                MessageBox.Show("Đã xóa xong !", "Thông Báo", MessageBoxButtons.OK);
            }
        }
    }
}
