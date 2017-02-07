using ChcObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SiteService" in code, svc and config file together.
public class SiteService : ISiteService
{
    public IList<SICLookup> GetSICLookups()
    {
        return new SICLookup().GetSICLookupList();
    }

    public SICLookup GetSICById(int id)
    {
        return new SICLookup(id);
    }

    public IList<Site> GetSites()
    {
        return new Site().GetSites();
    }

    public Site GetSiteById(int id)
    {
        return new Site(id);
    }

    public Site CreateSite(Site site, int userId)
    {
        return new Site().CreateSite(site, userId);
    }

    public Site UpdateSite(Site site, int userId)
    {
        return new Site().UpdateSite(site, userId);
    }

    public IList<SiteAudit> GetSiteAudit(Site site)
    {
        return new SiteAudit().GetSiteAuditBySite(site);
    }

    //public SiteAudit CreateSiteAudit(SiteAudit siteAudit)
    //{
    //    return new SiteAudit().Audit(siteAudit);
    //}
}
