using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoopApp.Models
{
    public class Order
    {
        public int PostNummer { get; set; }
        public int OrderID { get; set; }          
        public Kunde MellemsID { get; set; }
        public Kunde Navn { get; set; }
        public Kunde Adresse { get; set; }
        public Kunde PostNR { get; set; }
        public List<Food> Foods { get; set; }
        public DateTime DateTime { get; set; }

        
    }




}
