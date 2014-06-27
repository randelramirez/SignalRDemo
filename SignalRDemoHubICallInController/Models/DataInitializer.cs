using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SignalRDemoHubICallInController.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<MyDataContext>
    {
        protected override void Seed(MyDataContext context)
        {
            var people = new List<Person>
            {
                new Person { Name = "Randel Ramirez", Alias = "Randel"},
                new Person { Name = "Kobe Bryant", Alias = "Black Mamba"},
                new Person { Name = "LeBron James", Alias = "King James"}
            };

            people.ForEach(p => context.People.Add(p));
            context.SaveChanges();
        }
    }
}