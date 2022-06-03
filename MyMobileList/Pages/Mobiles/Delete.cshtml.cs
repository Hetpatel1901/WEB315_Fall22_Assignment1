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
    public class DeleteModel : PageModel
    {
        private readonly MyMobileListContext _context;

        public DeleteModel(MyMobileListContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mobilephones = await _context.Mobilephones.FindAsync(id);

            if (Mobilephones != null)
            {
                _context.Mobilephones.Remove(Mobilephones);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
