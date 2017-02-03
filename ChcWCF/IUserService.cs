﻿using ChcDB;
using ChcObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChcWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        IList<User> GetUserList();

        [OperationContract]
        User ValidateUserByUsernameAndPassword(IUser user);
    }
}