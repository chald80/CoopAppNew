using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Models
{
    public class Order : IComparable<Order>
    {
        public int PostNummer { get; set; }
        public int OrderID { get; set; }
        public string Levering { get; set; }
        public Kunde MedlemsID { get; set; }
        public string Navn { get; set; }
        public Kunde Adresse { get; set; }
        public Kunde PostNR { get; set; }
        public List<Food> Foods { get; set; }
        public List<Kunde> Kunde { get; set; }
        public DateTime DateTime { get; set; }
        public int CompareTo(Order obj)
        {
            return this.PostNummer.CompareTo(obj.PostNummer);
        }



    }




}
