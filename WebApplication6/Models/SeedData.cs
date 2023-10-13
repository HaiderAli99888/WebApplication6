using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WebApplication6.Data;
using WebApplication6.Models;

namespace WebApplication6.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>());

            // Check if any slippers exist, if they do, the DB has been seeded.
            if (context.Slippers.Any())
            {
                return;   // Database has been seeded.
            }

            context.Slippers.AddRange(
                new Slipper
                {
                    Name = "Classic Comfort",
                    Description = "Soft and cozy classic design.",
                    Price = 29.99,
                    ImageUrl = "/wwwroot/images/1.jpg",
                    Material = "Wool",
                    CustomerReview = 4.5
                },
                new Slipper
                {
                    Name = "Modern Elegance",
                    Description = "Elegant design with memory foam.",
                    Price = 34.99,
                    ImageUrl = "/wwwroot/images/2.jpg",
                    Material = "Cotton",
                    CustomerReview = 4.2
                },
                new Slipper
                {
                    Name = "Summer Breeze",
                    Description = "Lightweight slippers for the summer.",
                    Price = 24.99,
                    ImageUrl = "/wwwroot/images/1.jpg",
                    Material = "Linen",
                    CustomerReview = 4.3
                },
                new Slipper
                {
                    Name = "Night Owl",
                    Description = "Dark-colored slippers for night comfort.",
                    Price = 27.99,
                    ImageUrl = "/wwwroot/images/3.jpg",
                    Material = "Velvet",
                    CustomerReview = 4.0
                },
                new Slipper
                {
                    Name = "Mountain Trekker",
                    Description = "Rugged slippers designed for a cabin feel.",
                    Price = 32.99,
                    ImageUrl = "/wwwroot/images/4.jpg",
                    Material = "Leather",
                    CustomerReview = 4.1
                },
new Slipper
{
    Name = "Beach Wanderer",
    Description = "Breathable slippers perfect for a beach house.",
    Price = 22.99,
    ImageUrl = "/wwwroot/images/5.jpg",
    Material = "Canvas",
    CustomerReview = 3.9
},
new Slipper
{
    Name = "Urban Chic",
    Description = "Stylish slippers for the modern city dweller.",
    Price = 35.99,
    ImageUrl = "/wwwroot/images/6.jpg",
    Material = "Silk",
    CustomerReview = 4.7
},
new Slipper
{
    Name = "Winter Warmth",
    Description = "Insulated slippers for cold winter nights.",
    Price = 38.99,
    ImageUrl = "/wwwroot/images/6.jpg",
    Material = "Fur",
    CustomerReview = 4.8
},
new Slipper
{
    Name = "Rainforest Dream",
    Description = "Eco-friendly slippers with a hint of the wild.",
    Price = 31.99,
    ImageUrl = "/wwwroot/images/7.jpg",
    Material = "Organic Cotton",
    CustomerReview = 4.4
},
new Slipper
{
    Name = "Desert Mirage",
    Description = "Slippers designed for airy comfort in dry climates.",
    Price = 28.99,
    ImageUrl = "/wwwroot/images/8.jpg",
    Material = "Linen",
    CustomerReview = 4.2
},
new Slipper
{
    Name = "Mirage",
    Description = "Slippers designed for comfort in humid climates.",
    Price = 28.99,
    ImageUrl = "/wwwroot/images/8.jpg",
    Material = "Linen",
    CustomerReview = 4.2
},
new Slipper
{
    Name = "Desert",
    Description = "Slippers designed for running in dry climates.",
    Price = 28.99,
    ImageUrl = "/wwwroot/images/8.jpg",
    Material = "Linen",
    CustomerReview = 4.2
}


            );

            context.SaveChanges();
        }
    }
}

