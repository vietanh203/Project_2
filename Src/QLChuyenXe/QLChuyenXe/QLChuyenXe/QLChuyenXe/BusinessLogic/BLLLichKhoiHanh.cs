using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Model;
using System.Data.Entity;

namespace BusinessLogic
{
    public class BLLLichKhoiHanh
    {
        DbQLBanVeXeKhachContext db;
        public BLLLichKhoiHanh()
        {
            db = new DbQLBanVeXeKhachContext();
        }
        public List<sp_GetALLChuyenXeChuaPhanCong_Result> getAllChuyenXeChuaPhanCong()
        {
            return db.sp_GetALLChuyenXeChuaPhanCong().ToList();
        }

        public List<XE> getAllXeTrongTheoBenKhoiHanh(string idBen)
        {
            return db.sp_LayXeTrongTheoIDBen(idBen).ToList();
        }

        public TUYENDUONG GetTuyenDuongByID(int idTuyenduong)
        {
            using (var context = new DbQLBanVeXeKhachContext())
            {
                return context.TUYENDUONGs.Where(x => x.IDTuyenDuong == idTuyenduong).FirstOrDefault();
            }
        }

        public List<NHANSU> GetTaiXeTheoTuyenDuong(int idTuyenDuong)
        {
            using (var context = new DbQLBanVeXeKhachContext())
            {
                return context.NHANSUs.Where(x => x.IDTuyenDuong == idTuyenDuong).ToList();
            }
        }

        public void UpdatePhanCongChuyenXe(int idChuyenXe,int idTaiXe1,int? idTaiXe2,int idXe)
        {
            db.sp_UpdateChuyenXeChuaPhanCong(idXe, idTaiXe1, idTaiXe2, idChuyenXe);
        }


        public List<sp_GetAllChuyenXeDaPhanCong_Result> GetAllChuyenXeDaPhanCong()
        {
            return db.sp_GetAllChuyenXeDaPhanCong().ToList();
        }


        public void UpdateTrangThaiHoanThanhChuyenXe(int idChuyenXe)
        {
            db.sp_UpdateTrangThaiChuyenXeDaHoanThanh(idChuyenXe);
        }

        public List<sp_GetTenBenCuaTuyenDuong_Result> GetTenBenCuaTuyenDuong()
        {
            return db.sp_GetTenBenCuaTuyenDuong().ToList();
        }
    }
}
