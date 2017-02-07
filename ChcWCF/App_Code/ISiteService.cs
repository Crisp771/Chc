using ChcObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISiteService" in both code and config file together.
[ServiceContract]
public interface ISiteService
{
    [OperationContract]
    IList<SICLookup> GetSICLookups();
    [OperationContract]
    SICLookup GetSICById(int id);
    [OperationContract]
    IList<Site> GetSites();
    [OperationContract]
    Site GetSiteById(int id);
    [OperationContract]
    Site CreateSite(Site site);
    [OperationContract]
    Site UpdateSite(Site site);
}
