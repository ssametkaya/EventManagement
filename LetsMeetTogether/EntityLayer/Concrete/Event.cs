using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime ClosedDate { get; set; }
        public int Capacity { get; set; }
        public City City { get; set; }
        public int CityID { get; set; }
        public ICollection<MyEvent> MyEvent { get; set; }
        public bool IsTicketed { get; set; }
    }
}
