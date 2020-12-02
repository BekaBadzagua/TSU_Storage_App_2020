using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using StorageApp.Models;

namespace StorageApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductOperation _productOperation;
        private readonly IStoreOperation _storeOperation;


        public HomeController(IProductOperation productOperation, IStoreOperation storeOperation)
        {
            _productOperation = productOperation;
            _storeOperation = storeOperation;
        }




        public IActionResult Index()
        {

            //ProductListVM model = new ProductListVM()
            //{
            //    Products = _productOperation.GetAll()
            //};           
            StoreListVM model = new StoreListVM()
            {
                Stores = _storeOperation.GetAll()
            };


            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
