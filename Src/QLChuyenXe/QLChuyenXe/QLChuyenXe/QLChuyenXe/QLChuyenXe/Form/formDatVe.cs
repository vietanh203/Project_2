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

namespace QLChuyenXe
{
    public partial class formDatVe : MetroForm
    {
        public formDatVe()
        {
            InitializeComponent();
            

        }
        public int mode = 0;
        public int flag = 1;
        public int _maNV = 1;
        public int _defaultSucChua = 28;
        public int _idChuyenXe = 0;
        public string _diemKhoiHanh = "";
        public string _diemDen = "";
        public int _idTuyenDuong = 0;
        public TimeSpan _gioKhoiHanh;
        public DateTime _ngayKhoiHanh;
        int _giaVe = 0;
        KhachHang kh = new KhachHang();
        BLDatVe blDatVe = new BLDatVe();
        List<int> listGheDaChon = new List<int>();
        List<CHUYENXE> _danhSachChuyenXe = new List<CHUYENXE>();
        


        private void formDatVe_Load(object sender, EventArgs e)
        {
            tabThongTin.SelectedTab = tabChonTuyen;
            DisableTabPage();
            if (mode == 1)
            {
                LoadData();
            }
        }

        void LoadData()
        {
            cbDiemKhoiHanh.Text = _diemKhoiHanh;
            cbDiemDen.Text = _diemDen;
            cbDiemKhoiHanh.Enabled = false;
            cbDiemDen.Enabled = false;
        }

        void DisableTabPage()
        {
            foreach  (TabPage tab in tabThongTin.TabPages)
            {
                tab.Enabled = false;
            }
            (tabThongTin.TabPages[0] as TabPage).Enabled = true;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            int slve = 0;
            if(int.TryParse(txtSoLuongVe.Text, out slve))
            {
                if(slve<=0)
                {
                    MessageBox.Show("Số lượng vé mua không thể nhỏ hơn hoặc bằng 0 ");
                }
                else
                {
                    (tabThongTin.TabPages[1] as TabPage).Enabled = true;
                    tabThongTin.SelectedTab = tabChonGhe;
                    Step1_LayNhungChuyenXeThoaMan();
                }
            }
            else
            {
                MessageBox.Show("Vui long nhập lại số lượng vé. Đây là số");
            }
            
        }


        void Step1_LayNhungChuyenXeThoaMan()
        {
            //đặt tên cho cái date time picker là dtPickerNgayKhoiHanh
            string ngayKhoiHanh = dtPickerNgayKhoiHanh.Value.ToString("yyyy-MM-dd");
            int soLuongVe = Convert.ToInt32(txtSoLuongVe.Text);

            var result = blDatVe.getAllChuyenXeByTuyenDuong(_idTuyenDuong);
            _danhSachChuyenXe = result;
            

            //Hiển thị lên các control
            lblDiemKhoiHanh.Text = _diemKhoiHanh;
            lblDiemDen.Text = _diemDen;
            lblNgayDi.Text = ngayKhoiHanh;
            lblDiemKhoiHanh_2tab2.Text = _diemKhoiHanh;
            lblDiemDen_2tab2.Text = _diemDen;
            lblNgayDitab2.Text = ngayKhoiHanh;


            //Load giờ khởi hành dữ liệu lên combobox
            cboGioKhoiHanh.DataSource = result;
            cboGioKhoiHanh.ValueMember = "GioKhoiHanh";
            cboGioKhoiHanh.DisplayMember = "GioKhoiHanh";
            

            //biến debug
        }

        

        void Step2_ChonNgayKhoiHanhVaChonGhe()
        {

        }

        private void tabDatVe_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
        }

        private void btnTiepTuctab2_Click(object sender, EventArgs e)
        {
            (tabThongTin.TabPages[2] as TabPage).Enabled = true;
            tabThongTin.SelectedTab = tabThongTinKhachHang;

        }

        private void cboGioKhoiHanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLayGhe_Click(object sender, EventArgs e)
        {
            string str = cboGioKhoiHanh.SelectedValue.ToString();
            
            //Lấy ra giá vé

            decimal giaVeDecimal = _danhSachChuyenXe.Where(x => x.GioKhoiHanh.ToString() == str).FirstOrDefault().GiaVe.Value;
            _giaVe = Convert.ToInt32(giaVeDecimal);
            lblGiaVe.Text = _giaVe.ToString();
            
            
            //Lấy ra chuyến xe theo IDTuyenDuong,NgayKhoiHanh,SoLuong,GioKhoiHanh

            var dt = Convert.ToDateTime(str);
            int hours = dt.Hour;
            int minutes = dt.Minute;
            int seconds = dt.Second;


            TimeSpan gioKhoiHanh = new TimeSpan(hours,minutes,seconds);
            _gioKhoiHanh = gioKhoiHanh;

            string ngayKhoiHanh = dtPickerNgayKhoiHanh.Value.ToString("yyyy-MM-dd");
            _ngayKhoiHanh = Convert.ToDateTime(ngayKhoiHanh);

            int soLuongVe = Convert.ToInt32(txtSoLuongVe.Text);

            var listCXTT = blDatVe.TimCXTTTheoIDTuyenDuongNgayKhoiHanhGioKhoiHanhSLVe(_idTuyenDuong, ngayKhoiHanh, _defaultSucChua, soLuongVe, gioKhoiHanh);

            if (listCXTT.Count!=0)
            {
                //Chuyến xe đã có trong bảng cxtt
                _idChuyenXe= listCXTT.ElementAt(0).IDChuyenXe;
                LoadDanhSachGhe(_idChuyenXe, _defaultSucChua);
            }
            else
            {
                //Chuyến xe chưa có trong bảng CXTT
                flag = 0;
                LoadSoDoGheKhiXeChuaCoChuyenThucTe();
            }
        }


