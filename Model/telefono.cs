using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Asp___Angular_2.Model
{
    public class Num_telefono
    {
        [Key]
        public int TelefonoId { get; set; }

        [Required]
        public string? Telefono_celular { get; set; }

        public string? Descripcion { get; set; }
        public bool Activo { get; set; }


    }
}
