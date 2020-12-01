using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace StorageApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUOW _uow;


        public AuthController(IUOW uOW)
        {
            _uow = uOW;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}