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
            this.Deleted = user.Deleted;
        }

        public User(IChcDBEntities context, IUser user)
        {
            _context = new ChcDBEntities();

            this.Password = user.Password;
            this.RoleID = user.RoleID;
            this.UserID = user.UserID;
            this.Username = user.Username;
            this.Deleted = user.Deleted;
        }
        public IList<User> GetUsers()
        {
            return _context.tblUsers.Where(u => !u.Deleted).ToList().Select(s => new User() { UserID = s.UserID, Username=s.Username, RoleID=s.RoleID, Deleted=s.Deleted, Password = string.Empty  }).ToList();
        }

        public IList<UserAudit> GetUserAudit()
        {
            return new UserAudit(_context).GetAuditsByUser(this);
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

            if (user.Username != this.Username)
            {
                user.Username = this.Username;
                //Audit This
            }

            if (user.RoleID != this.RoleID)
            {
                user.RoleID = this.RoleID;
            }

            if (!string.IsNullOrEmpty(this.Password))
            {
                var hash = System.Security.Cryptography.SHA1.Create();
                var encoder = new System.Text.ASCIIEncoding();
                var combined = encoder.GetBytes(this.Password ?? "");
                var hashvalue = BitConverter.ToString(hash.ComputeHash(combined)).ToLower().Replace("-", "");

                user.Password = hashvalue;
                //Audit password changed.
            }

            if (user.Deleted != this.Deleted)
            {
                user.Deleted = this.Deleted;
            }

            _context.SaveChanges();

            return new User(user);
        }

        public User CreateUser(int userid)
        {
            var hash = System.Security.Cryptography.SHA1.Create();
            var encoder = new System.Text.ASCIIEncoding();
            var combined = encoder.GetBytes(this.Password ?? "");
            var hashvalue = BitConverter.ToString(hash.ComputeHash(combined)).ToLower().Replace("-", "");

            var t = new tblUser()
            {
                Deleted = this.Deleted,
                Password = hashvalue,
                RoleID = this.RoleID,
                Username = this.Username
            };

            _context.tblUsers.Add(t);
            _context.SaveChanges();

            var audit = new UserAudit(_context);
            audit.CarriedOutByUserID = userid;
            audit.Event = "User Created.";
            audit.EventDateTime = DateTime.Now;
            audit.UserID = t.UserID;
            audit.Audit();

            return new ChcObjects.User(t);
        }


    }
}
