using System;

namespace CarSelling2.Classes
{
   public class CarsInfo
    {
        public string Modell { get; set; }
        public string Status { get; set; }
        public string Adress { get; set; }
        public DateTime Insurance { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }
        public byte[] DisplayFoto { get; set; }
        public bool Sold { get; set; }
    }
}
