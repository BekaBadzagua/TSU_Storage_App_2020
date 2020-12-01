using DAL.Context;
using DAL.Entities;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class StoreProductRepository : RepositoryBase<StoreProduct>, IStoreProductInterface
    {
        public StoreProductRepository(StoreDbContext context)
            : base(context)
        {

        }
    }
}
