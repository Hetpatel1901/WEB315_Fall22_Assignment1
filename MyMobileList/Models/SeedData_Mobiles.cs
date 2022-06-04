using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyMobileList.Data;
using System;
using System.Linq;

namespace RazorPagesMobiles.Models
{
    public static class SeedData

    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
             using (var context = new RazorPagesMobilesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMobilesContext>>()))

                    {
                        // Look for any mobiles.
                        if (context.Mobiles.Any())

                        {
                            return;   // DB has been seeded
                        }
                         context.Mobiles.AddRange(

                        new Mobiles
                    {
                        Brand = "Apple",
                        Model= "iPhone 12",
                        Year = DateTime.Parse("2020-10-23"),
                        Price = 800,
                        Network= "5G",
                        Displaysize= 6.10
                    },

                     new Mobiles
                    {
                        Brand = "Samsung",
                        Model= "S22",
                        Year = DateTime.Parse("2022-02-24"),
                        Price = 1500,
                        Network= "5G",
                        Displaysize= 6.50
                    },

                     new Mobiles
                    {
                        Brand = "Nokia",
                        Model= "Nokia 3310",
                        Year = DateTime.Parse("2000-09-01"),
                        Price = 55,
                        Network= "3G",
                        Displaysize= 1.50
                    },

                     new Mobiles
                    {
                        Brand = "Oneplus",
                        Model= "Oneplus 9",
                        Year = DateTime.Parse("2021-03-23"),
                        Price = 1070,
                        Network= "5G",
                        Displaysize= 6.55
                    },

                     new Mobiles
                    {
                        Brand = "LG",
                        Model= "LG Wing",
                        Year = DateTime.Parse("2020-10-25"),
                        Price = 1295,
                        Network= "5G",
                        Displaysize= 6.80
                    },

                     new Mobiles
                    {
                        Brand = "ASUS",
                        Model= "ROG phone 5",
                        Year = DateTime.Parse("2021-04-26"),
                        Price = 730,
                        Network= "5G",
                        Displaysize= 6.78
                    }

                    );
                    context.SaveChanges();
            }
        }
    }
}
