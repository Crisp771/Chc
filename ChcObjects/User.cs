﻿using ChcDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChcObjects
{
    [DataContract]
    public class User : IUser
    {
        private readonly IChcDBEntities _context;
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int RoleID { get; set; }

        public User()
        {
            _context = new ChcDBEntities();
        }

        public User(IChcDBEntities context)
        {
            _context = context;
        }

        public User(IUser user)
        {
            _context = new ChcDBEntities();

            this.Password = user.Password;
            this.RoleID = user.RoleID;
            this.UserID = user.UserID;
            this.Username = user.Username;
        }

        public User(IChcDBEntities context, IUser user)
        {
            _context = new ChcDBEntities();

            this.Password = user.Password;
            this.RoleID = user.RoleID;
            this.UserID = user.UserID;
            this.Username = user.Username;
        }
        public IList<User> GetUsers()
        {
            return _context.tblUsers.ToList().Select(s => new User(s)).ToList();
        }

        public User ValidateUserByUsernameAndPassword(IUser user)
        {
            var User = (_context.tblUsers.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password));
            var retUser = new User(User);
            if (User != null)
                return retUser;
            return null;
        }

        public User ValidateUserByUsernameAndPassword()
        {
            var User = (_context.tblUsers.FirstOrDefault(u => u.Username == this.Username && u.Password == this.Password));
            var retUser = new User(User);
            if (User != null)
                return retUser;
            return null;
        }
    }
}