using AutoMapper;
using BLL.DTOs.Product;
using BLL.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Service.Interfaces;
using DAL.Entities;

namespace BLL.Operations
{
    public class ProductOperation : IProductOperation
    {
        private readonly IUOW _uow;
        private readonly IMapper  _mapper;

        public ProductOperation(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }


        public void Add(ProductDTO product)
        {
            _uow.Product.Create(_mapper.Map<Product>(product));
        }
        public void Edit(ProductDTO product)
        {
            _uow.Product.Update(_mapper.Map<Product>(product));
        }
        public void Delete(int id)
        {
            _uow.Product.Delete(id);
        }

        public IEnumerable<ProductListDTO> GetAll()
        {
            var products = _uow.Product.FindAll();

            return _mapper.Map<IEnumerable<ProductListDTO>>(products);

        }

        public  ProductDTO Get(int id)
        {
            var product = _uow.Product.Get(id);
            return _mapper.Map<ProductDTO>(product);
        }
    }
}
