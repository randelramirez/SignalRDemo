using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDemoHubICallInController.Models
{
    public class Person
    {
        [HiddenInput]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }
    }
}