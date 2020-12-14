using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoopApp.Interfaces;
using CoopApp.Models;
using CoopApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoopApp
{
    public class OrderSortModel : PageModel
    {
        private JsonOrderRepository repoO;

        public OrderSortModel(JsonOrderRepository repoOrder)
        {
            repoO = repoOrder;
           
        }



        [BindProperty]
        public List<Order> Orders { get; private set; }
        public List<Order> OrderSort = new List<Order>();

       

        public IActionResult OnGet()
        {
            Orders = repoO.GetAllOrders();
            return Page();
        }

        public IActionResult OnPost()
        {

            Orders = repoO.GetAllOrders();
            return Page();
        }

    }

}