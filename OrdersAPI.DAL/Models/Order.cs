namespace OrdersAPI.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Dimension { get; set; }
        public Status Status { get; set; }
        public Location Pickup { get; set; }
        public Location DropOff { get; set; }

    }
}
