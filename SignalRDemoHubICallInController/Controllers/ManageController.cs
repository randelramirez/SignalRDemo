using Microsoft.AspNet.SignalR;
using SignalRDemoHubICallInController.Hubs;
using SignalRDemoHubICallInController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDemoHubICallInController.Controllers
{
    public class ManageController : Controller
    {
        //
        // GET: /Manage/
        private MyDataContext context = new MyDataContext();
        public ActionResult Index()
        {
            var model = this.context.People;
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var person = this.context.People.Find(id);
            return View(person);
        }

        [HttpPost]
        public ActionResult Edit(Person p)
        {
            if (ModelState.IsValid)
            {
                //var person = this.context.People.Find(p.ID);
                this.context.People.Attach(p);
                this.context.Entry(p).State = System.Data.Entity.EntityState.Modified;
                this.context.SaveChanges();
                var hubContext = GlobalHost.ConnectionManager.GetHubContext<PersonHub>();
                hubContext.Clients.All.updatePerson(p.ID, p.Name, p.Alias);
                return RedirectToAction("Index");
            }

            return View(p);
        }

    }
}
