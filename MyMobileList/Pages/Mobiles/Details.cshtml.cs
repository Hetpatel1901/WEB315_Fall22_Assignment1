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
    public class DetailsModel : PageModel
    {
        private readonly MyMobileListContext _context;

        public DetailsModel(MyMobileListContext context)
        {
            _context = context;
        }

        public Mobilephones Mobilephones { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mobilephones = await _context.Mobilephones.FirstOrDefaultAsync(m => m.ID == id);

            if (Mobilephones == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
