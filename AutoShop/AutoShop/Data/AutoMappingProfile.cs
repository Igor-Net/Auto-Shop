using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoShop.Data.Entities;
using AutoShop.ViewModels;

namespace AutoShop.Data
{
  public class AutoMappingProfile : Profile
  {
    public AutoMappingProfile()
    {
      CreateMap<Order, OrderViewModel>()
        .ForMember(o => o.OrderId, ex => ex.MapFrom(o => o.Id))
        .ReverseMap();

      CreateMap<OrderItem, OrderItemViewModel>()
        .ReverseMap();
    }
  }
}
