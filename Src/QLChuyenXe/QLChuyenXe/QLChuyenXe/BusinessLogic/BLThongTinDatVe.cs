using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Model;

namespace BusinessLogic
{
        public class BLThongTinDatVe
        {
            DbQLBanVeXeKhachContext db = new DbQLBanVeXeKhachContext();

        public List<spGetDiemKhoiHanhTheoIDTuyenDuong_Result> getDiemKhoiHanh(int id)
        {
            return db.spGetDiemKhoiHanhTheoIDTuyenDuong(id).ToList();
        }
        public List<spGetIDXeTheoIDTuyenDuong_Result> getIDXe(int id)
        {
            return db.spGetIDXeTheoIDTuyenDuong(id).ToList();
        }

        public List<spGetIDChuyenTheoIDKH_Result> getIDChuyenTheoIDKH(int id)
            {
                return db.spGetIDChuyenTheoIDKH(id).ToList();
            }
            public List<spGetIDTuyenDuongTheoNgayDi_Result> getIDTuyenDuongTheoNgayDi(DateTime ngaydi)
            {
                return db.spGetIDTuyenDuongTheoNgayDi(ngaydi).ToList();
            }
            public List<spGetNgayDiTheoIDChuyenIDHK_Result> getNgayDi(int idc, int idhk)
            {
                return db.spGetNgayDiTheoIDChuyenIDHK(idc, idhk).ToList();
            }
            public List<spGetBienSoTheoIDXe_Result> getBienSoTheoIDXe(int id)
            {
                return db.spGetBienSoTheoIDXe(id).ToList();
            }
            public List<spGetGiaVeTheoIDXe_Result> getGiaVeTheoIDXe(int id)
            {
                return db.spGetGiaVeTheoIDXe(id).ToList();
            }

            public List<spgetSoGheTheoIDDatVe_Result> getSoGheTheoIDDV(int id)
            {
                return db.spgetSoGheTheoIDDatVe(id).ToList();
            }
            public List<spgetGioKHTheoNgayKH_Result> getGioKHTheoNgayKH(DateTime gioKH)
            {
                return db.spgetGioKHTheoNgayKH(gioKH).ToList();
            }
        }
}
