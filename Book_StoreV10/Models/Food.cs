using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoopApp.Models
{
    public class Food
    {

        public int VareNummer { get; set; }
        public string Navn { get; set; }
        public double Pris { get; set; }
        public string Producent { get; set; }
        public double SidsteSalgsDato { get; set; }
        public double Fedt { get; set; }
        public double Kulhydrat { get; set; }
        public double Protein { get; set; }
        public string ImageName { get; set; }
    }
}
