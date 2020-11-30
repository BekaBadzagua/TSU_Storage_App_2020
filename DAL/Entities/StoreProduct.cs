using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class StoreProduct
    {
        public int Id { get; set; }
        public int StoreID { get; set; }
        public int ProductID { get; set; }

        public Store Store { get; set; }
        public Product Product { get; set; }

        public int Price { get; set; }
        public int BarCode { get; set; }
    }
}
