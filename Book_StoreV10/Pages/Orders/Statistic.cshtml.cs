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
        private JsonOrderRepository repoO;
        private IKunderRepository repoK;

        public AllStatisticModel(JsonOrderRepository repoOrder, IKunderRepository repoKunder)
        {
            repoO = repoOrder;
            repoK = repoKunder;
        }

 

        [BindProperty]
        public List<Kunde> Kunder { get; private set; }

        public List<Order> Orders { get; private set; }
        public Kunde Kunde { get; private set; }
        public Order Order { get; private set; }
        public string FilterCriteria { get; set; }
       

        public IActionResult OnGet()
        {
            Orders = repoO.GetAllOrders();
            Kunder = repoK.GetAllKunder();
            return Page();
        }

        public IActionResult OnPost()
        {

            Orders = repoO.GetAllOrders();
            Kunder = repoK.GetAllKunder();
            return Page();
        }

    }

}

