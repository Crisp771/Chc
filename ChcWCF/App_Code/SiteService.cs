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

    public Site CreateSite(Site site)
    {
        return new Site().CreateSite(site);
    }

    public Site UpdateSite(Site site)
    {
        return new Site().UpdateSite(site);
    }
}
