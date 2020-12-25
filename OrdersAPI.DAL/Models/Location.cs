using Microsoft.EntityFrameworkCore;

namespace OrdersAPI.DAL.Models
{
    [Owned]
    public class Location
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}
