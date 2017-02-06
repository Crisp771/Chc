using Chc.UserService;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chc.Controllers
{
    public class UserManagementController : Controller
    {
        // GET: UserManagement
        public ActionResult Index()
        {
            PopulateRoleLookup();
            return View();
        }

        private void PopulateRoleLookup()
        {
            var roles = new UserServiceClient().GetRoles();
            ViewData["RoleLookup"] = roles;
        }

        public JsonResult GetUsers([DataSourceRequest] DataSourceRequest request)
        {
            return Json(new UserServiceClient().GetUserList().ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult CreateUser(User user)
        {
            return Json(new UserServiceClient().CreateUser(user), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateUser(User user)
        {
            return Json(new UserServiceClient().UpdateUser(user), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteUser(User user)
        {
            user.Deleted = true;
            return this.UpdateUser(user);
        }
    }
}