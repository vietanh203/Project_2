//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DATVE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DATVE()
        {
            this.DATVE_SOGHE = new HashSet<DATVE_SOGHE>();
        }
    
        public int IDDatVe { get; set; }
        public Nullable<int> IDKhachhang { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> NgayDi { get; set; }
        public Nullable<int> IDChuyen { get; set; }
    
        public virtual CHUYENXETHUCTE CHUYENXETHUCTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DATVE_SOGHE> DATVE_SOGHE { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
