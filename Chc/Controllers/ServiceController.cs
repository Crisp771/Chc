using Chc.BookingService;
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
            return View();
        }

        public void PopulateLookups()
        {
            using (var bs = new BookingServiceClient())
            {
                ViewData["Carriers"] = bs.GetCarriers();
            }
        }
    }
}