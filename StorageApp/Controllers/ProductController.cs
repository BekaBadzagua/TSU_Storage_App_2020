using BLL.DTOs.Product;
using BLL.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorageApp.Helper;
using StorageApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductOperation _productOperation;
        private readonly IHostingEnvironment _env;

        public ProductController(IProductOperation productOperation, IHostingEnvironment env)
        {
            _productOperation = productOperation;
            _env = env;
        }

        public RedirectToActionResult Delete(int id)
        {
            string pictureName = _productOperation.Get(id).Picture;
            FileTools.DeleteFile(pictureName.Substring(1), _env);

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
        public IActionResult Edit(ProductDTO product, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            string pictureName = product.Picture;
            if (file != null && file.Length > 0)
            {
                FileTools.DeleteFile(pictureName.Substring(1), _env);
                pictureName = FileTools.UploadFile(file, _env);
            }
            product.Picture = pictureName;

            _productOperation.Edit(product);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _productOperation.Get(id);
            return View(model);

        }

        public RedirectToActionResult Add(ProductDTO product, IFormFile file)
        {
            product.Picture = FileTools.UploadFile(file, _env);
            _productOperation.Add(product);
            return RedirectToAction("Index", "Product");
        }

    }
}
