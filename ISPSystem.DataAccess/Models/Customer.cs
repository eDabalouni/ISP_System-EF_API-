using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_System.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //One to Many Relationship between customer and Bill
        public List<Bill> Bills { get; set; }

        //One to Many Relationship between customer and Ticket
        public List<Ticket> Tickets { get; set; }

        //One to Many Relationship between customer and Subscribing
        public List<Subscribing> Subscribings { get; set; }

        //One to Many Relationship between customer and Hardware
        public List<Hardware> Hardwares { get; set; }
    }
}
