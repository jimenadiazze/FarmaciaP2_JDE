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
    public class IndexModel : PageModel
    {
        private readonly Farmacia.Models.FarmaciaContext _context;

        public IndexModel(Farmacia.Models.FarmaciaContext context)
        {
            _context = context;
        }

        public IList<Medicamento> Medicamento { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Medicamento = await _context.Medicamentos.ToListAsync();
        }
    }
}
