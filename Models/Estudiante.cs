using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPCAdministrator.Models
{
    public enum Sexo
    {
        Masculino, Femenino
    }

    public enum Curso
    {
        Nido, Maternal, Kinder, Preprimario, Primero, Segundo, Tercero, Cuarto
    }

    public enum Pais
    {
        Dominicana, Haitiana, Estadounidense, Puertorriqueña, Cubana, Venezolana, Jamaiquina
    }

    public class Estudiante
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name = "Nombre del estudiante")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido del estudiante")]
        public string Apellido { get; set; }
        public Pais Nacionalidad { get; set; }
        [Display(Name = "Colegio anterior")]
        public string Colegio_Anterior { get; set; }
        [Key]
        [ForeignKey("Tutor")]
        [Display(Name = "Tutor")]
        public int TutorID { get; set; }
        public Sexo Sexo { get; set; }
        public Curso Curso { get; set; }

        public virtual Tutor Tutor { get; set; }
    }
}