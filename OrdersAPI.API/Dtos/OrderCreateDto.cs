using OrdersAPI.DAL.Models;

namespace OrdersAPI.API.Dtos
{
    public class OrderCreateDto
    {
        public string Dimension { get; set; }
        public Location Pickup { get; set; }
        public Location DropOff { get; set; }
    }
}
