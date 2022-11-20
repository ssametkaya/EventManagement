using EntityLayer.Concrete;

namespace EventManagementWeb.Models
{
    public class EventPostViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime ClosedDate { get; set; }
        public int Capacity { get; set; }
        public string CityName { get; set; }
        public bool BiletliMi { get; set; }
    }
}
