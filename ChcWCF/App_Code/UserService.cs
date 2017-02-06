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

    public IList<Role> GetRoles()
    {
        var Role = new Role();
        return Role.GetRoles();
    }

    public User CreateUser(User user, int userid)
    {
        // We should be able to just do this, but for some reason the object doesn't instate correctly with the right context.
        // return user.CreateUser();
        var u = new User(user);
        return u.CreateUser(userid);
    }

    public User UpdateUser(User user, int userid)
    {
        //return user.UpdateUser();
        var u = new User(user);
        return u.UpdateUser(userid);
    }

    public IList<UserAudit> GetUserAudit(User user)
    {
        return new User(user).GetUserAudit();
    }

    public User GetUserByID(int id)
    {
        return new User(id);
    }
}
