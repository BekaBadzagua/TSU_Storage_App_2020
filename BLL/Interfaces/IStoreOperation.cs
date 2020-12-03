using BLL.DTOs.Store;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{

    public interface IStoreOperation
    {
        IEnumerable<StoreListDTO> GetAll();
        StoreListDTO Get(int id);
        void Add(StoreDTO store);
        void Edit(StoreDTO store);
        void Delete(int id);
    }
}
