using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkingShare.Areas.TicketList.Controllers
{
    public class TaskController : Controller
    {
        // GET: TicketList/Task
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}