namespace EventManagementWeb.Models
{
    public class EventViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public int EventCapacity { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
    }
}
