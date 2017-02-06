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
    public class UserAudit : IUserAudit
    {
        private readonly IChcDBEntities _context;
        [Key]
        [DataMember]
        public int UserAuditID { get; set; }
        [DataMember]
        [DataType(DataType.DateTime)]
        public System.DateTime EventDateTime { get; set; }
        [DataMember]
        [DataType(DataType.Text)]
        [StringLength(250)]
        public string Event { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int CarriedOutByUserID { get; set; }

        public UserAudit()
        {
            _context = new ChcDBEntities();
        }

        public UserAudit(IChcDBEntities context)
        {
            _context = context;
        }
        public UserAudit(IUserAudit userAudit)
        {
            _context = new ChcDBEntities();
            this.CarriedOutByUserID = userAudit.CarriedOutByUserID;
            this.Event = userAudit.Event;
            this.EventDateTime = userAudit.EventDateTime;
            this.UserAuditID = userAudit.UserAuditID;
            this.UserID = userAudit.UserID;
        }

        public UserAudit(IChcDBEntities context, IUserAudit userAudit)
        {
            _context = context;
            this.CarriedOutByUserID = userAudit.CarriedOutByUserID;
            this.Event = userAudit.Event;
            this.EventDateTime = userAudit.EventDateTime;
            this.UserAuditID = userAudit.UserAuditID;
            this.UserID = userAudit.UserID;
        }

        public UserAudit Audit()
        {
            var t = new tblUserAudit();

            t.UserID = this.UserID;
            t.UserAuditID = this.UserAuditID;
            t.EventDateTime = this.EventDateTime;
            t.Event = this.Event;
            t.CarriedOutByUserID = this.CarriedOutByUserID;

            _context.tblUserAudits.Add(t);

            _context.SaveChanges();
            return this;
        }

        public IList<UserAudit> GetAuditsByUser(User user)
        {
            return _context.tblUserAudits.Where(t => t.UserID == user.UserID).Select(s => new UserAudit(s)).ToList();
        }
    }
}
