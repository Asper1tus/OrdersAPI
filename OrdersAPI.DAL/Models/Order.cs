using System.ComponentModel.DataAnnotations;

namespace OrdersAPI.DAL.Models
{
    public class Order
    {
        public string Id { get; set; }
        public string Dimension { get; set; }
        public Status Status { get; set; }
        public Location Pickup { get; set; }
        public Location DropOff { get; set; }

    }
}
