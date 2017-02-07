using ChcDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChcObjects
{
    public class Site : ISite
    {
        [Key]
        [DataMember]
        public int SiteID { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string SiteName { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(250)]
        public string Address { get; set; }
        [DataMember]
        public int SICcode { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(250)]
        public string ContactDetails { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(250)]
        public string ActionDetails { get; set; }
    }
}
