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

        public StoreController(IStoreOperation storeOperation)
        {
            _storeOperation = storeOperation;
        }

        [HttpGet]
        public IActionResult Index()
        {
            StoreListVM model = new StoreListVM()
            {
                Stores= _storeOperation.GetAll()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            StoreVM model = new StoreVM()
            {
                Store = _storeOperation.Get(id)
            };

            return View(model);
        }
        [HttpPost]
        public RedirectToActionResult Add(StoreDTO store)
        {
            _storeOperation.Add(store);
            return RedirectToAction("Index", "Store");
        }
        [HttpPost]
        public RedirectToActionResult Edit(StoreDTO store)
        {
            _storeOperation.Edit(store);
            return RedirectToAction("Index", "Store");
        }     
        
        public RedirectToActionResult Delete(int id)
        {
            _storeOperation.Delete(id);
            return RedirectToAction("Index", "Store");
        }

    }
}