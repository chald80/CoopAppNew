using CoopApp.Interfaces;
using CoopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Repositories
{
    public class JsonKundeRepository : IKunderRepository
    {
        string JsonFileName = @"C:\Users\Anders\OneDrive\Dokumenter\skole\Projekt\CoopAppDavid.AleksEdit.11-12-1455\CoopApp-master\Book_StoreV10\Data\JsonKunde.json";

        public List<Kunde> GetAllKunder()
        {
            return JsonFileReader.ReadJsonKunde(JsonFileName);
        }
        public void AddKunde(Kunde Kunde)
        {
            List<Kunde> Kunder = GetAllKunder().ToList();
            Kunder.Add(Kunde);
            JsonFileWritter.WriteToJsonKunde(Kunder, JsonFileName);
        }
        public Kunde GetKunde(int MedlemsID)
        {
            foreach (var b in GetAllKunder())
            {
                if (b.MedlemsID == MedlemsID)
                    return b;
            }
            return new Kunde();
        }
    }
}
