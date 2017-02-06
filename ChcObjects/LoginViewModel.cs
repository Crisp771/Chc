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
    [DataContract]
    public class LoginViewModel : IUser
    {
        [Key]
        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [DataMember]
        public int RoleID { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [DataMember]
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataMember]
        [Display(Name = "Deleted")]
        public bool Deleted { get; set; }

        [DataMember]
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
