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
    
    public partial class tblEWC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEWC()
        {
            this.tblServices = new HashSet<tblService>();
        }
    
        public int Chapter { get; set; }
        public int SubChapter { get; set; }
        public int WasteType { get; set; }
        public string Description { get; set; }
        public bool IsHazardous { get; set; }
        public string EWCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblService> tblServices { get; set; }
    }
}