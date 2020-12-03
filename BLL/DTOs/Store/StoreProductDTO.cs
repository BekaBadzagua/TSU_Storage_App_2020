using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Store
{
    public class StoreProductDTO
    {
        public int StoreID { get; set; }
        public int ProductID { get; set; }
        public int Price { get; set; }
        public int BarCode { get; set; }
    }
}
