//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChcDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCarrier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCarrier()
        {
            this.tblServices = new HashSet<tblService>();
        }
    
        public int CarrierID { get; set; }
        public string CarrierName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string Postcode { get; set; }
        public string WasteCarriersLicence { get; set; }
        public System.DateTime ExpiryDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblService> tblServices { get; set; }
    }
}
