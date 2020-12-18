using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTOs.Store;
using BLL.DTOs.Product;



namespace StorageApp.Models
{
    public class ProductVM
    {
        public ProductDTO Product { get; set; }
        public IEnumerable<StoreProductListDTO> Products { get; set; }
        public StoreProductDTO FormAdd { get; set; }
    }
}
