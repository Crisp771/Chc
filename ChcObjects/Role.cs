using ChcDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChcObjects
{
    class Role : IRole
    {
        public int RoleID { get; set; }
        public string Rolename { get; set; }

        public Role()
        { }

        public Role(IRole role)
        {
            this.RoleID = role.RoleID;
            this.Rolename = role.Rolename;
        }
    }
}
