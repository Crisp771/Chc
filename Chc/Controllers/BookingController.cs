using ChcObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chc.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            PopulateLookups();
            return View();
        }

        public void PopulateLookups()
        {
            ViewData["SiteLookupData"] = new SiteService.SiteServiceClient().GetSites();
            ViewData["ServiceLookupData"] = new BookingService.BookingServiceClient().GetServices();
        }

        //public Booking GetBooking()
        //{

        //}
    }
}