//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Soccer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanVanDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanVanDong()
        {
            this.DoiBongs = new HashSet<DoiBong>();
            this.LichThiDaus = new HashSet<LichThiDau>();
            this.TranDaus = new HashSet<TranDau>();
        }
    
        public int MaSan { get; set; }
        public string TenSan { get; set; }
        public string ThanhPho { get; set; }
        public Nullable<int> SucChua { get; set; }
        public Nullable<int> NamXayDung { get; set; }
        public string DiaChi { get; set; }
        public string MoTa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoiBong> DoiBongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichThiDau> LichThiDaus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TranDau> TranDaus { get; set; }
    }
}
