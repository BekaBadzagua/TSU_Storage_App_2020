using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using StorageApp.Models;

namespace StorageApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductOperation _productOperation;


        public ProductController(IProductOperation productOperation)
        {
            _productOperation = productOperation;
        }



        public IActionResult Index()
        {
            ProductListVM model = new ProductListVM()
            {
                Products = _productOperation.GetAll()
            };

            return View(model);
        }
    }
}