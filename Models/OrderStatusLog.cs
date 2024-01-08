namespace Hardware4You.Models
{
    public class OrderStatusLog
    {
        public int Id { get; set; }
        public string AdminUsername { get; set; }
        public long OrderId { get; set; }
        public string NewStatus { get; set; }
        public DateTime Timestamp { get; set; }
    }

}
