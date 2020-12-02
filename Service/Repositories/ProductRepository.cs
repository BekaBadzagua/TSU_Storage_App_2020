using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(StoreDbContext context)
            :base(context)
        {

        }

        public IEnumerable<Product> GetAll()
        {
            // No Need for that
            //return Context.Products.Include(x => x.ProductStores);
            return Context.Products;
        }
    }
}
