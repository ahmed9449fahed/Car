//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarSelling2.DatenBank
{
    using System;
    using System.Collections.Generic;
    
    public partial class TbOwnersInfo
    {
        public int Id { get; set; }
        public Nullable<int> CarId { get; set; }
        public string Vorname { get; set; }
        public string nachname { get; set; }
        public byte[] TelephoneNumber { get; set; }
        public string EmailAdress { get; set; }
    
        public virtual TbCarsInfo TbCarsInfo { get; set; }
    }
}
