using System.Data.Entity;

namespace ChcDB
{
    public interface IChcDBEntities
    {
        DbSet<tblRole> tblRoles { get; set; }
        DbSet<tblUser> tblUsers { get; set; }
    }
}