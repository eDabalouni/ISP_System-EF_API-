using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_System.Models
{
    public class Hardware
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public DateTime DeliveredAt { get; set; }
        public DateTime RetrievedAt { get; set; }

        public Customer Customer { get; set; }//Navigation Property

        //One to Many Relationship between customer and Hardware
        public int CustomerId { get; set; }
    }
}
