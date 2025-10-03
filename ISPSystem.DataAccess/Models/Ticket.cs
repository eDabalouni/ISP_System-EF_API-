using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_System.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public enum TicketStatus { New, UnderWorking, Closed }
        public TicketStatus Status { get; set; }

        public Customer Customer { get; set; }//Navigation Property

        //One to Many Relationship between customer and Ticket
        public int CustomerId { get; set; }
    }
}
