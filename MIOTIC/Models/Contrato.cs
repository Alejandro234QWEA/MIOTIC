using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIOTIC.Models
{
    public class Contrato
    {
        [Key]
       
        public int Id { get; set; }
        [Required]
        public string? NombreProyecto { get; set; }
        public DateOnly Fecha { get; set; }
        public int Numero { get; set; }
        [Required]
        public int Mes { get; set; }
        [Required]
        public int Anio { get; set; }
        [Required]
        public  decimal Total { get; set; }

        //realciones
        public int ClienteId { get; set; }
        public virtual Cliente? Cliente { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario? Usuario { get; set; }

    }
}
