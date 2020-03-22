using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRepairShop.Models;
using CarRepairShop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CarRepairShop.Controllers
{
    public class OrdersController : Controller
    {
        public OrdersController(CarRepairDbContext database)
        {
            Database = database;
        }

        public CarRepairDbContext Database { get; }


        public IActionResult NewOrder(Guid Id)
        {
            var service = Database.Services.Find(Id);
            if(service == null)
            {
                return NotFound("Service Not Offered");
            }
            var customerOrder = new CustomerOrder()
            {
                ServiceId = Id,
                Service =service,
                Customer = new Customer()
            };

            return View(customerOrder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewOrder(CustomerOrder customerOrder)
        {
            if (ModelState.IsValid)
            {

                Database.Customers.Add(customerOrder.Customer);
                Database.SaveChanges();
                var service = Database.Services.Find(customerOrder.ServiceId);
                var customerId = Database.Customers.FirstOrDefault(x => x.FirstName == customerOrder.Customer.FirstName && x.Email == customerOrder.Customer.Email).CustomerId;
                var newOrder = new CustomerService()
                {
                    TotalCost = service.Cost,
                    TotalPaid = 0,
                    Discount = 0,
                    Status = "InProgress",
                    IsPaid = false,
                    ServiceId = service.ServiceId,
                    CustomerId = customerId

                };
                Database.CustomerServices.Add(newOrder);
                Database.SaveChanges();

                return RedirectToAction("Index", "Home");
                
            }

            return View(customerOrder);
        }
    }
}