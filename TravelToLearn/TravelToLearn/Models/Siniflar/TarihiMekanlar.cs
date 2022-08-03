using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelToLearn.Models.Siniflar
{
    public class TarihiMekanlar
    {
        [Key]
        public int ID { get; set; }
        public string TMekanBaslik { get; set; }
        public string TMekanBilgi { get; set; }
        public string TMekanImage { get; set; }
        public int SehirID { get; set; }
        public string SehirAdi { get; set; }
    }
}