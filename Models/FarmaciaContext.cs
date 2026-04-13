using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Farmacia.Models
{
    public class FarmaciaContext : DbContext
    {
        public FarmaciaContext(DbContextOptions<FarmaciaContext> options) : base(options)
        {
        }

        // Esto creará la tabla de Medicamentos
        public DbSet<Medicamento> Medicamentos { get; set; }
    }
}