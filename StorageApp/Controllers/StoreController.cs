using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using StorageApp.Models;

namespace StorageApp.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreOperation _storeOperation;

        

        public StoreController(IStoreOperation storeOperation)
        {
            _storeOperation = storeOperation;
        }

        public IActionResult Index()
        {
            StoreListVM model = new StoreListVM()
            {
                Stores= _storeOperation.GetAll()
            };

            return View(model);
        }
    }
}