using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChcDB
{
    public interface ISiteAudit
    {
        int SiteAuditID { get; set; }
        System.DateTime EventDateTime { get; set; }
        string Event { get; set; }
        int UserID { get; set; }
        int SiteID { get; set; }
    }
}
