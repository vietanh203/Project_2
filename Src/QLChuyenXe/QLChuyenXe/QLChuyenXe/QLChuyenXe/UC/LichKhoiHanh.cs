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

namespace QLChuyenXe
{
    public partial class LichKhoiHanh : MetroUserControl
    {
        BLLLichKhoiHanh bllLichKH;
        List<NHANSU> _listTaiXe1;
        List<NHANSU> _listTaiXe2;
        int _idTuyen;
        int _idChuyen;
        //Biến kiểm tra combobox đã thay đổi dữ liêu hay là chỉ vừa load dữ liệu lên
        int checkCbo = 0;


        public LichKhoiHanh()
        {
            InitializeComponent();
        }

        private void LichKhoiHanh_Load(object sender, EventArgs e)
        {
            dgvChuyenChuaPhanCong.AutoGenerateColumns = false;
            dgvChuyenDaPhanCong.AutoGenerateColumns = false;
            LoadDuLieuChuaPhanCong();
            LoadDuLieuDaPhanCong();
        }

        void LoadDuLieuChuaPhanCong()
        {
            dgvChuyenChuaPhanCong.DataSource = new BLLLichKhoiHanh().getAllChuyenXeChuaPhanCong();
            dgvChuyenChuaPhanCong_CellClick(null, null);
        }

        void LoadDuLieuDaPhanCong()
        {
            dgvChuyenDaPhanCong.DataSource = new BLLLichKhoiHanh().GetAllChuyenXeDaPhanCong();
            dgvChuyenDaPhanCong_CellClick(null, null);
        }


        private void dgvChuyenChuaPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvChuyenChuaPhanCong.CurrentCell.RowIndex;
            lblMaChuyenXe.Text = dgvChuyenChuaPhanCong.Rows[r].Cells["colIDChuyenXe"].Value.ToString();
            lblMaTuyenDuong.Text = dgvChuyenChuaPhanCong.Rows[r].Cells["colTuyenDuong"].Value.ToString();
            DateTime ngayKhoiHanh = Convert.ToDateTime(dgvChuyenChuaPhanCong.Rows[r].Cells["colNgayKhoiHanh"].Value);
            lblNgayKhoiHanh.Text = ngayKhoiHanh.ToString("yyyy-MM-dd");
            lblGioiKhoiHanh.Text = dgvChuyenChuaPhanCong.Rows[r].Cells["colGioKhoiHanh"].Value.ToString();
        }

