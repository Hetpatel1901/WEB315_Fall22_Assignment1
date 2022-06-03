using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMobiles.Models;

namespace MyMobileList.Pages_Mobiles
{
    public class CreateModel : PageModel
    {
        private readonly MyMobileListContext _context;

        public CreateModel(MyMobileListContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Mobilephones Mobilephones { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Mobilephones.Add(Mobilephones);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
