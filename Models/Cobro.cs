using System;
using System.ComponentModel.DataAnnotations;

namespace MPCAdministrator.Models
{
    public class Cobro
    {
        public int ID { get; set; }
        public double Monto { get; set; }
        public int TutorID { get; set; }
        [Display(Name = "Fecha de cobro a tutor")]
        public DateTime Fecha_Cobro { get; set; }

        public virtual Tutor Tutor { get; set; }
    }
}