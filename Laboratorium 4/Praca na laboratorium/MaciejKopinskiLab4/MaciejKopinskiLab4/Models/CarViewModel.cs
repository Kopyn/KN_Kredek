using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab4.Models
{
    public class CarViewModel
    {

        public CarViewModel(string model, string manufacturer, decimal price, string photo)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Photo = photo;
        }

        public String Model
        {
            get;
            set;
        }

        public String Manufacturer { get; set; }

        public decimal Price { get; set; }

        public string Photo { get; set; }
    }
}
