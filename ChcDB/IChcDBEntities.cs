﻿using System.Data.Entity;

namespace ChcDB
{
    public interface IChcDBEntities
    {
        int SaveChanges();
        DbSet<tblRole> tblRoles { get; set; }
        DbSet<tblUser> tblUsers { get; set; }
        DbSet<tblUserAudit> tblUserAudits { get; set; }
        DbSet<tblSICLookup> tblSICLookups { get; set; }
        DbSet<tblSite> tblSites { get; set; }
    }
}