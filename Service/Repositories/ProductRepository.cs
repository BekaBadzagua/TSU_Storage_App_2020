using DAL.Context;
using DAL.Entities;
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
    }
}
