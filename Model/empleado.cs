using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp___Angular_2.Model
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Apellido { get; set; }

        [Range(0, 99)]
        public int Edad { get; set; }

        [Phone]
        public string? Telefono { get; set;}

        public string? Ruta { get; set; }
        public string? Camion { get; set; }
        public string? Direccion { get; set; }
    }
}
