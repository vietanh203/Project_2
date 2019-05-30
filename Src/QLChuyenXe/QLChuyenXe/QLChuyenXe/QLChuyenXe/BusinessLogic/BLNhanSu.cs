using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Model;

namespace BusinessLogic
{
    public class BLNhanSu
    {
        DbQLBanVeXeKhachContext db = new DbQLBanVeXeKhachContext();
        public List<spSelect_NS_Result> Select_NS()
        {
            return db.spSelect_NS().ToList();
        }

        public List<TUYENDUONG> getAllTD()
        {
            return db.TUYENDUONGs.ToList();
        }
        //public List<spGetNhanSuByID_Result> GetNhanSuByID(int idNhanVien)
        //{
        //    return db.spGetNhanSuByID(idNhanVien).ToList();
        //}

        public bool InsertNS(string HoTen, DateTime NgaySinh, string Cmnd, string QueQuan, int IDTuyenDuong, byte[] image, int loainv)
        {
            try
            {
                db.spInserts_NS(HoTen, Convert.ToDateTime(NgaySinh), Cmnd, QueQuan, IDTuyenDuong, image, loainv);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool updateNS(int IDNhanVien, string HoTen, DateTime NgaySinh, string Cmnd, string QueQuan, int IDTuyenDuong, byte[] image, int loainv)
        {
            try
            {
                db.spUpdate_NS(IDNhanVien, HoTen, Convert.ToDateTime(NgaySinh), Cmnd, QueQuan, IDTuyenDuong, image, loainv);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool deleteNS(int IDNhanVien)
        {
            try
            {
                db.spDelete_NS1(IDNhanVien);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public object GetNhanSuByID(string text)
        {
            throw new NotImplementedException();
        }

        public List<dynamic> GetNhanVienDgv()
        {
            return db.NHANSUs.Select(t => new
            {
                IDNhanVien = t.IDNhanVien,
                HoTen = t.HoTen,
                NgaySinh = t.NgaySinh,
                Cmnd = t.Cmnd,
                QueQuan = t.QueQuan,
                IDTuyenDuong = t.IDTuyenDuong,
                loainv = t.loainv,
                image = t.image
            }).ToList<dynamic>();
        }

        public List<spGetUserByID_Result> getUserByIdPass(string user, string pass)
        {
            return db.spGetUserByID(user, pass).ToList();
        }
        public List<spGetNSByIDNhanVien_Result> getNhanSuByNhanViens(int idNhanVien)
        {
            return db.spGetNSByIDNhanVien(idNhanVien).ToList();
        }
        public List<spSearchByStatus_Result> searchByStatus(int loainv)
        {
            return db.spSearchByStatus(loainv).ToList();
        }
        public List<spSearchNSByName_Result> searchByName(string hoTen)
        {
            return db.spSearchNSByName(hoTen).ToList();
        }

        public List<FN_NS_SearchByKeyword_Result> searchByKey(string keyword)
        {
            return db.FN_NS_SearchByKeyword(keyword).ToList();
        }
    }
}
