//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logic.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class WareHouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WareHouse()
        {
            this.MaterialExistances = new HashSet<MaterialExistance>();
            this.Orders = new HashSet<Order>();
        }
    
        public int WareHouseID { get; set; }
        public string Name { get; set; }
        public bool AllowSend { get; set; }
        public bool AllowReceive { get; set; }
        public Nullable<int> UserID { get; set; }
        public bool IsCountable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialExistance> MaterialExistances { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
