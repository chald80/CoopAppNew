using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoopApp.Interfaces;
using CoopApp.Models;
using CoopApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoopApp.Repositories;
using CoopApp;
using System;
namespace CoopApp
{
    public class AllStatisticModel : PageModel
    {
        /* private IOrderRepository catalog;

         public AllStatisticModel(IOrderRepository repository)
         {
             catalog = repository;
         }
         public List<Order> Orders { get; private set; }

         [BindProperty]
         public Order Order { get; set; }
         public IActionResult OnGet()
         {
             Orders = catalog.GetAllOrders();
             return Page();
         }
         public IActionResult OnPost()
         {
             if (ModelState.IsValid)
             {
                 catalog.AddOrder(Order);
                 Orders = catalog.GetAllOrders();
             }
             return Page();
         }
        */

        private JsonOrderRepository repoO;
        private IKunderRepository repoK;

        public AllStatisticModel (JsonOrderRepository repoOrder, IKunderRepository repoKunde)
        {
            repoO = repoOrder;
            repoK = repoKunde;
        }

        [BindProperty]
        public List<Kunde> Kunder { get; private set; }

        public List<Order> Orders { get; private set; }

        private IOrderRepository catalog;

        public Kunde Kunde { get; private set; }
        public Order Order { get; private set; }

        public string FilterCriteria { get; set; }

        public IActionResult OnGet()
        {
            Orders = repoO.GetAllOrders();
            Kunder = repoK.GetAllKunder();

            Orders = catalog.GetAllOrders();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Orders = catalog.FilterOrder(FilterCriteria);
            }

            return Page();

        }




    public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                repoO.AddOrder(Order);
                Orders = repoO.GetAllOrders();

                repoK.AddKunde(Kunde);
                Kunder = repoK.GetAllKunder();
            }
            return Page();
        }



        /*public IActionResult OnGet()
        {
            Pizzas = catalog.AllPizzas();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Pizzas = catalog.FilterPizza(FilterCriteria);
            }

            return Page();
        }
        */

    }
}
