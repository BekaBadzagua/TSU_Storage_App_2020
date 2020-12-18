using BLL.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageApp.Models
{
    public class ProductListVM
    {
        public IEnumerable<ProductDTO> Products { get; set; }

        public ProductDTO FormProduct { get; set; }
    }
}
