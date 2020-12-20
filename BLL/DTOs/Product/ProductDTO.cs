using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using BLL.DTOs.Store;

namespace BLL.DTOs.Product
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Cannot be Empty")]
        [StringLength(maximumLength: 300, MinimumLength = 5, ErrorMessage = "Symbols should be less then 30 and more then 5.")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Manufacturer Cannot be Empty")]
        public string Manufacturer { get; set; }

        public string Picture { get; set; }
    }
}
