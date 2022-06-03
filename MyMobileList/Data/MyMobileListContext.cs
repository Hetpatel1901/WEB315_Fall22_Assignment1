using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMobiles.Models;

    public class MyMobileListContext : DbContext
    {
        public MyMobileListContext (DbContextOptions<MyMobileListContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMobiles.Models.Mobilephones> Mobilephones { get; set; }
    }
