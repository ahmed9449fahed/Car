//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SellingCar_WPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TbSellingInfo
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> SellingDate { get; set; }
        public Nullable<double> SellingPrice { get; set; }
        public Nullable<double> Profit { get; set; }
        public Nullable<int> CarId { get; set; }
    
        public virtual TbCarsInfo TbCarsInfo { get; set; }
    }
}
