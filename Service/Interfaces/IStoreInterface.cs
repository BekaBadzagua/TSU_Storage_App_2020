using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IStoreInterface : IRepositoryBase<Store>
    {
        IEnumerable<Store> GetAll();
    }
}
