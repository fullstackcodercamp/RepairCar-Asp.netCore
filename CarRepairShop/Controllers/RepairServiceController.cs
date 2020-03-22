using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CarRepairShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRepairShop.Controllers
{
    public class RepairServiceController : Controller
    {
        public RepairServiceController(CarRepairDbContext  database)
        {
            Database = database;
        }

        public CarRepairDbContext Database { get; }

        public IActionResult Index()
        {
            var service = Database.Services.Include(x => x.ServiceOrders).ToList();
            return View(service);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service newService, IFormFile ServiceImage)
        {
            if (ModelState.IsValid)
            {
                if (ServiceImage != null)
                {
                    using (var imageBytes = new MemoryStream())
                    {
                        ServiceImage.CopyTo(imageBytes);

                        newService.ServiceImage = imageBytes.ToArray();

                    }
                }
                Database.Services.Add(newService);
                Database.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(newService);
        }



        [HttpGet]
        public IActionResult EditService(Guid Id)
        {
            var service = Database.Services.FirstOrDefault(x => x.ServiceId == Id);
            return View(service);
        }

        [HttpPost]
        public IActionResult EditService(Service editedService, IFormFile ServiceImage)
        {
            if (ModelState.IsValid)
            {
                if (ServiceImage != null)
                {
                    using (var imageBytes = new MemoryStream())
                    {
                        ServiceImage.CopyTo(imageBytes);

                        editedService.ServiceImage = imageBytes.ToArray();

                    }
                }
                Database.Services.Update(editedService);
                Database.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(editedService);
        }


        [HttpGet]
        public IActionResult DeleteService(Guid Id)
        {
            var service = Database.Services.FirstOrDefault(x => x.ServiceId == Id);
            if(service != null)
            {
                Database.Services.Remove(service);
                Database.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}