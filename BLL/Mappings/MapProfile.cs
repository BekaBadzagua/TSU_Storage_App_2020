using AutoMapper;
using BLL.DTOs.Product;
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
        }
    }
}