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
    }
}
