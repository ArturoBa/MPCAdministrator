using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPCAdministrator.Models
{
    public class Prestamo
    {
        public int ID { get; set; }
        public int EmpleadoID { get; set; }
        public double Monto { get; set; }
        [Display(Name = "Fecha del prestamo")]
        public DateTime Fecha_Prestamo { get; set; }
        public string Descripcion { get; set; }

        public virtual Empleado Empleado { get; set; }
        public virtual ICollection<Cobro_Prestamo> Cobro_Prestamo { get; set; }
    }
}