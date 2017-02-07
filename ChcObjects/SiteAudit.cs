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
    public class SiteAudit : ISiteAudit
    {
        private readonly IChcDBEntities _context;
        [Key]
        [DataMember]
        public int SiteAuditID { get; set; }
        [DataMember]
        public System.DateTime EventDateTime { get; set; }
        [DataMember]
        public string Event { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int SiteID { get; set; }

        public SiteAudit()
        {
            _context = new ChcDBEntities();
        }

        public SiteAudit(IChcDBEntities context)
        {
            _context = context;
        }

        public SiteAudit(ISiteAudit siteAudit)
        {
            _context = new ChcDBEntities();

            this.Event = siteAudit.Event;
            this.EventDateTime = siteAudit.EventDateTime;
            this.SiteAuditID = siteAudit.SiteAuditID;
            this.SiteID = siteAudit.SiteID;
            this.UserID = siteAudit.UserID;
        }

        public SiteAudit(IChcDBEntities context, ISiteAudit siteAudit)
        {
            _context = context;

            this.Event = siteAudit.Event;
            this.EventDateTime = siteAudit.EventDateTime;
            this.SiteAuditID = siteAudit.SiteAuditID;
            this.SiteID = siteAudit.SiteID;
            this.UserID = siteAudit.UserID;
        }

        public SiteAudit(int id)
        {
            _context = new ChcDBEntities();

            var siteAudit = _context.tblSiteAudits.Find(id);

            this.Event = siteAudit.Event;
            this.EventDateTime = siteAudit.EventDateTime;
            this.SiteAuditID = siteAudit.SiteAuditID;
            this.SiteID = siteAudit.SiteID;
            this.UserID = siteAudit.UserID;
        }

        public IList<SiteAudit> GetSiteAuditBySite(Site site)
        {
            return _context.tblSites.Find(site.SiteID).tblSiteAudits.ToList().Select(s => new SiteAudit(s)).ToList();
        }

        public SiteAudit Audit(SiteAudit siteAudit)
        {
            var newAudit = new tblSiteAudit()
            {
                Event = siteAudit.Event,
                EventDateTime = siteAudit.EventDateTime,
                SiteAuditID = siteAudit.SiteAuditID,
                SiteID = siteAudit.SiteID,
                UserID = siteAudit.UserID
            };

            _context.tblSiteAudits.Add(newAudit);
            _context.SaveChanges();
            return new SiteAudit(newAudit);
        }

        public SiteAudit Audit()
        {
            var newAudit = new tblSiteAudit()
            {
                Event = this.Event,
                EventDateTime = this.EventDateTime,
                SiteAuditID = this.SiteAuditID,
                SiteID = this.SiteID,
                UserID = this.UserID
            };

            _context.tblSiteAudits.Add(newAudit);
            _context.SaveChanges();
            return new SiteAudit(newAudit);
        }
    }
}
