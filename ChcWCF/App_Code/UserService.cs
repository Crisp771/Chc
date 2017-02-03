using ChcObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
public class UserService : IUserService
{
    public IList<User> GetUserList()
    {
        return new User().GetUsers().ToList();
    }

    public User ValidateUserByUsernameAndPassword(LoginViewModel user)
    {
        var _user = new User(user);
        return _user.ValidateUserByUsernameAndPassword(_user);
    }
}
