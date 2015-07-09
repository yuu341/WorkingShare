using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkingShare.Areas.TicketList.Controllers
{
    public class ListController : Controller
    {
        // GET: TicketList/List
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}