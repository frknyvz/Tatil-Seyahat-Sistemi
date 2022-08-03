using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelToLearn.Models.Siniflar
{
    public class Restoranlar
    {
        [Key]
        public int ID { get; set; }
        public string RestoranAdi { get; set; }
        public string RestoranBilgi { get; set; }
        public string RestoranImage { get; set; }
        public int SehirID { get; set; }
        public string SehirAdi { get; set; }
    }
}