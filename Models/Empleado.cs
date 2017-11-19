using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPCAdministrator.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        [Display(Name = "Nombre del empleado")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido del empleado")]
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public Pais Nacionalidad { get; set; }
        public long Telefono { get; set; }
        [Display(Name = "Fecha de contratacion")]
        public DateTime FechaContratacion { get; set; }

        public virtual ICollection<Cobro_Prestamo> Cobro_Prestamo { get; set; }
        public virtual ICollection<Pago> Pago { get; set; }
        public virtual ICollection<Prestamo> Prestamo { get; set; }
    }
}