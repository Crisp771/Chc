using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chc.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Schedule
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetSheduledEvents()
        {
            return Json(new BookingService.BookingServiceClient().GetScheduledEvents(), JsonRequestBehavior.AllowGet);
        }
    }
}