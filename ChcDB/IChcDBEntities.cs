using System.Data.Entity;

namespace ChcDB
{
    public interface IChcDBEntities
    {
        Database Database { get; }
        int SaveChanges();
        DbSet<tblRole> tblRoles { get; set; }
        DbSet<tblUser> tblUsers { get; set; }
        DbSet<tblUserAudit> tblUserAudits { get; set; }
        DbSet<tblSICLookup> tblSICLookups { get; set; }
        DbSet<tblSite> tblSites { get; set; }
        DbSet<tblSiteAudit> tblSiteAudits { get; set; }
        DbSet<tblCarrier> tblCarriers { get; set; }
        DbSet<tblContainer> tblContainers { get; set; }
        DbSet<tblDisposalLocation> tblDisposalLocations { get; set; }
        DbSet<tblScheduleFrequency> tblScheduleFrequencies { get; set; }
        DbSet<tblService> tblServices { get; set; }
        DbSet<tblEWC> tblEWCs { get; set; }
        DbSet<tblContractNumber> tblContractNumbers { get; set; }
        DbSet<tblBooking> tblBookings { get; set; }
    }
}