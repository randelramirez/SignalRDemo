using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignalRDemoHubICallInController.Models
{
    public class MyDataContext :DbContext
    {

        public DbSet<Person> People { get; set; }
    }
}