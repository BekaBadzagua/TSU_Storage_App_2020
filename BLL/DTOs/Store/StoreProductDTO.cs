using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTOs.Store
{
    public class StoreProductDTO
    {
        [Required(ErrorMessage ="StoreID is Required")]
        public int StoreID { get; set; }

        [Required(ErrorMessage = "ProductID is Required")]
        public int? ProductID { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter proper Price.")]
        public int? Price { get; set; }

        [Required(ErrorMessage = "BarCode is Required")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter proper BarCode.")]
        public int? BarCode { get; set; }
    }
}
