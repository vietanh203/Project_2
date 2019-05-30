using DataProvider.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Threading;

namespace BusinessLogic
{
    public class BLDatVe
    {
        DbQLBanVeXeKhachContext db = null;
        public BLDatVe()
        {
            db = new DbQLBanVeXeKhachContext();
        }
        public List<BEN> getALLBenXe()
        {
            return db.sp_SelectAllBenXe().ToList();
        }


        public List<sp_GetTuyenDuongByDiemKhoiHanh2_Result> getTuyenDuongByDiemKhoiHanh2(string idDiemKhoiHanh)
        {
            return db.sp_GetTuyenDuongByDiemKhoiHanh2(idDiemKhoiHanh).ToList();
        }

        public List<CHUYENXE> getAllChuyenXeByTuyenDuong(int idtuyenduong)
        {
            return db.sp_GetChuyenXeByTuyenDuong(idtuyenduong).ToList();
        }


        public List<sp_LaySoGheTren1ChuyenXe_Result> LaySoGheTren1ChuyenXe(int idchuyenxe)
        {
            return db.sp_LaySoGheTren1ChuyenXe(idchuyenxe).ToList();
        }


        public List<CHUYENXETHUCTE> TimCXTTTheoIDTuyenDuongNgayKhoiHanhGioKhoiHanhSLVe(int iDTuyenDuong,string ngaykhoihanh,int sucChua,int soluong,TimeSpan gioKhoiHanh)
        {
            return db.sp_GetChuyenXeThucTeByIDTDuongNgayKhoiHanhGioKhoiHanh(iDTuyenDuong, ngaykhoihanh, sucChua, soluong, gioKhoiHanh).ToList();
        }

        //Thêm 1 chuyến xe mới, 1 khách hàng, 1 đặt vé
        public void ThemChuyenXeTTKhachHangDatVeSoGhe(
            int idtuyenDuong,TimeSpan gioikhoihanh,DateTime ngaykhoihanh,int giave,
            string tenkhachHang,string sdt,string cmnd,string email,
            int maNV,
            out int idchuyenxe,out int iddatve )
        {
            DateTime ngayDat = DateTime.Now;



                var idDatVe_temp = db.sp_ThemCXTT_DatVe_KhachHang_Transaction(idtuyenDuong, gioikhoihanh, ngaykhoihanh,null, null, null, giave, 0,
                                                                        tenkhachHang, sdt, cmnd, email, ngayDat, 5, 1);

                List<sp_LayIDChuyenXeVaIDDatVeVuaThem_Result> result = db.sp_LayIDChuyenXeVaIDDatVeVuaThem(tenkhachHang, ngayDat).ToList();
                idchuyenxe = result.ElementAt(0).IDCHUYEN.Value;
                iddatve = result.ElementAt(0).IDDATVE;
        }

        public void ThemDanhSachGheVaoBangTam(List<int> danhSachGhe,int idDatVe)
        {
            for(int i=0;i<danhSachGhe.Count;i++)
            {
                using (var context = new DbQLBanVeXeKhachContext())
                {
                    try
                    {
                        Temp_DatVe_SoGhe model = new Temp_DatVe_SoGhe
                        {
                            IDDatVe = idDatVe,
                            IDSoGhe = danhSachGhe[i]
                        };
                        context.Temp_DatVe_SoGhe.Add(model);
                        context.SaveChanges();
                        int x = model.ID;
                    }
                    catch (Exception ex)
                    {
                        string mess = ex.Message;
                    }
                }
            }
            
         }

        public void ThemGheChoDatVe(int idDatVe,int idChuyenxe)
        {
            db.sp_ThemDATVE_SOGHE_WITH_IDDATVE(idDatVe, idChuyenxe);
        }


        //Với th đa có chuyến xe thực tế
        public void ThemKhachHangVaDatVe(string tenkhachhang,string sdt,string cmnd,string email,int idchuyenxe, DateTime ngaykhoihanh,int manv,
           out int iddatveout)
        {
            DateTime ngayDat = DateTime.Now;
            iddatveout = 0;
            using (var context1 = new DbQLBanVeXeKhachContext())
            {
                try
                {
                    context1.sp_DatVe_KhachHang_Transaction(tenkhachhang, sdt, cmnd, email, idchuyenxe, ngaykhoihanh, ngayDat, manv,1);
                    List<sp_LayIDChuyenXeVaIDDatVeVuaThem_Result> result = db.sp_LayIDChuyenXeVaIDDatVeVuaThem(tenkhachhang, ngayDat).ToList();
                    iddatveout = result.ElementAt(0).IDDATVE;
                }
                catch (Exception ex)
                {
                    string mess = ex.Message;
                }
            }
        }




    }
}
