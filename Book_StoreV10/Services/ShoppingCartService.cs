using CoopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Services
{
    public class ShoppingCartService
    {
        List<Food>  _cartItems;
        List<Kunde> _KundeKort;
        public ShoppingCartService()
        {
            _cartItems = new List<Food>();
            _KundeKort = new List<Kunde>();
        }

       

        public void Add(Food food)
        {
            _cartItems.Add(food);
        }

        public void Add(Kunde kunde)
        {
            _KundeKort.Add(kunde);
        }

        public List<Food> GetOrderedFoods()
        {
            return _cartItems;
        }

        public List<Kunde> GetKundeOrder()
        {
            return _KundeKort;
        }

        public void RemoveFood(double VareNumer)
        {
            foreach (var food in _cartItems)
            {
                if (food.VareNummer == VareNumer)
                {
                    _cartItems.Remove(food);
                    break;
                }
            }
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0.00M;

            foreach (var v in _cartItems)
            {
                totalPrice = totalPrice + (decimal)v.Pris ;
            }
            return totalPrice;
        }
        
    }
}
