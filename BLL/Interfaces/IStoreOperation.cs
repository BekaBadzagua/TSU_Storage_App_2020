using BLL.DTOs.Store;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{

    public interface IStoreOperation
    {
        IEnumerable<StoreDTO> GetAll();
        IEnumerable<StoreDTO> GetByFilter(StoreDTO filter);
        StoreDTO Get(int id);
        void Add(StoreDTO store);
        void Edit(StoreDTO store);
        void Delete(int id);
        IEnumerable<StoreProductListDTO> GetProducts(int storeId);
        void AttachProduct(StoreProductDTO product);
        void DetachProduct(int id);
    }
}
