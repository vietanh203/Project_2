using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Model;

namespace BusinessLogic
{
    public class BLLTuyenDuong
    {

        DbQLBanVeXeKhachContext db = null;
        public BLLTuyenDuong()
        {
            db = new DbQLBanVeXeKhachContext();
        }

        public List<BEN> GetDiem(string maben)
        {
            var result = from b in db.BENs
                         where b.IDBen == maben
                         select b;
            return result.ToList();
        }

        public List<TUYENDUONG> GetTuyenDuong()
        {
            var result = from t in db.TUYENDUONGs
                         select t;
            return result.ToList();
        }

        public void ThemTuyenDuong(string diemkhoihanh, string diemden)
        {
            db.spInsertTuyenDuong(diemkhoihanh, diemden, 1);
        }

        public void ChinhSuaTuyenDuong(int idtuyenduong, string diemkhoihanh, string diemden)
        {
            db.spUpdateTuyenDuong(idtuyenduong, diemkhoihanh, diemden, 1);
        }

        public List<LICHTRINH> getTenTuyenDuong()
        {
            var result = from t in db.TUYENDUONGs
                         join b in db.BENs on t.DiemKhoiHanh equals b.IDBen
                         join a in db.BENs on t.DiemDen equals a.IDBen
                         where t.DiemKhoiHanh != t.DiemDen
                         select new LICHTRINH
                         {
                             tuyenduong = b.TenBen + "--->" + a.TenBen
                         };
            return result.ToList();
        }

        public class LICHTRINH
        {
            public string tuyenduong { get; set; }
        }


    }
}
