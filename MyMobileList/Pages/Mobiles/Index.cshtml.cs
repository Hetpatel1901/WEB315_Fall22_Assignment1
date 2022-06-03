using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMobiles.Models;

namespace MyMobileList.Pages_Mobiles
{
    public class IndexModel : PageModel
    {
        private readonly MyMobileListContext _context;

        public IndexModel(MyMobileListContext context)
        {
            _context = context;
        }

        public IList<Mobilephones> Mobilephones { get;set; }

        public async Task OnGetAsync()
        {
            Mobilephones = await _context.Mobilephones.ToListAsync();
        }
    }
}
