using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_System.Models
{
    public class Subscribing
    {
        public int Id { get; set; }
        public enum SubscribingStatus { Active, Stopped, Deleted }
        public SubscribingStatus Status { get; set; }

        public Customer Customer { get; set; }//Navigation Property

        //One to Many Relationship between customer and subscribing
        public int CustomerId { get; set; }

        public ServicePlan ServicePlan { get; set; }//Navigation Property

        //One to Many Relationship between servicePlan and subscribing
        public int ServicePlanId { get; set; }

    }
}
