using System.ComponentModel.DataAnnotations;

namespace IDGS902_Api.Models
{
    public class alumnos
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Correo { get; set;}
    }
}
