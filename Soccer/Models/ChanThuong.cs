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
    
    public partial class ChanThuong
    {
        public int MaChanThuong { get; set; }
        public Nullable<int> MaCauThu { get; set; }
        public string LoaiChanThuong { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public string MoTa { get; set; }
    
        public virtual CauThu CauThu { get; set; }
    }
}