        void LoadDanhSachGhe(int idchuyenxe, int soLuongGhe)
        {
            listGheDaChon.Clear();
            tlpDanhsachGhe.Controls.Clear();
            List<sp_LaySoGheTren1ChuyenXe_Result> listGhe = blDatVe.LaySoGheTren1ChuyenXe(idchuyenxe);
            List<int> danhSachSoGhe = new List<int>();

            foreach (var item in listGhe)
            {
                danhSachSoGhe.Add(item.SOGHE);
            }

            for (int i = 1; i <= soLuongGhe; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(30, 30);
                btn.Name = String.Format("btnGhe{0}", i);
                btn.Text = i.ToString();
                if (danhSachSoGhe.Contains(i))
                {
                    btn.BackColor = Color.Gray;
                    btn.Enabled = false;
                    

                }
                btn.Click += new EventHandler(ClickChonGhe);
                tlpDanhsachGhe.Controls.Add(btn);
            }
        }

        protected void ClickChonGhe(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            int idGhe = Convert.ToInt32(btn.Text);
            if (btn.BackColor == Color.Orange)
            {
                btn.BackColor = default(Color);

                if (listGheDaChon.Contains(idGhe))
                {
                    listGheDaChon.Remove(idGhe);
                }
            }
            else
            {
                btn.BackColor = Color.Orange;
                listGheDaChon.Add(idGhe);
            }
            lblTongTien.Text = String.Format("Tổng tiền: {0}", listGheDaChon.Count * _giaVe);

        }

        void LoadSoDoGheKhiXeChuaCoChuyenThucTe()
        {
            listGheDaChon.Clear();
            tlpDanhsachGhe.Controls.Clear();

            for (int i = 1; i < 28; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Size = new Size(30, 30);
                btn.Name = String.Format("btnGhe{0}", i);           
                btn.Click += new EventHandler(ClickChonGhe);
                tlpDanhsachGhe.Controls.Add(btn);
            }
        }

        private void btnTiepTucThongTinKhachHang_Click(object sender, EventArgs e)
        {
            (tabThongTin.TabPages[3] as TabPage).Enabled = true;
            tabThongTin.SelectedTab = tabThanhToan;
            kh.TenKH = txtHoTen_Tab3.Text;
            kh.SDT = txtSDT_Tab3.Text;
            kh.CMND = txtCMND_Tab3.Text;
            kh.Email = txtEmail_Tab3.Text;

            //
            lblTenTuyenDuong_tab4.Text = _diemKhoiHanh + "=>" + _diemDen;
            lblNgayDi_tab4.Text = _ngayKhoiHanh.ToString("yyyy-MM-dd");
            lblSoGhe_tab4.Text = "";
            for (int i = 0; i < listGheDaChon.Count; i++)
            {
                lblSoGhe_tab4.Text += listGheDaChon[i].ToString();
                if(i+1!=listGheDaChon.Count)
                {
                    lblSoGhe_tab4.Text += ",";
                }
            }
            lblGioKhoiHanh_tab4.Text = _gioKhoiHanh.ToString();
            lblSoLuongVe.Text = listGheDaChon.Count.ToString();
            lblHoTen_tab4.Text = kh.TenKH;
            lblCMND_tab4.Text = kh.CMND;
            lblEmail_tab4.Text = kh.Email;
            lblSoDienThoai_tab4.Text = kh.SDT;

            lblTongTien_tab4.Text = (listGheDaChon.Count * _giaVe).ToString();


        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //Tiến hành đặt vé
            int idDatVeOut = 0;
            int idChuyenXeOut = 0;
            DialogResult result;
            if(listGheDaChon.Count==0)
            {
                result = MessageBox.Show("Bạn chưa chọn ghế", "Thông báo", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Warning);
            }
            else if(txtHoTen_Tab3.Text.Trim().Equals(""))
            {
                result = MessageBox.Show("Bạn chưa chọn ghế", "Thông báo", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (flag == 0)
                    {
                        blDatVe.ThemChuyenXeTTKhachHangDatVeSoGhe(_idTuyenDuong, _gioKhoiHanh, _ngayKhoiHanh, _giaVe, kh.TenKH, kh.SDT, kh.CMND, kh.Email, _maNV, out idChuyenXeOut, out idDatVeOut);
                        blDatVe.ThemDanhSachGheVaoBangTam(listGheDaChon, idDatVeOut);
                        blDatVe.ThemGheChoDatVe(idDatVeOut, idChuyenXeOut);
                    }
                    else
                    {
                        blDatVe.ThemKhachHangVaDatVe(kh.TenKH, kh.SDT, kh.CMND, kh.Email, _idChuyenXe, _ngayKhoiHanh, _maNV, out idDatVeOut);
                        blDatVe.ThemDanhSachGheVaoBangTam(listGheDaChon, idDatVeOut);
                        blDatVe.ThemGheChoDatVe(idDatVeOut, _idChuyenXe);
                    }

                    MessageBox.Show("Đặt vé thành công");
                    btnThanhToan.Enabled = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Đặt vé thất bại"); ;
                }
            }
            
        }

        private void btnHuy_tab1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuayLai_tab2_Click(object sender, EventArgs e)
        {
            tabThongTin.SelectedTab = tabChonTuyen;
        }

        private void btnTroVeThongTinKhachHang_Click(object sender, EventArgs e)
        {
            tabThongTin.SelectedTab = tabChonGhe;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabThongTin.SelectedTab = tabThongTinKhachHang;
        }
    }
}
