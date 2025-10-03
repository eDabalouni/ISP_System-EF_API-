using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSystem.Data.DTOs
{
    public class SubscribingDTO
    {
        public enum SubscribingStatus { Active, Stopped, Deleted }
        public SubscribingStatus Status { get; set; }
        public DateTime DeliveredAt { get; set; }
        public DateTime RetrievedAt { get; set; }
    }
}
