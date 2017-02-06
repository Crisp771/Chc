using ChcObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
[ServiceContract]
public interface IUserService
{
    [OperationContract]
    IList<User> GetUserList();

    [OperationContract]
    User ValidateUserByUsernameAndPassword(LoginViewModel user);
    [OperationContract]
    IList<Role> GetRoles();

    [OperationContract]
    User CreateUser(User user);

    [OperationContract]
    User UpdateUser(User user);
}
