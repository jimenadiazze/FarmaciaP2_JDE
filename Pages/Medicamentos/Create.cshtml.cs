using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Farmacia.Models;

namespace Farmacia.Pages.Medicamentos
{
    public class CreateModel : PageModel
    {
        private readonly Farmacia.Models.FarmaciaContext _context;

        public CreateModel(Farmacia.Models.FarmaciaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Medicamento Medicamento { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Medicamentos.Add(Medicamento);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
