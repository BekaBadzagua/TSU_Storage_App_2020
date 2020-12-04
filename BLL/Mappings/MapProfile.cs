using AutoMapper;
using BLL.DTOs.Product;
using BLL.DTOs.Store;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductListDTO>();
            CreateMap<Store, StoreDTO>();
            CreateMap<StoreDTO, Store>();
            CreateMap<StoreProduct, StoreProductListDTO>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name));
            CreateMap<StoreProductDTO, StoreProduct>();

        }
    }
}