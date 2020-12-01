using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using StorageApp.Models;

namespace StorageApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUOW _uow;


        public HomeController(IUOW uOW)
        {
            _uow = uOW;
        } 


        public IActionResult Index()
        {
            // TESTS

            //var products = _uow.Product.FindAll();
            //var product = _uow.Product.Get(1);

            //var stores = _uow.Store.FindAll();
            //var store = _uow.Store.Get(1);

            //var storeProducts = _uow.StoreProduct.FindAll();
            //var storeProduct = _uow.StoreProduct.Get(1);


            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
