using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Model;

namespace BusinessLogic
{
    public class BLLChuyenXe
    {

        DbQLBanVeXeKhachContext db = null;
        public BLLChuyenXe()
        {
            db = new DbQLBanVeXeKhachContext();
        }


        public class LichChuyenXe
        {
            public int idchuyen { get; set; }
            public TimeSpan? giokhoihanh { get; set; }
            public decimal? giave { get; set; }
            public string diemkhoihanh { get; set; }
            public string diemden { get; set; }
        }

        public List<LichChuyenXe> GetChuyenXe()
        {
            var result = from c in db.CHUYENXEs
                         join t in db.TUYENDUONGs on c.IDTuyenDuong equals t.IDTuyenDuong
                         join b in db.BENs on t.DiemKhoiHanh equals b.IDBen
                         join a in db.BENs on t.DiemDen equals a.IDBen
                         where t.DiemKhoiHanh != t.DiemDen && c.Status == 1
                         select new LichChuyenXe
                         {
                             idchuyen = c.IDChuyen,
                             giokhoihanh = c.GioKhoiHanh,
                             giave = c.GiaVe,
                             diemkhoihanh = b.TenBen,
                             diemden = a.TenBen
                         };
            return result.ToList();

        }

        public List<spSearchChuyenXeWithDiem_Result> TimChuyenXe(string diemkhoihanh)
        {
            return db.spSearchChuyenXeWithDiem(diemkhoihanh).ToList();
        }



        public List<LichChuyenXe> LayChuyenXeTheoTuyen(string diemkhoihanh, string diemden)
        {
            var result = from c in db.CHUYENXEs
                         join t in db.TUYENDUONGs on c.IDTuyenDuong equals t.IDTuyenDuong
                         join b in db.BENs on t.DiemKhoiHanh equals b.IDBen
                         join a in db.BENs on t.DiemDen equals a.IDBen
                         where t.DiemKhoiHanh != t.DiemDen && b.TenBen == diemkhoihanh && a.TenBen == diemden
                         select new LichChuyenXe
                         {
                             idchuyen = c.IDChuyen,
                             giokhoihanh = c.GioKhoiHanh,
                             giave = c.GiaVe,
                             diemkhoihanh = b.TenBen,
                             diemden = a.TenBen
                         };
            return result.ToList();
        }

        public void ThemChuyenXe(DateTime giokhoihanh, decimal? giave, int idtuyenduong, int status)
        {
            db.spInsertChuyenXe(giokhoihanh, giave, idtuyenduong, status);
        }

        public void ChinhSuaChuyenXe(int machuyenxe, DateTime giokhoihanh, decimal? giave, int idtuyenduong, int status)
        {
            db.spUpdateChuyenXe(machuyenxe, giokhoihanh, giave, idtuyenduong, status);
        }

        public void XoaChuyenXe(int machuyenxe, DateTime giokhoihanh, decimal? giave, int idtuyenduong, int status)
        {
            db.spUpdateChuyenXe(machuyenxe, giokhoihanh, giave, idtuyenduong, status);
        }

    }
}
