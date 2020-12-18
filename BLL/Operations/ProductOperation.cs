using AutoMapper;
using BLL.DTOs.Product;
using BLL.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Service.Interfaces;
using DAL.Entities;
using System.Linq;

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

        public IEnumerable<ProductDTO> GetAll()
        {
            var products = _uow.Product.FindAll();

            return _mapper.Map<IEnumerable<ProductDTO>>(products);

        }

        public  ProductDTO Get(int id)
        {
            var product = _uow.Product.Get(id);
            return _mapper.Map<ProductDTO>(product);
        }

        public IEnumerable<ProductDTO> GetByFilter(ProductDTO filter)
        {
            var products = _uow.Product.FindAll();

            if (filter.Id != 0)
                products = products.Where(x => x.Id == filter.Id);
            if (filter.Name != null)
                products = products.Where(x => x.Name.ToLower().Contains(filter.Name.ToLower()));
            if (filter.Manufacturer != null)
                products = products.Where(x => x.Manufacturer.ToLower().Contains(filter.Manufacturer.ToLower()));
            if (filter.Picture != null && filter.Picture != "All")
                products = products.Where(x => x.Picture == filter.Picture);

            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }
    }
}
