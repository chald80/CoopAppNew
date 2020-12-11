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
        string JsonFileName = @"C:\Users\hald_\OneDrive\Dokumenter\skole\CoopAppAnders\CoopAppAnders\CoopApp-master\Book_StoreV10\Data\JsonFoodOrders.json";

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
            Dictionary<int, Food> pizzas = GetAllFoods();
            Food foundPizza = pizzas[VareNummer];
            return foundPizza;
        }

        public void DeleteFood(int VareNummer)
        {
            {
                Dictionary<int, Food> pizzas = GetAllFoods();
                pizzas.Remove(VareNummer);
                JsonFileWritter.WriteToJsonFood(pizzas, JsonFileName);

            }
        }

        public void UpdateFood(Food food)
        {
            Dictionary<int, Food> foods = GetAllFoods();
            Food foundFood = foods[food.VareNummer];
            foundFood.Navn = food.Navn;
            foundFood.VareNummer = food.VareNummer;
            foundFood.Pris = food.Pris;
            foundFood.Producent = food.Producent;
            foundFood.SidsteSalgsDato = food.SidsteSalgsDato;
            foundFood.Fedt = food.Fedt;
            foundFood.Kulhydrat = food.Kulhydrat;
            foundFood.Protein = food.Protein;
            foundFood.ImageName = food.ImageName;


            JsonFileWritter.WriteToJsonFood(foods, JsonFileName);
        }
    }
}
