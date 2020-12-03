using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Service.Repositories
{
    public class StoreProductRepository : RepositoryBase<StoreProduct>, IStoreProductInterface
    {
        public StoreProductRepository(StoreDbContext context)
            : base(context)
        {
        }

        public IEnumerable<StoreProduct> FindByCondition_IncludeProduct(Expression<Func<StoreProduct, bool>> expression)
        {
            return Context.Set<StoreProduct>().Include(x => x.Product).Where(expression);
        }
    }
}
