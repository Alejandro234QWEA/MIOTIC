using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIOTIC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required,MinLength(6),MaxLength(10)]
        [Display(Name ="Nombre Completo")]
        public string? NombreCompleto { get; set; }
        public string? Ci { get; set; }
        public string? Celular { get; set; }
        public string? CorreoElectronico { get; set; }

        public string? Foto { get; set; }
        //manejo de Archivos
        [NotMapped]
        [Display(Name ="subir la foto")]
        public IFormFile? FotoFile  { get; set; }


        //Relcaiones 
        public virtual List<Contrato>? Contratos { get; set; }



    }
}
