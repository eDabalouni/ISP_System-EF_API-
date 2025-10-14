using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ISPSystem.Domain.Models

{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public bool IsDeleted { get; set; } = false;



        //One to Many Relationship between customer and Bill
        public List<Bill> Bills { get; set; }

        //One to Many Relationship between customer and Ticket
        public List<Ticket> Tickets { get; set; }


        //Many to Many Relationship between customer and servicePlan
        public List<ServicePlan> ServicePlans { get; set; }


        //One to Many Relationship between customer and Hardware
        public List<Hardware> Hardwares { get; set; }
    }
}
