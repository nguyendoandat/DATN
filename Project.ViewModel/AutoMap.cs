using AutoMapper;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModel
{
    public class AutoMap : Profile
    {
        public AutoMap()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<AppUser,UserDTO>().ReverseMap();
            CreateMap<Medias, MediasDTO>().ReverseMap();
            CreateMap<Reviews,ReviewsDTO>().ReverseMap();
            CreateMap<Product,ProductDTO>().ReverseMap();
            CreateMap<Order,OrderDTO>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();
            CreateMap<Import, ImportDTO>().ReverseMap();
            CreateMap<ImportProduct, ImportProductDTO>().ReverseMap();
            CreateMap<Discount,DiscountDTO>().ReverseMap();
        }
    }
}
