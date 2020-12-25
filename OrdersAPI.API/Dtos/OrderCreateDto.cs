using OrdersAPI.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace OrdersAPI.API.Dtos
{
    public class OrderCreateDto
    {
        [Required]
        public string Dimension { get; set; }
        [Required]
        public Location Pickup { get; set; }
        [Required]
        public Location DropOff { get; set; }
    }
}
