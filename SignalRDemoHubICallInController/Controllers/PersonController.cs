using SignalRDemoHubICallInController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDemoHubICallInController.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/
        private MyDataContext context = new MyDataContext();
        public ActionResult Index()
        {
            var model = this.context.People;
            return View(model);
        }

    }
}
