using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTOs.Store
{
    public class StoreDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Cannot be Empty")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Number of Symbols should be less then 50 and more then 3.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address Cannot be Empty")]
        [StringLength(maximumLength: 500, MinimumLength = 3, ErrorMessage = "Number of Symbols should be less then 50 and more then 3.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Type Cannot be Empty")]
        public string Type { get; set; }
    }
}
