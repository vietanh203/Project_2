using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Model;

namespace BusinessLogic
{
    public class BLTraCuu
    {
        DbQLBanVeXeKhachContext db = new DbQLBanVeXeKhachContext();


        //---------------------------------Table HANH KHACH

        public List<spGetCXTT_Result> getCXTT()
        {
            return db.spGetCXTT().ToList();
        }
        public List<spGetDiemDenTheoDiemKhoiHanh_Result> getDiemDen(string diemkhoihanh)
        {
            return db.spGetDiemDenTheoDiemKhoiHanh(diemkhoihanh).ToList();
        }
        public List<spGetNgayKhoiHanhTheoIDTD_Result> getNgayKhoiHanh(int id)
        {
            return db.spGetNgayKhoiHanhTheoIDTD(id).ToList();
        }

        //---------------------------------Table CXTT

        public List<spGetTuyenDuong_Result> getTuyenDuong()
        {
            return db.spGetTuyenDuong().ToList();
        }

        public List<spGetKhachHang_Result> getKhachHang()
        {
            return db.spGetKhachHang().ToList();
        }

    }
}
