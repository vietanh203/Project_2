using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Model;
using System.Data;


namespace BusinessLogic
{
    public class BLXe
    {
        DbQLBanVeXeKhachContext db = new DbQLBanVeXeKhachContext();

        public List<spGetBen_Result> getBenXe()
        {
            return db.spGetBen().ToList();
        }
        public List<XE> searchMaLoai(string name)
        {
            return db.XEs.Where(y => y.MaLoai == name).ToList();
        }

        public List<BEN> searchBenXeTheoTenBenXe(string name)
        {
            return db.BENs.Where(y => y.TenBen.Contains(name)).ToList();
        }

        //-------------------------------------------------- TABLE LOAI XE

        public List<spGetLoaiXe_Result> getLoaiXe()
        {
            return db.spGetLoaiXe().ToList();
        }

        //-------------------------------------------------- TABLE XE

        public List<spGetXe_Result> getDanhSachXe()
        {
            return db.spGetXe().ToList();
        }
        public List<spGetXeTheoIDBenXe_Result> getXeTheoIDBenXe(string name)
        {
            return db.spGetXeTheoIDBenXe(name).ToList();
        }

        public List<XE> SearchDanhSachXeTheoBienSo(string name)
        {
            return db.XEs.Where(y => y.BienSo.Contains(name)).ToList();
        }


        public bool themXe(string bienSo, string maLoai, string idBen)
        {
            try
            {
                db.spThemXe(bienSo, maLoai, idBen);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaXe(int id, string bienSo, string maLoai, string idBen, int staTus)
        {
            try
            {
                db.spSuaXe(id, bienSo, staTus);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool xoaXe(int id, string bienSo, int staTus)
        {
            try
            {
                db.spSuaXe(id, bienSo, staTus);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
