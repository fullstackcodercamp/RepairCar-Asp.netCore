using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRepairShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRepairShop.Controllers
{
    public class StatusController : Controller
    {
        public StatusController(CarRepairDbContext database)
        {
            Database = database;
        }

        public CarRepairDbContext Database { get; }


        public IActionResult PendingOrders()
        {
            var orderStatus = Database.CustomerServices.Include(x => x.Customer).Where(x => x.Status == "InProgress").ToList();

            return View(orderStatus);
        }

        public IActionResult CompletedOrders()
        {
            var orderStatus = Database.CustomerServices.Include(x => x.Customer).Where(x => x.Status != "InProgress").ToList();

            return View(orderStatus);
        }


        public IActionResult CompleteOrder(Guid Id)
        {
            var order = Database.CustomerServices.FirstOrDefault(x => x.ServiceId == Id);
            if(order == null)
            {
                return NotFound("No Order Found");
            }
            return View(order);
        }

        [HttpPost]
        public IActionResult CompleteOrder(CustomerService customerService)
        {
            if (ModelState.IsValid)
            {
                if(customerService.TotalPaid < customerService.TotalCost)
                {
                    customerService.IsPaid = false;
                    customerService.Status = "InProgress";
                } else
                {
                    customerService.IsPaid = true;
                    customerService.Status = "Completed";
                }
                Database.CustomerServices.Update(customerService);
                Database.SaveChanges();
                return RedirectToAction("PendingOrders");
            }
            return View(customerService);
        }
    }
}