using System;

namespace WebApplication6.Models
{
    public class Slipper
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
        public string Brand { get; set; }
        public double CustomerReview { get; set; }  // half-rating scale of 1-5
    }
}
