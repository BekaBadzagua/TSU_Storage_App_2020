using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Store
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public string Type { get; set; }

        public ICollection<StoreProduct> StoreProducts { get; set; }

    }
}


