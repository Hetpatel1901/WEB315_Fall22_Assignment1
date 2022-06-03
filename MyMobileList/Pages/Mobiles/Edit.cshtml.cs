using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMobiles.Models;

namespace MyMobileList.Pages_Mobiles
{
    public class EditModel : PageModel
    {
        private readonly MyMobileListContext _context;

        public EditModel(MyMobileListContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Mobilephones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MobilephonesExists(Mobilephones.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MobilephonesExists(int id)
        {
            return _context.Mobilephones.Any(e => e.ID == id);
        }
    }
}
