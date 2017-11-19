using System;
using System.ComponentModel.DataAnnotations;

namespace MPCAdministrator.Models
{
    public class Cobro_Prestamo
    {
        public int ID { get; set; }
        [Display(Name = "ID del prestamo")]
        public int PrestamoID { get; set; }
        public int EmpleadoID { get; set; }
        public double Monto { get; set; }
        [Display(Name = "Fecha de cobro del prestamo")]
        public DateTime Fecha_Cobro_Prestamo { get; set; }

        public virtual Empleado Empleado { get; set; }
        public virtual Prestamo Prestamo { get; set; }
    }
}