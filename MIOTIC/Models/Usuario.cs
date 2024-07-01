using MIOTIC.Dtos;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace MIOTIC.Models
{
    public class Usuario
    {
        [Key]  //Annotations
        public int Id { get; set; }
        [Required, MinLength(5), MaxLength(50)]
        public string? CorreoElectronico { get; set; }
        [Required, MinLength(5) ,MaxLength(50)]
        public string? Password { get; set; }
        [Required,MinLength(3),MaxLength(30)]
        public string? NombreCompleto { get; set; }
        [Required]
        public RolEnum? Rol { get; set; }

        //un usuario registra muchos pagos
        // 1 ----- *
        //solo  para ver cambios
        public virtual List<Contrato>? Contratos { get; set; }
    }
}
