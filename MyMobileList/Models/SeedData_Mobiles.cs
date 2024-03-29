using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using MyMobileList.Data;
using System;
using System.Linq;
using RazorPagesMobiles.Models;

namespace MyMobileList.Models
{
    public static class SeedData

    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
             using (var context = new MyMobileListContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyMobileListContext>>()))

                    {
                        // Look for any mobiles.
                        if (context.Mobilephones.Any())

                        {
                            return;   // DB has been seeded
                        }
                         context.Mobilephones.AddRange(

                        new Mobilephones
                    {
                        Brand = "Apple",
                        Model= "iPhone 12",
                        Year = DateTime.Parse("2020-10-23"),
                        Price = 800,
                        Network= "5G",
                        Displaysize= 6.10M
                    },

                     new Mobilephones
                    {
                        Brand = "Samsung",
                        Model= "S22",
                        Year = DateTime.Parse("2022-02-24"),
                        Price = 1500,
                        Network= "5G",
                        Displaysize= 6.50M
                    },

                     new Mobilephones
                    {
                        Brand = "Nokia",
                        Model= "Nokia 3310",
                        Year = DateTime.Parse("2000-09-01"),
                        Price = 55,
                        Network= "3G",
                        Displaysize= 1.50M
                    },

                     new Mobilephones
                    {
                        Brand = "Oneplus",
                        Model= "Oneplus 9",
                        Year = DateTime.Parse("2021-03-23"),
                        Price = 1070,
                        Network= "5G",
                        Displaysize= 6.55M
                    },

                     new Mobilephones
                    {
                        Brand = "LG",
                        Model= "LG Wing",
                        Year = DateTime.Parse("2020-10-25"),
                        Price = 1295,
                        Network= "5G",
                        Displaysize= 6.80M
                    },

                     new Mobilephones
                    {
                        Brand = "ASUS",
                        Model= "ROG phone 5",
                        Year = DateTime.Parse("2021-04-26"),
                        Price = 730,
                        Network= "5G",
                        Displaysize= 6.78M
                    }

                    );
                    context.SaveChanges();
            }
        }
    }
}
