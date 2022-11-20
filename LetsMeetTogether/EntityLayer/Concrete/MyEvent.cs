using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MyEvent
    {
        [Key]
        public int MyEventID { get; set; }
        public string MyEventName { get; set; }
        public int EventID { get; set; }
        public ICollection<Event> Event { get; set; }
        public string AppEmail { get; set; }
        //public AppUser AppUser { get; set; }
    }
}
