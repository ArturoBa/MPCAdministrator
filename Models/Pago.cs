using System;
using System.ComponentModel.DataAnnotations;

namespace MPCAdministrator.Models
{
    public class Pago
    {
        public int ID { get; set; }
        public double Monto { get; set; }
        public int EmpleadoID { get; set; }
        public string Descripcion { get; set; }
        [Display(Name = "Fecha de pago")]
        public DateTime Fecha_Pago { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}