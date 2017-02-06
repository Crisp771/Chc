using ChcDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChcObjects
{
    public class Role : IRole
    {
        private readonly IChcDBEntities _context;

        public int RoleID { get; set; }
        public string Rolename { get; set; }

        public Role()
        {
            _context = new ChcDBEntities();
        }

        public Role(IRole role)
        {
            _context = new ChcDBEntities();
            this.RoleID = role.RoleID;
            this.Rolename = role.Rolename;
        }

        public Role(IChcDBEntities context)
        {
            _context = context;
        }

        public Role(IChcDBEntities context, IRole role)
        {
            _context = context;
            this.RoleID = role.RoleID;
            this.Rolename = role.Rolename;
        }

        public IList<Role> GetRoles()
        {
            var roles = _context.tblRoles.ToList().Select(s => new Role(s)).ToList();
            return roles;
        }
    }
}
