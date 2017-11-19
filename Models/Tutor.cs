using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPCAdministrator.Models
{
    public class Tutor
    {
        public int ID { get; set; }
        [Display(Name = "Nombre del tutor")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido del tutor")]
        public string Apellido { get; set; }
        [Display(Name = "Cedula del tutor")]
        public int Cedula { get; set; }
        public Pais Nacionalidad { get; set; }
        public long Telefono { get; set; }
        public long? TelefonoAlternativo { get; set; }

        public virtual Estudiante Estudiante { get; set; }
    }
}