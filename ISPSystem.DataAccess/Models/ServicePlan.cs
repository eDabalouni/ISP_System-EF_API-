using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_System.Models
{
    public class ServicePlan
    {
        public int Id { get; set; }
        public int Speed { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public enum PlanStatus { Active, Inactive }
        public PlanStatus Status { get; set; }

        public Customer Customer { get; set; }//Navigation Property

        //One to Many Relationship between customer and ServicePlan
        public int CustomerId { get; set; }

        //One to Many Relationship between servicePlan and subscribing
        public List<Subscribing> Subscribings { get; set; }
    }
}
