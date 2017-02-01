using ChcDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChcObjects
{
    class User : IUser
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }

        public User()
        {
        }

        public User(IUser user)
        {
            this.Password = user.Password;
            this.RoleID = user.RoleID;
            this.UserID = user.UserID;
            this.Username = user.Username;
        }
    }
}
