using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Ticket
    {
        [Key]
        public int TicketID { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        //public Event Event { get; set; }
        //public int EventID { get; set; }
        public DateTime Date { get; set; }
    }
}
