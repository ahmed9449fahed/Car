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
    
    public partial class TbCarsInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TbCarsInfo()
        {
            this.TbCarsFotoes = new HashSet<TbCarsFoto>();
            this.TbOwnersInfoes = new HashSet<TbOwnersInfo>();
            this.TbSellingInfoes = new HashSet<TbSellingInfo>();
        }
    
        public int Id { get; set; }
        public string Modell { get; set; }
        public string Status { get; set; }
        public Nullable<double> Price { get; set; }
        public string Adress { get; set; }
        public Nullable<System.DateTime> Insurance { get; set; }
        public Nullable<bool> Sold { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TbCarsFoto> TbCarsFotoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TbOwnersInfo> TbOwnersInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TbSellingInfo> TbSellingInfoes { get; set; }
    }
}
