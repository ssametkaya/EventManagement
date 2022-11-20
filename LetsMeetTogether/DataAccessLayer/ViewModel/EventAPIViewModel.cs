using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ViewModel
{
    public class EventAPIViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descprition { get; set; }
        public int Capacity { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public DateTime ClosedDate { get; set; }
    }
}
