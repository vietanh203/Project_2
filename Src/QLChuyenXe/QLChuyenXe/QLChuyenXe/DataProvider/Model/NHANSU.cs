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
    
    public partial class NHANSU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANSU()
        {
            this.SODIENTHOAIs = new HashSet<SODIENTHOAI>();
        }
    
        public int IDNhanVien { get; set; }
        public string HoTen { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string Cmnd { get; set; }
        public string QueQuan { get; set; }
        public Nullable<int> IDTuyenDuong { get; set; }
        public byte[] image { get; set; }
        public Nullable<int> loainv { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual TUYENDUONG TUYENDUONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SODIENTHOAI> SODIENTHOAIs { get; set; }
    }
}
