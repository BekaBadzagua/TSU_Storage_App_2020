using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTOs.Store;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using StorageApp.Models;

namespace StorageApp.Controllers
{
    public class StoreController : Controller
    {
        private readonly IStoreOperation _storeOperation;
        private readonly IProductOperation _productOperation;

        public StoreController(IStoreOperation storeOperation, IProductOperation productOperation)
        {
            _storeOperation = storeOperation;
            _productOperation = productOperation;
        }

        public IActionResult Index(StoreDTO filter)
        {
            var model = new StoreListVM()
            {
                Stores = _storeOperation.GetByFilter(filter)
            };

            return View(model);
        }

        public IActionResult Show(int id)
        {
            var model = new StoreVM()
            {
                Store = _storeOperation.Get(id),
                Products = _storeOperation.GetProducts(id)
            };


            ViewBag.fullProductList = _productOperation.GetAll();

            return View(model);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _storeOperation.Get(id);

            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(StoreDTO store)
        {
            if (!ModelState.IsValid)
            {
                return View(store);
            }

            _storeOperation.Edit(store);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Add(StoreListVM model)
        {
            if (!ModelState.IsValid)
            {
                model.Stores = _storeOperation.GetAll();
                return View("Index", model);
            }

            var store = model.FormStore;
            _storeOperation.Add(store);

            return RedirectToAction(nameof(Index));
        }

        public RedirectToActionResult Delete(int id)
        {
            _storeOperation.Delete(id);
            return RedirectToAction("Index", "Store");
        }

        [HttpPost]
        public IActionResult Attach(StoreVM model)
        {
            if (!ModelState.IsValid)
            {

                model.Store = _storeOperation.Get(model.FormAdd.StoreID);
                model.Products = _storeOperation.GetProducts(model.FormAdd.StoreID);
                ViewBag.fullProductList = _productOperation.GetAll();

                return View("Show", model);
            }

            var product = model.FormAdd;
            _storeOperation.AttachProduct(product);


            return RedirectToAction(nameof(Show), new { id = model.FormAdd.StoreID });
        }

        [Route("Store/Detach/{storeId}/{productId}")]
        public RedirectToActionResult Detach(int storeId, int productId)
        {
            _storeOperation.DetachProduct(productId);
            return RedirectToAction("Show", "Store", new { id = storeId });
        }
    }
}