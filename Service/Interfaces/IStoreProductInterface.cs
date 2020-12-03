using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Service.Interfaces
{
    public interface IStoreProductInterface : IRepositoryBase<StoreProduct>
    {
        IEnumerable<StoreProduct> FindByCondition_IncludeProduct(Expression<Func<StoreProduct, bool>> expression);
    }
}
