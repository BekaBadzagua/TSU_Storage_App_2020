using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Store
{
    public class StoreProductListDTO
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int Price { get; set; }
        public int BarCode { get; set; }
    }
}
