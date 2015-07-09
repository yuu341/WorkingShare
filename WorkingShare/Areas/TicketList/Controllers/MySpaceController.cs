using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkingShare.Areas.TicketList.Controllers
{
    public class MySpaceController : Controller
    {
        // GET: TicketList/MySpace
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}