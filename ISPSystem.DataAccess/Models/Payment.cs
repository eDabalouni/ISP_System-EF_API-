using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSystem.Domain.Models
{
    public class Payment
    {
        public int Id { get; set; }

        //One to one relationship between payment and bill
        public int BillId { get; set; }
    }
}
