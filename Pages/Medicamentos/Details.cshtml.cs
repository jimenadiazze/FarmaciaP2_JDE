using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Farmacia.Models;

namespace Farmacia.Pages.Medicamentos
{
    public class DetailsModel : PageModel
    {
        private readonly Farmacia.Models.FarmaciaContext _context;

        public DetailsModel(Farmacia.Models.FarmaciaContext context)
        {
            _context = context;
        }

        public Medicamento Medicamento { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicamento = await _context.Medicamentos.FirstOrDefaultAsync(m => m.Id == id);
            if (medicamento == null)
            {
                return NotFound();
            }
            else
            {
                Medicamento = medicamento;
            }
            return Page();
        }
    }
}
