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
    
    public partial class Account
    {
        public int IDNhanVien { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool privilege { get; set; }
    
        public virtual NHANSU NHANSU { get; set; }
    }
}
