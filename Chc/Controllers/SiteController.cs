using Chc.SiteService;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chc.Controllers
{
    public class SiteController : Controller
    {
        [Authorize]
        // GET: Site
        public ActionResult Index()
        {
            PopulateSICLookup();
            return View();
        }

        private void PopulateSICLookup()
        {
            var SICLookupData = new SiteServiceClient().GetSICLookups();
            ViewData["SICLookupData"] = SICLookupData;
            //new List<SiteService.SICLookup>();
        }

        public JsonResult CreateSite(Site site)
        {
            return Json(new SiteServiceClient().CreateSite(site), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetSites([DataSourceRequest] DataSourceRequest request)
        {
            var sites = new SiteServiceClient().GetSites();
            return Json(sites.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }
        public JsonResult UpdateSite(Site site)
        {
            return Json(new SiteServiceClient().UpdateSite(site), JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteSite(Site site)
        {
            site.Deleted = true;
            
            return Json(new SiteServiceClient().UpdateSite(site), JsonRequestBehavior.AllowGet);
        }
    }
}