using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMobiles.Models
{
    public class Mobilephones
    {
        public int ID { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        [DataType(DataType.Date)]
        public DateTime Year { get; set; }

        public decimal Price { get; set; }

        public string Network { get; set; }

        public decimal Displaysize { get; set; }
    }
}