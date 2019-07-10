using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NetCamp.Models.Entities;

namespace NetCamp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if ()
            {

            }
            base.OnActionExecuting(context);
        }
        public IActionResult Index()
        {
            return View(new Ogrenci());
        }

        [HttpPost]
        public IActionResult Index(Ogrenci model)
        {

            return View();
        }
        public IActionResult Erisilemez()
        {
            return View(new Ogrenci());
        }
    }
}