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
    
    public partial class tblSite
    {
        public int SiteID { get; set; }
        public string SiteName { get; set; }
        public string Address { get; set; }
        public int SICcode { get; set; }
        public string ContactDetails { get; set; }
        public string ActionDetails { get; set; }
    
        public virtual tblSICLookup tblSICLookup { get; set; }
    }
}
