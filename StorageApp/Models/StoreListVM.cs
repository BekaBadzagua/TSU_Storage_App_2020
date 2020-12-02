using BLL.DTOs.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageApp.Models
{
    public class StoreListVM
    {
        public IEnumerable<StoreListDTO> Stores { get; set; }
    }
}
