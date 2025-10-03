using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSystem.Domain.Models
{
    public class ServicePlan
    {
        public int Id { get; set; }
        public int Speed { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public enum PlanStatus { Active, Inactive }
        public PlanStatus Status { get; set; }
        public bool IsDeleted { get; set; } = false;



        //Many to Many Relationship between servicePlan and customer
        public List<Customer> Customers { get; set; }
    }
}
