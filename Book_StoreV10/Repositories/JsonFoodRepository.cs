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

        public void DeleteFood(int VareNummer)
        {
            Dictionary<int, Food> foods = GetAllFoods();
            foods.Remove(VareNummer);
            JsonFileWritter.WriteToJsonFood(foods, JsonFileName);
        }

        public void UpdateFood(Food food)
        {
            Dictionary<int, Food> foods = GetAllFoods();
            Food foundFood = foods[food.VareNummer];
            foundFood.VareNummer = food.VareNummer;
            foundFood.Navn = food.Navn;
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
