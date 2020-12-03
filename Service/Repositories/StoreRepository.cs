using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class StoreRepository : RepositoryBase<Store>, IStoreInterface
    {
        public StoreRepository(StoreDbContext context)
            : base(context)
        {

        }
    }
}
