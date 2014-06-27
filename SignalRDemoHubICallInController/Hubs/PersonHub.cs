using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRDemoHubICallInController.Hubs
{
    public class PersonHub : Hub
    {
        public void Update()
        {
            Clients.All.update();
        }
    }
}