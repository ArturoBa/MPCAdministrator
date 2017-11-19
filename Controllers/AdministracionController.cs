using MPCAdministrator.ContextoDB;
using MPCAdministrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace MPCAdministrator.Controllers
{
    public class AdministracionController : Controller
    {
        private MPCContext db = new MPCContext();

        // GET: Administracion
        public ActionResult Index()
        {
            var empleados = db.Empleados.Include(z => z.Cobro_Prestamo).Include(z => z.Prestamo).Include(z => z.Pago);
            return View(empleados.ToList());
        }

        [HttpGet]
        public ActionResult NEmpleado()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NEmpleado([Bind(Include ="Nombre,Apellido,Cedula,Nacionalidad,FechaContratacion,Telefono")]
                                        Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.Empleados.Add(empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empleado);
        }

        [HttpGet]
        public ActionResult Detalles(int? id)
        {
            //Por si un freco se pone a poner ID a su gusto
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null) { return RedirectToAction("Index"); }
            if (id == null) { return RedirectToAction("Index"); }

            return View(empleado);
        }
    }
}