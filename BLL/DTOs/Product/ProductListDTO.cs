using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using BLL.DTOs.Store;

namespace BLL.DTOs.Product
{
    public class ProductListDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Manufacturer is Required")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Picture is Required")]
        public string Picture { get; set; }
        public IEnumerable<StoreDTO> Stores { get; set; }
        public IEnumerable<ProductDTO> Products { get; set; }
        public object FormProduct { get; set; }//                           წაშაშლელია
    }
}
