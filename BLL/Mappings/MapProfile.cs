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
            CreateMap<Product, ProductDTO>();
            CreateMap<Store, StoreDTO>();
            CreateMap<Product, ProductListDTO>();
            CreateMap<StoreDTO, Store>();
            CreateMap<ProductDTO, Product>();
            CreateMap<StoreProduct, StoreProductListDTO>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name));
            CreateMap<StoreProductDTO, StoreProduct>();

        }
    }
}