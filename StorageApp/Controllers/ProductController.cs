using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using StorageApp.Models;
using BLL.DTOs.Product;
using DAL.Entities;

namespace StorageApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductOperation _productOperation;


        public ProductController(IProductOperation productOperation)
        {
            _productOperation = productOperation;
        }
        public RedirectToActionResult Delete(int id)
        {
            _productOperation.Delete(id);
            return RedirectToAction("Index", "Product");
        }

        public IActionResult Show(int id)
        {
            var model = new ProductVM()
            {
                Product = _productOperation.Get(id)
            };
            ViewBag.fullProductList = _productOperation.GetAll();
            return View(model);
        }


        public IActionResult Index(ProductDTO filter)
        {
            var model = new ProductListVM()
            {
                Products = _productOperation.GetByFilter(filter)
            };

            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(ProductDTO product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            _productOperation.Edit(product);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _productOperation.Get(id);
            return View(model);

        }

        public RedirectToActionResult Add(ProductDTO product)
        {
            _productOperation.Add(product);
            return RedirectToAction("Index", "Product");
        }

    }
}