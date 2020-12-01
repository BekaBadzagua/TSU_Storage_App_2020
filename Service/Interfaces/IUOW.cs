using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IUOW : IDisposable
    {
        IProductRepository Product { get; }
        IStoreInterface Store { get; }
        IStoreProductInterface StoreProduct { get; }

        void Commit();
    }
}
