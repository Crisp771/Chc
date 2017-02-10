using Chc.BookingService;
using Chc.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chc.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            PopulateLookups();
            return View();
        }

        public void PopulateLookups()
        {
            using (var bs = new BookingServiceClient())
            {
                ViewData["Carriers"] = bs.GetCarriers();
                ViewData["Containers"] = bs.GetContainers();
                ViewData["DisposalLocations"] = bs.GetDisposalLocations();
                ViewData["ScheduleFrequencies"] = bs.GetScheduleFrequncies();
            }

            ViewData["Sites"] = new SiteService.SiteServiceClient().GetSites();
        }

        public JsonResult CreateService(Service service)
        {
            return Json(new BookingServiceClient().CreateService(service, ((CustomPrincipal) User).Id), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetServices([DataSourceRequest] DataSourceRequest request)
        {
            var services = new BookingServiceClient().GetServices();
            return Json(services.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }
        public JsonResult UpdateService(Service service)
        {
            return Json(new BookingServiceClient().UpdateService(service, ((CustomPrincipal) User).Id), JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteService(Service service)
        {
            //service.Deleted = true;
            return Json(new BookingServiceClient().UpdateService(service, ((CustomPrincipal) User).Id), JsonRequestBehavior.AllowGet);
        }
    }
}