using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSystem.Domain.Models
{
    //Breaking table between customer and servicePlan
    public class Subscribing
    {
        public int Id { get; set; }
        public enum SubscribingStatus { Active, Stopped, Deleted }
        public SubscribingStatus Status { get; set; }
        public DateTime DeliveredAt { get; set; }
        public DateTime RetrievedAt { get; set; }
        public bool IsDeleted { get; set; } = false;


    }
}
