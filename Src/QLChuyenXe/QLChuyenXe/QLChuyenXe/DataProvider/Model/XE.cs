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
    
    public partial class XE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XE()
        {
            this.CHAYs = new HashSet<CHAY>();
            this.CHUYENXETHUCTEs = new HashSet<CHUYENXETHUCTE>();
        }
    
        public int IDXe { get; set; }
        public string BienSo { get; set; }
        public string MaLoai { get; set; }
        public string IDBen { get; set; }
        public string Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHAY> CHAYs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUYENXETHUCTE> CHUYENXETHUCTEs { get; set; }
        public virtual LOAIXE LOAIXE { get; set; }
    }
}
