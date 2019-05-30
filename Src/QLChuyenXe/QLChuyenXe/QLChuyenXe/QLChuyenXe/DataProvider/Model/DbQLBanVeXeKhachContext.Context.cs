﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataProvider.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbQLBanVeXeKhachContext : DbContext
    {
        public DbQLBanVeXeKhachContext()
            : base("name=DbQLBanVeXeKhachContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<BEN> BENs { get; set; }
        public virtual DbSet<CHAY> CHAYs { get; set; }
        public virtual DbSet<CHUYENXETHUCTE> CHUYENXETHUCTEs { get; set; }
        public virtual DbSet<DATVE> DATVEs { get; set; }
        public virtual DbSet<DATVE_SOGHE> DATVE_SOGHE { get; set; }
        public virtual DbSet<LOAIXE> LOAIXEs { get; set; }
        public virtual DbSet<SODIENTHOAI> SODIENTHOAIs { get; set; }
        public virtual DbSet<TUYENDUONG> TUYENDUONGs { get; set; }
        public virtual DbSet<XE> XEs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Temp_DatVe_SoGhe> Temp_DatVe_SoGhe { get; set; }
        public virtual DbSet<CHUYENXE> CHUYENXEs { get; set; }
        public virtual DbSet<NHANSU> NHANSUs { get; set; }
    
        public virtual ObjectResult<BEN> sp_SelectAllBenXe()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BEN>("sp_SelectAllBenXe");
        }
    
        public virtual ObjectResult<BEN> sp_SelectAllBenXe(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BEN>("sp_SelectAllBenXe", mergeOption);
        }
    
        public virtual ObjectResult<sp_GetTuyenDuongByDiemKhoiHanh2_Result> sp_GetTuyenDuongByDiemKhoiHanh2(string iDDiemKhoiHanh)
        {
            var iDDiemKhoiHanhParameter = iDDiemKhoiHanh != null ?
                new ObjectParameter("IDDiemKhoiHanh", iDDiemKhoiHanh) :
                new ObjectParameter("IDDiemKhoiHanh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetTuyenDuongByDiemKhoiHanh2_Result>("sp_GetTuyenDuongByDiemKhoiHanh2", iDDiemKhoiHanhParameter);
        }
    
        public virtual ObjectResult<sp_LaySoGheTren1ChuyenXe_Result> sp_LaySoGheTren1ChuyenXe(Nullable<int> idchuyen)
        {
            var idchuyenParameter = idchuyen.HasValue ?
                new ObjectParameter("idchuyen", idchuyen) :
                new ObjectParameter("idchuyen", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_LaySoGheTren1ChuyenXe_Result>("sp_LaySoGheTren1ChuyenXe", idchuyenParameter);
        }
    
        public virtual ObjectResult<sp_LayIDChuyenXeVaIDDatVeVuaThem_Result> sp_LayIDChuyenXeVaIDDatVeVuaThem(string tenKhachHang, Nullable<System.DateTime> ngaydat)
        {
            var tenKhachHangParameter = tenKhachHang != null ?
                new ObjectParameter("TenKhachHang", tenKhachHang) :
                new ObjectParameter("TenKhachHang", typeof(string));
    
            var ngaydatParameter = ngaydat.HasValue ?
                new ObjectParameter("Ngaydat", ngaydat) :
                new ObjectParameter("Ngaydat", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_LayIDChuyenXeVaIDDatVeVuaThem_Result>("sp_LayIDChuyenXeVaIDDatVeVuaThem", tenKhachHangParameter, ngaydatParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_ThemDATVE_SOGHE_WITH_IDDATVE(Nullable<int> idDatVe, Nullable<int> idCXTT)
        {
            var idDatVeParameter = idDatVe.HasValue ?
                new ObjectParameter("idDatVe", idDatVe) :
                new ObjectParameter("idDatVe", typeof(int));
    
            var idCXTTParameter = idCXTT.HasValue ?
                new ObjectParameter("idCXTT", idCXTT) :
                new ObjectParameter("idCXTT", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_ThemDATVE_SOGHE_WITH_IDDATVE", idDatVeParameter, idCXTTParameter);
        }
    
        public virtual int spInsertBen(string idben, string tenben)
        {
            var idbenParameter = idben != null ?
                new ObjectParameter("idben", idben) :
                new ObjectParameter("idben", typeof(string));
    
            var tenbenParameter = tenben != null ?
                new ObjectParameter("tenben", tenben) :
                new ObjectParameter("tenben", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertBen", idbenParameter, tenbenParameter);
        }
    
        public virtual int spUpdateBen(string idben, string tenben)
        {
            var idbenParameter = idben != null ?
                new ObjectParameter("idben", idben) :
                new ObjectParameter("idben", typeof(string));
    
            var tenbenParameter = tenben != null ?
                new ObjectParameter("tenben", tenben) :
                new ObjectParameter("tenben", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateBen", idbenParameter, tenbenParameter);
        }
    
        public virtual int spInsertChuyenXe(Nullable<System.DateTime> giokhoihanh, Nullable<decimal> giave, Nullable<int> idtuyenduong, Nullable<int> status)
        {
            var giokhoihanhParameter = giokhoihanh.HasValue ?
                new ObjectParameter("giokhoihanh", giokhoihanh) :
                new ObjectParameter("giokhoihanh", typeof(System.DateTime));
    
            var giaveParameter = giave.HasValue ?
                new ObjectParameter("giave", giave) :
                new ObjectParameter("giave", typeof(decimal));
    
            var idtuyenduongParameter = idtuyenduong.HasValue ?
                new ObjectParameter("idtuyenduong", idtuyenduong) :
                new ObjectParameter("idtuyenduong", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertChuyenXe", giokhoihanhParameter, giaveParameter, idtuyenduongParameter, statusParameter);
        }
    
        public virtual ObjectResult<spSearchChuyenXeWithDiem_Result> spSearchChuyenXeWithDiem(string diemkhoihanh)
        {
            var diemkhoihanhParameter = diemkhoihanh != null ?
                new ObjectParameter("diemkhoihanh", diemkhoihanh) :
                new ObjectParameter("diemkhoihanh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSearchChuyenXeWithDiem_Result>("spSearchChuyenXeWithDiem", diemkhoihanhParameter);
        }
    
        public virtual int spUpdateChuyenXe(Nullable<int> idchuyenxe, Nullable<System.DateTime> giokhoihanh, Nullable<decimal> giave, Nullable<int> idtuyenduong, Nullable<int> status)
        {
            var idchuyenxeParameter = idchuyenxe.HasValue ?
                new ObjectParameter("idchuyenxe", idchuyenxe) :
                new ObjectParameter("idchuyenxe", typeof(int));
    
            var giokhoihanhParameter = giokhoihanh.HasValue ?
                new ObjectParameter("giokhoihanh", giokhoihanh) :
                new ObjectParameter("giokhoihanh", typeof(System.DateTime));
    
            var giaveParameter = giave.HasValue ?
                new ObjectParameter("giave", giave) :
                new ObjectParameter("giave", typeof(decimal));
    
            var idtuyenduongParameter = idtuyenduong.HasValue ?
                new ObjectParameter("idtuyenduong", idtuyenduong) :
                new ObjectParameter("idtuyenduong", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateChuyenXe", idchuyenxeParameter, giokhoihanhParameter, giaveParameter, idtuyenduongParameter, statusParameter);
        }
    
        public virtual ObjectResult<CHUYENXE> sp_GetChuyenXeByTuyenDuong(Nullable<int> iDTuyenDuong)
        {
            var iDTuyenDuongParameter = iDTuyenDuong.HasValue ?
                new ObjectParameter("IDTuyenDuong", iDTuyenDuong) :
                new ObjectParameter("IDTuyenDuong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CHUYENXE>("sp_GetChuyenXeByTuyenDuong", iDTuyenDuongParameter);
        }
    
        public virtual ObjectResult<CHUYENXE> sp_GetChuyenXeByTuyenDuong(Nullable<int> iDTuyenDuong, MergeOption mergeOption)
        {
            var iDTuyenDuongParameter = iDTuyenDuong.HasValue ?
                new ObjectParameter("IDTuyenDuong", iDTuyenDuong) :
                new ObjectParameter("IDTuyenDuong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CHUYENXE>("sp_GetChuyenXeByTuyenDuong", mergeOption, iDTuyenDuongParameter);
        }
    
        public virtual int spUpdateTuyenDuong(Nullable<int> idtuyenduong, string diemkhoihanh, string diemden, Nullable<int> status)
        {
            var idtuyenduongParameter = idtuyenduong.HasValue ?
                new ObjectParameter("idtuyenduong", idtuyenduong) :
                new ObjectParameter("idtuyenduong", typeof(int));
    
            var diemkhoihanhParameter = diemkhoihanh != null ?
                new ObjectParameter("diemkhoihanh", diemkhoihanh) :
                new ObjectParameter("diemkhoihanh", typeof(string));
    
            var diemdenParameter = diemden != null ?
                new ObjectParameter("diemden", diemden) :
                new ObjectParameter("diemden", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateTuyenDuong", idtuyenduongParameter, diemkhoihanhParameter, diemdenParameter, statusParameter);
        }
    
        public virtual int spInsertTuyenDuong(string diemkhoihanh, string diemden, Nullable<int> status)
        {
            var diemkhoihanhParameter = diemkhoihanh != null ?
                new ObjectParameter("diemkhoihanh", diemkhoihanh) :
                new ObjectParameter("diemkhoihanh", typeof(string));
    
            var diemdenParameter = diemden != null ?
                new ObjectParameter("diemden", diemden) :
                new ObjectParameter("diemden", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertTuyenDuong", diemkhoihanhParameter, diemdenParameter, statusParameter);
        }
    
        [DbFunction("DbQLBanVeXeKhachContext", "FN_NS_SearchByKeyword")]
        public virtual IQueryable<FN_NS_SearchByKeyword_Result> FN_NS_SearchByKeyword(string keyword)
        {
            var keywordParameter = keyword != null ?
                new ObjectParameter("keyword", keyword) :
                new ObjectParameter("keyword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FN_NS_SearchByKeyword_Result>("[DbQLBanVeXeKhachContext].[FN_NS_SearchByKeyword](@keyword)", keywordParameter);
        }
    
        public virtual int spDelete_NS1(Nullable<int> manv)
        {
            var manvParameter = manv.HasValue ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDelete_NS1", manvParameter);
        }
    
        public virtual ObjectResult<spGetNSByIDNhanVien_Result> spGetNSByIDNhanVien(Nullable<int> idNhanVien)
        {
            var idNhanVienParameter = idNhanVien.HasValue ?
                new ObjectParameter("idNhanVien", idNhanVien) :
                new ObjectParameter("idNhanVien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetNSByIDNhanVien_Result>("spGetNSByIDNhanVien", idNhanVienParameter);
        }
    
        public virtual ObjectResult<spGetUserByID_Result> spGetUserByID(string user, string pass)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetUserByID_Result>("spGetUserByID", userParameter, passParameter);
        }
    
        public virtual int spInserts_NS(string hoTen, Nullable<System.DateTime> ngaySinh, string cmnd, string queQuan, Nullable<int> iDTuyenDuong, byte[] image, Nullable<int> loainv)
        {
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("NgaySinh", ngaySinh) :
                new ObjectParameter("NgaySinh", typeof(System.DateTime));
    
            var cmndParameter = cmnd != null ?
                new ObjectParameter("Cmnd", cmnd) :
                new ObjectParameter("Cmnd", typeof(string));
    
            var queQuanParameter = queQuan != null ?
                new ObjectParameter("QueQuan", queQuan) :
                new ObjectParameter("QueQuan", typeof(string));
    
            var iDTuyenDuongParameter = iDTuyenDuong.HasValue ?
                new ObjectParameter("IDTuyenDuong", iDTuyenDuong) :
                new ObjectParameter("IDTuyenDuong", typeof(int));
    
            var imageParameter = image != null ?
                new ObjectParameter("image", image) :
                new ObjectParameter("image", typeof(byte[]));
    
            var loainvParameter = loainv.HasValue ?
                new ObjectParameter("loainv", loainv) :
                new ObjectParameter("loainv", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInserts_NS", hoTenParameter, ngaySinhParameter, cmndParameter, queQuanParameter, iDTuyenDuongParameter, imageParameter, loainvParameter);
        }
    
        [DbFunction("DbQLBanVeXeKhachContext", "spSearchByStatus")]
        public virtual IQueryable<spSearchByStatus_Result> spSearchByStatus(Nullable<int> loainv)
        {
            var loainvParameter = loainv.HasValue ?
                new ObjectParameter("loainv", loainv) :
                new ObjectParameter("loainv", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<spSearchByStatus_Result>("[DbQLBanVeXeKhachContext].[spSearchByStatus](@loainv)", loainvParameter);
        }
    
        public virtual ObjectResult<spSearchNSByName_Result> spSearchNSByName(string hoTen)
        {
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("hoTen", hoTen) :
                new ObjectParameter("hoTen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSearchNSByName_Result>("spSearchNSByName", hoTenParameter);
        }
    
        public virtual ObjectResult<spSelect_NS_Result> spSelect_NS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelect_NS_Result>("spSelect_NS");
        }
    
        public virtual int spUpdate_NS(Nullable<int> iDNhanVien, string hoTen, Nullable<System.DateTime> ngaySinh, string cmnd, string queQuan, Nullable<int> iDTuyenDuong, byte[] image, Nullable<int> loainv)
        {
            var iDNhanVienParameter = iDNhanVien.HasValue ?
                new ObjectParameter("IDNhanVien", iDNhanVien) :
                new ObjectParameter("IDNhanVien", typeof(int));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("NgaySinh", ngaySinh) :
                new ObjectParameter("NgaySinh", typeof(System.DateTime));
    
            var cmndParameter = cmnd != null ?
                new ObjectParameter("Cmnd", cmnd) :
                new ObjectParameter("Cmnd", typeof(string));
    
            var queQuanParameter = queQuan != null ?
                new ObjectParameter("QueQuan", queQuan) :
                new ObjectParameter("QueQuan", typeof(string));
    
            var iDTuyenDuongParameter = iDTuyenDuong.HasValue ?
                new ObjectParameter("IDTuyenDuong", iDTuyenDuong) :
                new ObjectParameter("IDTuyenDuong", typeof(int));
    
            var imageParameter = image != null ?
                new ObjectParameter("image", image) :
                new ObjectParameter("image", typeof(byte[]));
    
            var loainvParameter = loainv.HasValue ?
                new ObjectParameter("loainv", loainv) :
                new ObjectParameter("loainv", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdate_NS", iDNhanVienParameter, hoTenParameter, ngaySinhParameter, cmndParameter, queQuanParameter, iDTuyenDuongParameter, imageParameter, loainvParameter);
        }
    
        public virtual ObjectResult<spGetBen_Result> spGetBen()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBen_Result>("spGetBen");
        }
    
        public virtual ObjectResult<spGetCXTT_Result> spGetCXTT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetCXTT_Result>("spGetCXTT");
        }
    
        public virtual ObjectResult<spGetDiemDenTheoDiemKhoiHanh_Result> spGetDiemDenTheoDiemKhoiHanh(string diemKhoiHanh)
        {
            var diemKhoiHanhParameter = diemKhoiHanh != null ?
                new ObjectParameter("DiemKhoiHanh", diemKhoiHanh) :
                new ObjectParameter("DiemKhoiHanh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetDiemDenTheoDiemKhoiHanh_Result>("spGetDiemDenTheoDiemKhoiHanh", diemKhoiHanhParameter);
        }
    
        public virtual ObjectResult<spGetKhachHang_Result> spGetKhachHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetKhachHang_Result>("spGetKhachHang");
        }
    
        public virtual ObjectResult<spGetLoaiXe_Result> spGetLoaiXe()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetLoaiXe_Result>("spGetLoaiXe");
        }
    
        public virtual ObjectResult<spGetNgayKhoiHanhTheoIDTD_Result> spGetNgayKhoiHanhTheoIDTD(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetNgayKhoiHanhTheoIDTD_Result>("spGetNgayKhoiHanhTheoIDTD", idParameter);
        }
    
        public virtual ObjectResult<spGetTuyenDuong_Result> spGetTuyenDuong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetTuyenDuong_Result>("spGetTuyenDuong");
        }
    
        public virtual ObjectResult<spGetXe_Result> spGetXe()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetXe_Result>("spGetXe");
        }
    
        public virtual ObjectResult<spGetXeTheoIDBenXe_Result> spGetXeTheoIDBenXe(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetXeTheoIDBenXe_Result>("spGetXeTheoIDBenXe", idParameter);
        }
    
        public virtual int spSuaXe(Nullable<int> iDXe, string bienSo, Nullable<int> staTus)
        {
            var iDXeParameter = iDXe.HasValue ?
                new ObjectParameter("IDXe", iDXe) :
                new ObjectParameter("IDXe", typeof(int));
    
            var bienSoParameter = bienSo != null ?
                new ObjectParameter("BienSo", bienSo) :
                new ObjectParameter("BienSo", typeof(string));
    
            var staTusParameter = staTus.HasValue ?
                new ObjectParameter("staTus", staTus) :
                new ObjectParameter("staTus", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSuaXe", iDXeParameter, bienSoParameter, staTusParameter);
        }
    
        public virtual int spThemXe(string bienSo, string maLoai, string iDBen)
        {
            var bienSoParameter = bienSo != null ?
                new ObjectParameter("BienSo", bienSo) :
                new ObjectParameter("BienSo", typeof(string));
    
            var maLoaiParameter = maLoai != null ?
                new ObjectParameter("MaLoai", maLoai) :
                new ObjectParameter("MaLoai", typeof(string));
    
            var iDBenParameter = iDBen != null ?
                new ObjectParameter("IDBen", iDBen) :
                new ObjectParameter("IDBen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spThemXe", bienSoParameter, maLoaiParameter, iDBenParameter);
        }
    
        public virtual int spXoaXe(Nullable<int> iDXe)
        {
            var iDXeParameter = iDXe.HasValue ?
                new ObjectParameter("IDXe", iDXe) :
                new ObjectParameter("IDXe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spXoaXe", iDXeParameter);
        }
    
        public virtual ObjectResult<CHUYENXETHUCTE> sp_GetChuyenXeThucTeByIDTDuongNgayKhoiHanhGioKhoiHanh(Nullable<int> iDTuyenDuong, string ngayKhoiHanh, Nullable<int> sucChua, Nullable<int> soluong, Nullable<System.TimeSpan> gioKhoiHanh)
        {
            var iDTuyenDuongParameter = iDTuyenDuong.HasValue ?
                new ObjectParameter("IDTuyenDuong", iDTuyenDuong) :
                new ObjectParameter("IDTuyenDuong", typeof(int));
    
            var ngayKhoiHanhParameter = ngayKhoiHanh != null ?
                new ObjectParameter("NgayKhoiHanh", ngayKhoiHanh) :
                new ObjectParameter("NgayKhoiHanh", typeof(string));
    
            var sucChuaParameter = sucChua.HasValue ?
                new ObjectParameter("SucChua", sucChua) :
                new ObjectParameter("SucChua", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("Soluong", soluong) :
                new ObjectParameter("Soluong", typeof(int));
    
            var gioKhoiHanhParameter = gioKhoiHanh.HasValue ?
                new ObjectParameter("GioKhoiHanh", gioKhoiHanh) :
                new ObjectParameter("GioKhoiHanh", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CHUYENXETHUCTE>("sp_GetChuyenXeThucTeByIDTDuongNgayKhoiHanhGioKhoiHanh", iDTuyenDuongParameter, ngayKhoiHanhParameter, sucChuaParameter, soluongParameter, gioKhoiHanhParameter);
        }
    
        public virtual ObjectResult<CHUYENXETHUCTE> sp_GetChuyenXeThucTeByIDTDuongNgayKhoiHanhGioKhoiHanh(Nullable<int> iDTuyenDuong, string ngayKhoiHanh, Nullable<int> sucChua, Nullable<int> soluong, Nullable<System.TimeSpan> gioKhoiHanh, MergeOption mergeOption)
        {
            var iDTuyenDuongParameter = iDTuyenDuong.HasValue ?
                new ObjectParameter("IDTuyenDuong", iDTuyenDuong) :
                new ObjectParameter("IDTuyenDuong", typeof(int));
    
            var ngayKhoiHanhParameter = ngayKhoiHanh != null ?
                new ObjectParameter("NgayKhoiHanh", ngayKhoiHanh) :
                new ObjectParameter("NgayKhoiHanh", typeof(string));
    
            var sucChuaParameter = sucChua.HasValue ?
                new ObjectParameter("SucChua", sucChua) :
                new ObjectParameter("SucChua", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("Soluong", soluong) :
                new ObjectParameter("Soluong", typeof(int));
    
            var gioKhoiHanhParameter = gioKhoiHanh.HasValue ?
                new ObjectParameter("GioKhoiHanh", gioKhoiHanh) :
                new ObjectParameter("GioKhoiHanh", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CHUYENXETHUCTE>("sp_GetChuyenXeThucTeByIDTDuongNgayKhoiHanhGioKhoiHanh", mergeOption, iDTuyenDuongParameter, ngayKhoiHanhParameter, sucChuaParameter, soluongParameter, gioKhoiHanhParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_DatVe_KhachHang_Transaction(string tenKhachHang, string sDT, string cMND, string email, Nullable<int> idCXTT, Nullable<System.DateTime> ngayKhoiHanh, Nullable<System.DateTime> ngaydat, Nullable<int> maNV, Nullable<int> trangthaiDatVe)
        {
            var tenKhachHangParameter = tenKhachHang != null ?
                new ObjectParameter("TenKhachHang", tenKhachHang) :
                new ObjectParameter("TenKhachHang", typeof(string));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var cMNDParameter = cMND != null ?
                new ObjectParameter("CMND", cMND) :
                new ObjectParameter("CMND", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var idCXTTParameter = idCXTT.HasValue ?
                new ObjectParameter("IdCXTT", idCXTT) :
                new ObjectParameter("IdCXTT", typeof(int));
    
            var ngayKhoiHanhParameter = ngayKhoiHanh.HasValue ?
                new ObjectParameter("NgayKhoiHanh", ngayKhoiHanh) :
                new ObjectParameter("NgayKhoiHanh", typeof(System.DateTime));
    
            var ngaydatParameter = ngaydat.HasValue ?
                new ObjectParameter("Ngaydat", ngaydat) :
                new ObjectParameter("Ngaydat", typeof(System.DateTime));
    
            var maNVParameter = maNV.HasValue ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(int));
    
            var trangthaiDatVeParameter = trangthaiDatVe.HasValue ?
                new ObjectParameter("TrangthaiDatVe", trangthaiDatVe) :
                new ObjectParameter("TrangthaiDatVe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_DatVe_KhachHang_Transaction", tenKhachHangParameter, sDTParameter, cMNDParameter, emailParameter, idCXTTParameter, ngayKhoiHanhParameter, ngaydatParameter, maNVParameter, trangthaiDatVeParameter);
        }
    
        public virtual ObjectResult<sp_ThemCXTT_DatVe_KhachHang_Transaction_Result> sp_ThemCXTT_DatVe_KhachHang_Transaction(Nullable<int> iDTuyenDuong, Nullable<System.TimeSpan> gioKhoiHanh, Nullable<System.DateTime> ngayKhoiHanh, Nullable<int> idXe, Nullable<int> idTaixe1, Nullable<int> idTaixe2, Nullable<decimal> giaVe, Nullable<int> trangThaiCXTT, string tenKhachHang, string sDT, string cMND, string email, Nullable<System.DateTime> ngaydat, Nullable<int> maNV, Nullable<int> trangthaiDatVe)
        {
            var iDTuyenDuongParameter = iDTuyenDuong.HasValue ?
                new ObjectParameter("IDTuyenDuong", iDTuyenDuong) :
                new ObjectParameter("IDTuyenDuong", typeof(int));
    
            var gioKhoiHanhParameter = gioKhoiHanh.HasValue ?
                new ObjectParameter("GioKhoiHanh", gioKhoiHanh) :
                new ObjectParameter("GioKhoiHanh", typeof(System.TimeSpan));
    
            var ngayKhoiHanhParameter = ngayKhoiHanh.HasValue ?
                new ObjectParameter("NgayKhoiHanh", ngayKhoiHanh) :
                new ObjectParameter("NgayKhoiHanh", typeof(System.DateTime));
    
            var idXeParameter = idXe.HasValue ?
                new ObjectParameter("IdXe", idXe) :
                new ObjectParameter("IdXe", typeof(int));
    
            var idTaixe1Parameter = idTaixe1.HasValue ?
                new ObjectParameter("IdTaixe1", idTaixe1) :
                new ObjectParameter("IdTaixe1", typeof(int));
    
            var idTaixe2Parameter = idTaixe2.HasValue ?
                new ObjectParameter("IdTaixe2", idTaixe2) :
                new ObjectParameter("IdTaixe2", typeof(int));
    
            var giaVeParameter = giaVe.HasValue ?
                new ObjectParameter("GiaVe", giaVe) :
                new ObjectParameter("GiaVe", typeof(decimal));
    
            var trangThaiCXTTParameter = trangThaiCXTT.HasValue ?
                new ObjectParameter("TrangThaiCXTT", trangThaiCXTT) :
                new ObjectParameter("TrangThaiCXTT", typeof(int));
    
            var tenKhachHangParameter = tenKhachHang != null ?
                new ObjectParameter("TenKhachHang", tenKhachHang) :
                new ObjectParameter("TenKhachHang", typeof(string));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var cMNDParameter = cMND != null ?
                new ObjectParameter("CMND", cMND) :
                new ObjectParameter("CMND", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var ngaydatParameter = ngaydat.HasValue ?
                new ObjectParameter("Ngaydat", ngaydat) :
                new ObjectParameter("Ngaydat", typeof(System.DateTime));
    
            var maNVParameter = maNV.HasValue ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(int));
    
            var trangthaiDatVeParameter = trangthaiDatVe.HasValue ?
                new ObjectParameter("TrangthaiDatVe", trangthaiDatVe) :
                new ObjectParameter("TrangthaiDatVe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ThemCXTT_DatVe_KhachHang_Transaction_Result>("sp_ThemCXTT_DatVe_KhachHang_Transaction", iDTuyenDuongParameter, gioKhoiHanhParameter, ngayKhoiHanhParameter, idXeParameter, idTaixe1Parameter, idTaixe2Parameter, giaVeParameter, trangThaiCXTTParameter, tenKhachHangParameter, sDTParameter, cMNDParameter, emailParameter, ngaydatParameter, maNVParameter, trangthaiDatVeParameter);
        }
    
        public virtual ObjectResult<XE> sp_LayXeTrongTheoIDBen(string iDBEN)
        {
            var iDBENParameter = iDBEN != null ?
                new ObjectParameter("IDBEN", iDBEN) :
                new ObjectParameter("IDBEN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<XE>("sp_LayXeTrongTheoIDBen", iDBENParameter);
        }
    
        public virtual ObjectResult<XE> sp_LayXeTrongTheoIDBen(string iDBEN, MergeOption mergeOption)
        {
            var iDBENParameter = iDBEN != null ?
                new ObjectParameter("IDBEN", iDBEN) :
                new ObjectParameter("IDBEN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<XE>("sp_LayXeTrongTheoIDBen", mergeOption, iDBENParameter);
        }
    
        public virtual int sp_UpdateChuyenXeChuaPhanCong(Nullable<int> idxe, Nullable<int> idtaixe1, Nullable<int> idtaixe2, Nullable<int> idChuyenXe)
        {
            var idxeParameter = idxe.HasValue ?
                new ObjectParameter("idxe", idxe) :
                new ObjectParameter("idxe", typeof(int));
    
            var idtaixe1Parameter = idtaixe1.HasValue ?
                new ObjectParameter("idtaixe1", idtaixe1) :
                new ObjectParameter("idtaixe1", typeof(int));
    
            var idtaixe2Parameter = idtaixe2.HasValue ?
                new ObjectParameter("idtaixe2", idtaixe2) :
                new ObjectParameter("idtaixe2", typeof(int));
    
            var idChuyenXeParameter = idChuyenXe.HasValue ?
                new ObjectParameter("idChuyenXe", idChuyenXe) :
                new ObjectParameter("idChuyenXe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateChuyenXeChuaPhanCong", idxeParameter, idtaixe1Parameter, idtaixe2Parameter, idChuyenXeParameter);
        }
    
        public virtual ObjectResult<spGetBienSoTheoIDXe_Result> spGetBienSoTheoIDXe(Nullable<int> idXe)
        {
            var idXeParameter = idXe.HasValue ?
                new ObjectParameter("idXe", idXe) :
                new ObjectParameter("idXe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetBienSoTheoIDXe_Result>("spGetBienSoTheoIDXe", idXeParameter);
        }
    
        public virtual ObjectResult<spGetDiemKhoiHanhTheoIDTuyenDuong_Result> spGetDiemKhoiHanhTheoIDTuyenDuong(Nullable<int> iDTuyenDuong)
        {
            var iDTuyenDuongParameter = iDTuyenDuong.HasValue ?
                new ObjectParameter("IDTuyenDuong", iDTuyenDuong) :
                new ObjectParameter("IDTuyenDuong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetDiemKhoiHanhTheoIDTuyenDuong_Result>("spGetDiemKhoiHanhTheoIDTuyenDuong", iDTuyenDuongParameter);
        }
    
        public virtual ObjectResult<spGetGiaVeTheoIDXe_Result> spGetGiaVeTheoIDXe(Nullable<int> idXe)
        {
            var idXeParameter = idXe.HasValue ?
                new ObjectParameter("idXe", idXe) :
                new ObjectParameter("idXe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetGiaVeTheoIDXe_Result>("spGetGiaVeTheoIDXe", idXeParameter);
        }
    
        public virtual ObjectResult<spgetGioKHTheoNgayKH_Result> spgetGioKHTheoNgayKH(Nullable<System.DateTime> ngayKH)
        {
            var ngayKHParameter = ngayKH.HasValue ?
                new ObjectParameter("ngayKH", ngayKH) :
                new ObjectParameter("ngayKH", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spgetGioKHTheoNgayKH_Result>("spgetGioKHTheoNgayKH", ngayKHParameter);
        }
    
        public virtual ObjectResult<spGetIDChuyenTheoIDKH_Result> spGetIDChuyenTheoIDKH(Nullable<int> idKH)
        {
            var idKHParameter = idKH.HasValue ?
                new ObjectParameter("idKH", idKH) :
                new ObjectParameter("idKH", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetIDChuyenTheoIDKH_Result>("spGetIDChuyenTheoIDKH", idKHParameter);
        }
    
        public virtual ObjectResult<spGetIDTuyenDuongTheoNgayDi_Result> spGetIDTuyenDuongTheoNgayDi(Nullable<System.DateTime> ngayDi)
        {
            var ngayDiParameter = ngayDi.HasValue ?
                new ObjectParameter("NgayDi", ngayDi) :
                new ObjectParameter("NgayDi", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetIDTuyenDuongTheoNgayDi_Result>("spGetIDTuyenDuongTheoNgayDi", ngayDiParameter);
        }
    
        public virtual ObjectResult<spGetIDXeTheoIDTuyenDuong_Result> spGetIDXeTheoIDTuyenDuong(Nullable<int> idtd)
        {
            var idtdParameter = idtd.HasValue ?
                new ObjectParameter("idtd", idtd) :
                new ObjectParameter("idtd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetIDXeTheoIDTuyenDuong_Result>("spGetIDXeTheoIDTuyenDuong", idtdParameter);
        }
    
        public virtual ObjectResult<spGetNgayDiTheoIDChuyenIDHK_Result> spGetNgayDiTheoIDChuyenIDHK(Nullable<int> idChuyen, Nullable<int> idHK)
        {
            var idChuyenParameter = idChuyen.HasValue ?
                new ObjectParameter("idChuyen", idChuyen) :
                new ObjectParameter("idChuyen", typeof(int));
    
            var idHKParameter = idHK.HasValue ?
                new ObjectParameter("idHK", idHK) :
                new ObjectParameter("idHK", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetNgayDiTheoIDChuyenIDHK_Result>("spGetNgayDiTheoIDChuyenIDHK", idChuyenParameter, idHKParameter);
        }
    
        public virtual ObjectResult<spgetSoGheTheoIDDatVe_Result> spgetSoGheTheoIDDatVe(Nullable<int> idDV)
        {
            var idDVParameter = idDV.HasValue ?
                new ObjectParameter("idDV", idDV) :
                new ObjectParameter("idDV", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spgetSoGheTheoIDDatVe_Result>("spgetSoGheTheoIDDatVe", idDVParameter);
        }
    
        public virtual int sp_UpdateTrangThaiChuyenXeDaHoanThanh(Nullable<int> idChuyenXe)
        {
            var idChuyenXeParameter = idChuyenXe.HasValue ?
                new ObjectParameter("idChuyenXe", idChuyenXe) :
                new ObjectParameter("idChuyenXe", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateTrangThaiChuyenXeDaHoanThanh", idChuyenXeParameter);
        }
    
        public virtual ObjectResult<sp_GetTenBenCuaTuyenDuong_Result> sp_GetTenBenCuaTuyenDuong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetTenBenCuaTuyenDuong_Result>("sp_GetTenBenCuaTuyenDuong");
        }
    
        public virtual ObjectResult<sp_GetALLChuyenXeChuaPhanCong_Result> sp_GetALLChuyenXeChuaPhanCong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetALLChuyenXeChuaPhanCong_Result>("sp_GetALLChuyenXeChuaPhanCong");
        }
    
        public virtual ObjectResult<sp_GetAllChuyenXeDaPhanCong_Result> sp_GetAllChuyenXeDaPhanCong()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllChuyenXeDaPhanCong_Result>("sp_GetAllChuyenXeDaPhanCong");
        }
    }
}
