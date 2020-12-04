using BLL.DTOs.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StorageApp.Models
{
    public class StoreListVM
    {
        public IEnumerable<StoreDTO> Stores { get; set; }

        public StoreDTO FormStore { get; set; }
        //[Required(ErrorMessage = "Name Cannot be Empty")]
        //[StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Number of Symbols should be less then 50.")]
        //public string Name { get; set; }

        //[Required(ErrorMessage = "Address Cannot be Empty")]
        //[StringLength(maximumLength: 500, MinimumLength = 3, ErrorMessage = "Number of Symbols should be less then 50.")]
        //public string Address { get; set; }

        //[Required(ErrorMessage = "Type Cannot be Empty")]
        //public string Type { get; set; }

    }
}
