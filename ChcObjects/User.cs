using ChcDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChcObjects
{

    [DataContract(Namespace = "http://schemas.example.com")]
    public class User : IUser
    {
        private readonly IChcDBEntities _context;
        [Key]
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [DataMember]
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [DataMember]
        public int RoleID { get; set; }
        [DataMember]
        public bool Deleted { get; set; }

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
            return _context.tblUsers.Where(u => !u.Deleted).Select(s => new User(s)).ToList();
        }

        public User ValidateUserByUsernameAndPassword(IUser user)
        {
            var User = (_context.tblUsers.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password && !u.Deleted));
            if (User != null)
            {
                var retUser = new User(User);
                if (User != null)
                    return retUser;
            }
            return null;
        }

        public User ValidateUserByUsernameAndPassword()
        {
            var user = (_context.tblUsers.FirstOrDefault(u => u.Username == this.Username && u.Password == this.Password && !u.Deleted));
            var retUser = new User(user);
            if (user != null)
                return retUser;
            return null;
        }

        public User UpdateUser()
        {
            var user = (_context.tblUsers.Find(this.UserID));

            user.Username = this.Username;
            user.RoleID = this.RoleID;
            user.Password = this.Password;
            user.Deleted = this.Deleted;

            _context.SaveChanges();

            return new User(user);
        }

        public User CreateUser()
        {
            var t = new tblUser()
            {
                Deleted = this.Deleted,
                Password = this.Password,
                RoleID = this.RoleID,
                Username = this.Username
            };

            _context.tblUsers.Add(t);
            _context.SaveChanges();
            return new ChcObjects.User(t);
        }
    }
}
