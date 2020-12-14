using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoopApp.Models;
using CoopApp.Interfaces;

namespace CoopApp
{
    public class AdminAllFoodsModel : PageModel
    {
        [BindProperty]
        public Food Food { get; set; }
        private IFoodsRepository catalog;
        public AdminAllFoodsModel(IFoodsRepository repository)
        {
            catalog = repository;
        }
        public Dictionary<VareNummer, Food> Foods { get; set; }

        
        
        public IActionResult OnGet()
        {
            Foods = catalog.GetAllFoods();
            return Page();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                catalog.AddFood(Food);
                Foods = catalog.GetAllFoods();
            }
            return Page();
        }
    }
}