        private void btnPhancong_Click(object sender, EventArgs e)
        {
            try
            {
                btnHuy.Enabled = true;
                if (btnPhancong.Text == "Phân công")
                {
                    //Load ComboBox Xe trống theo điểm khởi hành
                    int r = dgvChuyenChuaPhanCong.CurrentCell.RowIndex;
                    _idTuyen = Convert.ToInt32(dgvChuyenChuaPhanCong.Rows[r].Cells["colIDTuyenDuong"].Value);
                    TUYENDUONG tuyenDuong = new BLLLichKhoiHanh().GetTuyenDuongByID(_idTuyen);
                    List<DataProvider.Model.XE> listXe = new BLLLichKhoiHanh().getAllXeTrongTheoBenKhoiHanh(tuyenDuong.DiemKhoiHanh);
                    cboXe.DataSource = listXe;
                    cboXe.ValueMember = "IDXe";
                    cboXe.DisplayMember = "BienSo";

                    cboXe.Enabled = true;
                    cboSoLuongTX.Enabled = true;

                    btnPhancong.Enabled = false;

                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Bạn có chắc chắn phân công như vậy ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _idChuyen = Convert.ToInt32(lblMaChuyenXe.Text);
                        int mode = cboSoLuongTX.SelectedIndex;
                        int idxe1Selected;
                        int idXe;


                        if (mode == 1)
                        {
                            idxe1Selected = Convert.ToInt32(cboTaiXe1.SelectedValue);
                            idXe = Convert.ToInt32(cboXe.SelectedValue);
                            bllLichKH = new BLLLichKhoiHanh();
                            bllLichKH.UpdatePhanCongChuyenXe(_idChuyen, idxe1Selected, null, idXe);

                            result = MessageBox.Show("Phân công tài xế thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDuLieuChuaPhanCong();
                            LoadDuLieuDaPhanCong();
                            LoadTrangThaiBanDau();
                        }
                        else if (mode == 2)
                        {
                            idXe = Convert.ToInt32(cboXe.SelectedValue);
                            idxe1Selected = Convert.ToInt32(cboTaiXe1.SelectedValue);
                            int idxe2Selected = Convert.ToInt32(cboTaixe2.SelectedValue);
                            bllLichKH = new BLLLichKhoiHanh();
                            bllLichKH.UpdatePhanCongChuyenXe(_idChuyen, idxe1Selected, idxe2Selected, idXe);

                            result = MessageBox.Show("Phân công tài xế thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDuLieuChuaPhanCong();
                            LoadDuLieuDaPhanCong();
                            LoadTrangThaiBanDau();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cboTaiXe1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkCbo!=0 && cboSoLuongTX.SelectedIndex==2)
            {
                cboTaixe2.Enabled = true;
                int r = dgvChuyenChuaPhanCong.CurrentCell.RowIndex;
                int idTuyen = Convert.ToInt32(dgvChuyenChuaPhanCong.Rows[r].Cells["colIDTuyenDuong"].Value);
                _listTaiXe2 = new BLLLichKhoiHanh().GetTaiXeTheoTuyenDuong(idTuyen);
                NHANSU taixe = new NHANSU();
                taixe = _listTaiXe2.Where(x => x.IDNhanVien == Convert.ToInt32(cboTaiXe1.SelectedValue)).FirstOrDefault();
                _listTaiXe2.Remove(taixe);     
                cboTaixe2.DataSource = _listTaiXe2;
                cboTaixe2.ValueMember = "IDNhanVien";
                cboTaixe2.DisplayMember = "HoTen";            
            }
        }

        void LoadTaiXe1()
        {
            //LoadCombox tài xế
            _listTaiXe1 = new BLLLichKhoiHanh().GetTaiXeTheoTuyenDuong(_idTuyen);

            cboTaiXe1.DataSource = _listTaiXe1;
            cboTaiXe1.ValueMember = "IDNhanVien";
            cboTaiXe1.DisplayMember = "HoTen";

            //Đổi trang thái các combobox
            cboXe.Enabled = true;
            cboTaiXe1.Enabled = true;

            //Tăng biến combobox lên khi đã load xong
            checkCbo++;

            //Đổi text của button btn
            btnPhancong.Text = "Lưu";
        }

        private void cboSoLuongTX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSoLuongTX.SelectedIndex == 0)
            {
                btnPhancong.Enabled = false;
                cboTaiXe1.Enabled = false;
                cboTaixe2.Enabled = false;
            } else if (cboSoLuongTX.SelectedIndex == 1)
            {
                cboTaixe2.Enabled = false;
                btnPhancong.Enabled = true;
                LoadTaiXe1();
            }  
            else //=2
            {
                btnPhancong.Enabled = true;
                LoadTaiXe1();
            }
        }

        void LoadTrangThaiBanDau()
        {
            //Trở về ban đầu
            cboXe.DataSource = null;
            cboTaiXe1.DataSource = null;
            cboTaixe2.DataSource = null;

            //Giao diện
            btnPhancong.Text = "Phân công";

            cboSoLuongTX.SelectedIndex = 0;

            cboXe.Enabled = false;
            cboTaiXe1.Enabled = false;
            cboTaixe2.Enabled = false;
            cboSoLuongTX.Enabled = false;

            btnPhancong.Enabled = true;
            btnHuy.Enabled = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadTrangThaiBanDau();
        }




        //ĐANG VIẾT DỠ

        //Phân chuyến xe đã phân công
        private void dgvChuyenDaPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvChuyenDaPhanCong.CurrentCell.RowIndex;
            if(dgvChuyenDaPhanCong.Rows[r].Cells["colMaChuyenXe_DPCong"].Value==null)
            {
                lblMaChuyenXe_DPC.Text = "NULL";

            }
            else
            {
                lblMaChuyenXe_DPC.Text = dgvChuyenDaPhanCong.Rows[r].Cells["colMaChuyenXe_DPCong"].Value.ToString();
            }

            if (dgvChuyenDaPhanCong.Rows[r].Cells["colTuyenDuong_DPCong"].Value == null)
            {
                lblMaTuyenDuong_DPC.Text = "NULL";

            }
            else
            {
                lblMaTuyenDuong_DPC.Text = dgvChuyenDaPhanCong.Rows[r].Cells["colTuyenDuong_DPCong"].Value.ToString();
            }

            DateTime ngaykhoiHanh2 = Convert.ToDateTime(dgvChuyenDaPhanCong.Rows[r].Cells["colNgayKhoiHanh_DPCong"].Value.ToString());
            lblNgayKhoiHanh_DPC.Text = ngaykhoiHanh2.ToString("yyyy-MM-dd");
            lblGioKhoiHanh_DPC.Text = dgvChuyenDaPhanCong.Rows[r].Cells["colGioKhoiHanh_DPCong"].Value.ToString();
           // lblXe_DPC.Text= dgvChuyenDaPhanCong.Rows[r].Cells["colXe_DPC"].Value.ToString();

            if (dgvChuyenDaPhanCong.Rows[r].Cells["colXe_DPC"].Value == null)
            {
                lblXe_DPC.Text = "NULL";
            }
            else
            {
                lblXe_DPC.Text = dgvChuyenDaPhanCong.Rows[r].Cells["colXe_DPC"].Value.ToString();
            }

            if (dgvChuyenDaPhanCong.Rows[r].Cells["colTaiXe1_DPC"].Value==null)
            {
                lblTaiXe1_DPC.Text = "NULL";
            }
            else
            {
                lblTaiXe1_DPC.Text = dgvChuyenDaPhanCong.Rows[r].Cells["colTaiXe1_DPC"].Value.ToString();
            }

            if (dgvChuyenDaPhanCong.Rows[r].Cells["colTaixe2_DPC"].Value == null)
            {
                lblTaiXe2_DPC.Text = "NULL";
            }
            else
            {
                lblTaiXe2_DPC.Text = dgvChuyenDaPhanCong.Rows[r].Cells["colTaixe2_DPC"].Value.ToString();
            }

            int statusChuyen;
            if (dgvChuyenDaPhanCong.Rows[r].Cells["colTrangThaiChuyen_DPCong"].Value!=null)
            {
                statusChuyen = Convert.ToInt32(dgvChuyenDaPhanCong.Rows[r].Cells["colIDTrangThai_DPC"].Value);
            }
            else
            {
                statusChuyen = 0;
            }
            


            if (statusChuyen==1)
            {
                btnXacNhanChuyenHoanThanh.Enabled = false;
            }
            else
            {
                btnXacNhanChuyenHoanThanh.Enabled = true;
            }

        }

        private void btnXacNhanChuyenHoanThanh_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn rằng chuyến xe này đã hoàn thành ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                int maChuyen = Convert.ToInt32(lblMaChuyenXe_DPC.Text);
                bllLichKH = new BLLLichKhoiHanh();
                bllLichKH.UpdateTrangThaiHoanThanhChuyenXe(maChuyen);
                LoadDuLieuDaPhanCong();
                result = MessageBox.Show("Xác nhận chuyến xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDuLieuChuaPhanCong();
        }


        private void refreshCmsDPCong_Click(object sender, EventArgs e)
        {
            LoadDuLieuDaPhanCong();
        }
    }
}
