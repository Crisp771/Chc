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
        private readonly IChcDBEntities _context;
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
        [DataMember]
        public bool Deleted { get; set; }

        public Site()
        {
            _context = new ChcDBEntities();
        }

        public Site(IChcDBEntities context)
        {
            _context = context;
        }

        public Site(ISite site)
        {
            _context = new ChcDBEntities();

            this.ActionDetails = site.ActionDetails;
            this.Address = site.Address;
            this.ContactDetails = site.ContactDetails;
            this.SICcode = site.SICcode;
            this.SiteID = site.SiteID;
            this.SiteName = site.SiteName;
            this.Deleted = site.Deleted;
        }

        public Site(IChcDBEntities context, ISite site)
        {
            _context = context;

            this.ActionDetails = site.ActionDetails;
            this.Address = site.Address;
            this.ContactDetails = site.ContactDetails;
            this.SICcode = site.SICcode;
            this.SiteID = site.SiteID;
            this.SiteName = site.SiteName;
            this.Deleted = site.Deleted;
        }

        public Site(int id)
        {
            _context = new ChcDBEntities();

            var site = _context.tblSites.Find(id);

            this.ActionDetails = site.ActionDetails;
            this.Address = site.Address;
            this.ContactDetails = site.ContactDetails;
            this.SICcode = site.SICcode;
            this.SiteID = site.SiteID;
            this.SiteName = site.SiteName;
            this.Deleted = site.Deleted;
        }

        public IList<Site> GetSites()
        {
            return _context.tblSites.ToList().Select(s => new Site(s)).ToList();
        }

        public Site CreateSite(Site site, int userId)
        {
            var newsite = new tblSite()
            {
                ActionDetails = site.ActionDetails,
                Address = site.Address,
                ContactDetails = site.ContactDetails,
                SICcode = site.SICcode,
                SiteID = site.SiteID,
                SiteName = site.SiteName,
                Deleted = site.Deleted
            };
            _context.tblSites.Add(newsite);
            _context.SaveChanges();

            var audit = new SiteAudit()
            {
                Event = string.Format("Site {1} created with id {0}", newsite.SiteID, newsite.SiteName),
                EventDateTime = DateTime.Now,
                SiteID = newsite.SiteID,
                UserID = userId
            };

            audit.Audit();

            return new Site(newsite);
        }

        public Site UpdateSite(Site site, int userId)
        {
            var oldsite = _context.tblSites.Find(site.SiteID);

            oldsite.ActionDetails = site.ActionDetails;
            oldsite.Address = site.Address;
            oldsite.ContactDetails = site.ContactDetails;
            oldsite.SICcode = site.SICcode;
            oldsite.SiteID = site.SiteID;
            oldsite.SiteName = site.SiteName;
            oldsite.Deleted = site.Deleted;

            _context.SaveChanges();

            var audit = new SiteAudit()
            {
                Event = string.Format("Site {0} updated.", oldsite.SiteName),
                EventDateTime = DateTime.Now,
                SiteID = oldsite.SiteID,
                UserID = userId
            };

            audit.Audit();

            return new Site(oldsite);
        }
    }
}
