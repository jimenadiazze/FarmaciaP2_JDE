using System.ComponentModel.DataAnnotations;

namespace Farmacia.Models
{
    public class Medicamento
    {
        [Key]
        public int Id { get; set; } // 1. Identificador único

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty; // 2. Nombre del fármaco

        [Required]
        public string Laboratorio { get; set; } = string.Empty; // 3. Empresa fabricante

        [Range(0.01, 10000)]
        public decimal Precio { get; set; } // 4. Precio de venta

        public int Stock { get; set; } // 5. Cantidad disponible

        public string Categoria { get; set; } = "General"; // 6. Analgésico, Vitamina, etc.

        [DataType(DataType.Date)]
        public DateTime FechaCaducidad { get; set; } // 7. Fecha de vencimiento
    }
}