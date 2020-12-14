using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoopApp.Models;
using CoopApp.Repositories;
using CoopApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoopApp.Interfaces;

namespace CoopApp
{
    public class CheckOutModel : PageModel
    {
        private IKunderRepository repoK;
        private JsonOrderRepository repository;
        private ShoppingCartService cart;

        [BindProperty]
        public Kunde kunde { get; set; }
        public Order Order { get; set; }
        public List<Kunde> Kunder { get; set; }
       // public Kunde Kunde { get; set; }

        public CheckOutModel(JsonOrderRepository repo, ShoppingCartService cartService, IKunderRepository repoKunde)
        {
            repository = repo;
            cart = cartService;
            repoK = repoKunde;
        }
        public void OnGet()
        {
            Kunder = repoK.GetAllKunder();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Order order = new Order();
            //order.OrderID = 12;
            //order.MellemsID = Student;
            order.Foods = cart.GetOrderedFoods();
            order.DateTime = DateTime.Now;
            order.Kunde = cart.GetKundeOrder();
            

            repository.AddOrder(order);
            return RedirectToPage("Order", kunde);
        }
    }
}