using AutoMapper;
using OrdersAPI.API.Dtos;
using OrdersAPI.DAL.Models;

namespace OrdersAPI.API.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderCreateDto, Order>();
        }
    }
}
