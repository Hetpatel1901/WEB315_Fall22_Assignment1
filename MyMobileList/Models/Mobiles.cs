using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RazorPagesMobiles.Models
{
    public class Mobilephones
    {
        public int ID { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public DateTime Year { get; set; }

        public decimal Price { get; set; }

        public string Network { get; set; }

        public decimal Displaysize { get; set; }

        public int Users { get; set; }

        public string Color { get; set; }
         
    }
}