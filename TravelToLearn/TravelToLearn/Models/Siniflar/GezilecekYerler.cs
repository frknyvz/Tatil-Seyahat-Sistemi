using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelToLearn.Models.Siniflar
{
    public class GezilecekYerler
    {
        [Key]
        public int ID { get; set; }
        public string MekanBaslik { get; set; }
        public string MekanBilgi { get; set; }
        public string MekanImage { get; set; }
        public int SehirID { get; set; }
        public string SehirAdi { get; set; }
    }
}