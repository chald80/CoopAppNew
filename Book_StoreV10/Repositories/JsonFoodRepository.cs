using CoopApp.Interfaces;
using CoopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Repositories
{
    public class JsonFoodRepository:IFoodsRepository
    {
        string JsonFileName = @"C:\Users\Anders\OneDrive\Dokumenter\skole\Projekt\CoopAppDavid.AleksEdit.11-12-1455 - Kopi\CoopApp-master\Book_StoreV10\Data\JsonFoodsStore.json";

        public Dictionary<int, Food> GetAllFoods()
        {
            return JsonFileReader.ReadJsonFood(JsonFileName);
        }
        public void AddFood(Food Food)
        {
            Dictionary<int, Food> foods = GetAllFoods();
            foods.Add(Food.VareNummer, Food);
            JsonFileWritter.WriteToJsonFood(foods, JsonFileName);
        }
        public Food GetFood(int VareNummer)
        {
            Dictionary<int, Food> foods = GetAllFoods();
            Food foundFood = foods[VareNummer];
            return foundFood;
        }

        void IFoodsRepository.DeleteFood(int VareNummer)
        {
            throw new NotImplementedException();
        }

        void IFoodsRepository.UpdateFood(Food food)
        {
            throw new NotImplementedException();
        }
        /*
        public void UpdatePizza(Pizza pizza)
        {
            Dictionary<int, Pizza> pizzas = AllPizzas();
            Pizza foundPizza = pizzas[pizza.Id];
            foundPizza.Id = pizza.Id;
            foundPizza.Name = pizza.Name;
            foundPizza.Description = pizza.Description;
            foundPizza.Price = pizza.Price;
            foundPizza.ImageName = pizza.ImageName;
            JsonFileWritter.WriteToJson(pizzas, JsonFileName);
        }

        public void DeletePizza(int id)
        {
            Dictionary<int, Pizza> pizzas = AllPizzas();
            pizzas.Remove(id);
            JsonFileWritter.WriteToJson(pizzas, JsonFileName);
        }
        */





    }
}
