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
    public partial class ThongTinDatve : MetroForm
    {
        BLTraCuu frmTC = new BLTraCuu();
        BLThongTinDatVe frmTTDV = new BLThongTinDatVe();
        TraCuu tc = new TraCuu();

        public string getid;
        public string gettenkh;
        public string getsdt;

        public ThongTinDatve()
        {
            InitializeComponent();
        }

        private void ThongTinDatve_Load(object sender, EventArgs e)
        {
            try
            {
                txtTenKH.Text = gettenkh;
                txtSDT.Text = getsdt;
                var result = frmTTDV.getIDChuyenTheoIDKH(Convert.ToInt32(getid));
                this.cbMaChuyen.DataSource = frmTTDV.getIDChuyenTheoIDKH(Convert.ToInt32(getid));
                this.cbMaChuyen.DisplayMember = "IDChuyen";
                this.cbMaChuyen.ValueMember = "IDChuyen";

                this.cbMaNV.DataSource = frmTTDV.getIDChuyenTheoIDKH(Convert.ToInt32(getid));
                this.cbMaNV.DisplayMember = "MaNV";
                this.cbMaNV.ValueMember = "IDDatVe";

                this.cbNgayDatVe.DataSource = frmTTDV.getIDChuyenTheoIDKH(Convert.ToInt32(getid));
                this.cbNgayDatVe.DisplayMember = "NgayDat";
                this.cbNgayDatVe.ValueMember = "NgayDat";


                string test1 = cbMaChuyen.SelectedValue.ToString();
                string test2 = getid;
                var listNgayDi = frmTTDV.getNgayDi(Convert.ToInt32(cbMaChuyen.SelectedValue.ToString()), Convert.ToInt32(getid));
                this.cbNgayDi.DataSource = listNgayDi;
                this.cbNgayDi.DisplayMember = "NgayDi";
                this.cbNgayDi.ValueMember = "NgayDi";


                var listIDTuyen = frmTTDV.getIDTuyenDuongTheoNgayDi(Convert.ToDateTime(cbNgayDi.SelectedValue.ToString()));
                this.cbIDTuyenDuong.DataSource = listIDTuyen;
                this.cbIDTuyenDuong.DisplayMember = "IDTuyenDuong";
                this.cbIDTuyenDuong.ValueMember = "IDTuyenDuong";

                var listGioKH = frmTTDV.getGioKHTheoNgayKH(Convert.ToDateTime(cbNgayDi.SelectedValue.ToString()));
                this.cbGioKH.DataSource = listGioKH;
                this.cbGioKH.DisplayMember = "GioKhoiHanh";
                this.cbGioKH.ValueMember = "GioKhoiHanh";


                var listDiemKH = frmTTDV.getDiemKhoiHanh(Convert.ToInt32(cbIDTuyenDuong.SelectedValue.ToString()));
                this.cbDiemKhoiHanh.DataSource = listDiemKH;
                this.cbDiemKhoiHanh.DisplayMember = "DiemKhoiHanh";
                this.cbDiemKhoiHanh.ValueMember = "DiemKhoiHanh";


                var listIDXe = frmTTDV.getIDXe(Convert.ToInt32(cbIDTuyenDuong.SelectedValue.ToString()));
                this.cbIDXe.DataSource = listIDXe;
                this.cbIDXe.DisplayMember = "IDXe";
                this.cbIDXe.ValueMember = "IDXe";


                var listDiemDen = frmTC.getDiemDen(cbDiemKhoiHanh.SelectedValue.ToString());
                this.cbDiemDen.DataSource = listDiemDen;
                this.cbDiemDen.DisplayMember = "DiemDen";
                this.cbDiemDen.ValueMember = "DiemDen"; // int


                var listBienSo = frmTTDV.getBienSoTheoIDXe(Convert.ToInt32(cbIDXe.SelectedValue.ToString()));
                this.cbBienSo.DataSource = listBienSo;
                this.cbBienSo.DisplayMember = "BienSo";
                this.cbBienSo.ValueMember = "BienSo"; // int


                var listGiaVe = frmTTDV.getGiaVeTheoIDXe(Convert.ToInt32(cbIDXe.SelectedValue.ToString()));
                this.cbGiaVe.DataSource = listGiaVe;
                this.cbGiaVe.DisplayMember = "GiaVe";
                this.cbGiaVe.ValueMember = "NgayKhoiHanh"; // int

                var listSoGhe = frmTTDV.getSoGheTheoIDDV(Convert.ToInt32(cbMaNV.SelectedValue.ToString()));
                this.cbSoGhe.DataSource = listSoGhe;
                this.cbSoGhe.DisplayMember = "SoGhe";
                this.cbSoGhe.ValueMember = "SoGhe"; // int
            }
            catch (Exception)
            {

            }
            



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMaChuyen_Click(object sender, EventArgs e)
        {

        }

        private void cbMaChuyen_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbMaChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string test1 = cbMaChuyen.SelectedValue.ToString();
            //string test2 = getid;
            //var listNgayDi = frmTTDV.getNgayDi(Convert.ToInt32(cbMaChuyen.SelectedValue.ToString()), Convert.ToInt32(getid));
            //this.cbNgayDi.DataSource = listNgayDi;
            //this.cbNgayDi.DisplayMember = "NgayDi";
            //this.cbNgayDi.ValueMember = "NgayDi";
        }

        private void cbNgayDi_SelectedValueChanged(object sender, EventArgs e)
        {
            //var listIDTuyen = frmTTDV.getIDTuyenDuongTheoNgayDi(Convert.ToDateTime(cbNgayDi.Text));
            //this.cbIDTuyenDuong.DataSource = listIDTuyen;
            //this.cbIDTuyenDuong.DisplayMember = "IDTuyenDuong";
            //this.cbIDTuyenDuong.ValueMember = "IDTuyenDuong";

            //var listGioKH = frmTTDV.getGioKHTheoNgayKH(Convert.ToDateTime(cbNgayDi.Text));
            //this.cbGioKH.DataSource = listGioKH;
            //this.cbGioKH.DisplayMember = "GioKhoiHanh";
            //this.cbGioKH.ValueMember = "GioKhoiHanh";
        }

        private void cbIDTuyenDuong_SelectedValueChanged(object sender, EventArgs e)
        {
                //var listDiemKH = frmTTDV.getDiemKhoiHanh(Convert.ToInt32(cbIDTuyenDuong.Text));
                //this.cbDiemKhoiHanh.DataSource = listDiemKH;
                //this.cbDiemKhoiHanh.DisplayMember = "DiemKhoiHanh";
                //this.cbDiemKhoiHanh.ValueMember = "DiemKhoiHanh";


                //var listIDXe = frmTTDV.getIDXe(Convert.ToInt32(cbIDTuyenDuong.Text));
                //this.cbIDXe.DataSource = listIDXe;
                //this.cbIDXe.DisplayMember = "IDXe";
                //this.cbIDXe.ValueMember = "IDXe";
         }

        private void cbDiemKhoiHanh_SelectedValueChanged(object sender, EventArgs e)
        {
            //var listDiemDen = frmTC.getDiemDen(cbDiemKhoiHanh.SelectedValue.ToString());
            //this.cbDiemDen.DataSource = listDiemDen;
            //this.cbDiemDen.DisplayMember = "DiemDen";
            //this.cbDiemDen.ValueMember = "DiemDen"; // int
        }

        private void cbIDXe_SelectedValueChanged(object sender, EventArgs e)
        {
            //var listBienSo = frmTTDV.getBienSoTheoIDXe(Convert.ToInt32(cbIDXe.Text));
            //this.cbBienSo.DataSource = listBienSo;
            //this.cbBienSo.DisplayMember = "BienSo";
            //this.cbBienSo.ValueMember = "BienSo"; // int


            //var listGiaVe = frmTTDV.getGiaVeTheoIDXe(Convert.ToInt32(cbIDXe.Text));
            //this.cbGiaVe.DataSource = listGiaVe;
            //this.cbGiaVe.DisplayMember = "GiaVe";
            //this.cbGiaVe.ValueMember = "NgayKhoiHanh"; // int
        }

        private void cbMaNV_SelectedValueChanged(object sender, EventArgs e)
        {
            //var listSoGhe = frmTTDV.getSoGheTheoIDDV(Convert.ToInt32(cbMaNV.Text));
            //this.cbSoGhe.DataSource = listSoGhe;
            //this.cbSoGhe.DisplayMember = "SoGhe";
            //this.cbSoGhe.ValueMember = "SoGhe"; // int
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn Thoát không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                this.Close();
        }


    }
}
