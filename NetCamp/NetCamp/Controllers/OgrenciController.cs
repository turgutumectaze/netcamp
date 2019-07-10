using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCamp.Models.Entities;
using NetCamp.Models.Services;

namespace NetCamp.Controllers
{
    public class OgrenciController : Controller
    {
        OgrenciServisi servis;
        public OgrenciController(OgrenciServisi _servis)
        {
            servis = _servis;
        }
        public IActionResult List()
        {
            return View(servis.GetList());
        }
        public IActionResult Insert()
        {
            return View(new Ogrenci());
        }

        [HttpPost]
        public IActionResult Insert(Ogrenci model)
        {
            if (!ModelState.IsValid)
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        ViewBag.Error = error.ErrorMessage;
                    }
                }
                return View(model);
            } 
            else
            {
               servis.Insert(model);
               return RedirectToAction("List");
            }
           
        }

        //action üzerinde route tanımı yaparken aynı isme sahip diğer actionlarda etkinlenir
        //[Route("/ogrenci-guncelle/{ogrenciId}")]
        public IActionResult Update(long ogrenciId)
        {
            return View(servis.Get(ogrenciId));
        }
         
        [HttpPost]
        public IActionResult Update(Ogrenci model)
        {
            if (!ModelState.IsValid)
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        ViewBag.Error = error.ErrorMessage;
                    }
                }
                return View(model);
            }
            else
            {
                servis.Update(model);
                return RedirectToAction("List");
            }

        }
       // https://github.com/turgutumectaze/netcamp
    }
}