using BLL.DTOs.Product;
using BLL.DTOs.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageApp.Models
{
    public class StoreVM
    {
        public StoreDTO Store { get; set; }
        public IEnumerable<StoreProductListDTO> Products { get; set; }
        public StoreProductDTO FormAdd { get; set; }
    }
}
