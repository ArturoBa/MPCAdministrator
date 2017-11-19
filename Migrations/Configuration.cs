namespace MPCAdministrator.Migrations
{
    using MPCAdministrator.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MPCAdministrator.ContextoDB.MPCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MPCAdministrator.ContextoDB.MPCContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var tutores = new List<Tutor>
            {
                new Tutor{Cedula=00101010101, Nombre="Mariela", Apellido="Gomez", Nacionalidad=Pais.Dominicana, Telefono=8091111111 },
                new Tutor{Cedula=00101010102, Nombre="Diana", Apellido="Montero", Nacionalidad=Pais.Dominicana, Telefono=8092222222 },
                new Tutor{Cedula=00101010103, Nombre="Juan", Apellido="Castillo", Nacionalidad=Pais.Dominicana, Telefono=8093333333 },
                new Tutor{Cedula=00101010104, Nombre="Daniel", Apellido="Henriquez", Nacionalidad=Pais.Dominicana, Telefono=8094444444 },
                new Tutor{Cedula=00101010105, Nombre="Fabrizio", Apellido="Peña", Nacionalidad=Pais.Dominicana, Telefono=8095555555 },
                new Tutor{Cedula=00101010106, Nombre="Adriela", Apellido="Berroa", Nacionalidad=Pais.Dominicana, Telefono=8096666666 }
            };

            tutores.ForEach(d => context.Tutores.AddOrUpdate(d));
            context.SaveChanges();

             var estudiantes = new List<Estudiante>
             {
                 new Estudiante{ Nombre="Amanda", Apellido="Gomez", Nacionalidad= Pais.Dominicana, Colegio_Anterior="Ninguno",
                                 Curso = Curso.Tercero, Sexo = Sexo.Femenino, TutorID=1 },
                 new Estudiante{ Nombre="Alisha", Apellido="Montero", Nacionalidad=Pais.Dominicana, Colegio_Anterior="Ninguno",
                                 Curso = Curso.Tercero, Sexo = Sexo.Femenino, TutorID= 2 },
                 new Estudiante{ Nombre="Diego", Apellido="Castillo", Nacionalidad= Pais.Dominicana, Colegio_Anterior="ATB",
                                 Curso = Curso.Tercero, Sexo = Sexo.Masculino, TutorID=3 },
                 new Estudiante{ Nombre="Josues", Apellido="Henriquez", Nacionalidad=Pais.Dominicana, Colegio_Anterior="Ninguno",
                                 Curso = Curso.Tercero, Sexo = Sexo.Masculino, TutorID=4 },
                 new Estudiante{ Nombre="Lucas", Apellido="Peña", Nacionalidad= Pais.Dominicana, Colegio_Anterior="Ninguno",
                                 Curso = Curso.Segundo, Sexo = Sexo.Masculino, TutorID=5 },
                 new Estudiante{ Nombre="Ambar", Apellido="Berroa", Nacionalidad=Pais.Dominicana, Colegio_Anterior="Ninguno",
                                 Curso = Curso.Segundo, Sexo = Sexo.Femenino, TutorID=6 }
             };
            
             estudiantes.ForEach(d => context.Estudiantes.AddOrUpdate(d));
             context.SaveChanges();

            var empleados = new List<Empleado>
            {
                new Empleado{ Cedula=00112345670 ,Nombre="Ivelisse", Apellido="Concepcion", Nacionalidad=Pais.Dominicana, Telefono=8095446969, FechaContratacion= DateTime.Parse("01/07/1994") },
                new Empleado{ Cedula=00112345681 ,Nombre="Ramona", Apellido="Garcia", Nacionalidad=Pais.Dominicana, Telefono=8095447070, FechaContratacion= DateTime.Parse("12/01/1995") },
                new Empleado{ Cedula=00112345692 ,Nombre="Enerilda", Apellido="Martinez", Nacionalidad=Pais.Dominicana, Telefono=8095547284, FechaContratacion= DateTime.Parse("07/07/1999") },
                new Empleado{ Cedula=00114345675 ,Nombre="Ruth", Apellido="King", Nacionalidad=Pais.Dominicana, Telefono=8095667894, FechaContratacion= DateTime.Parse("12/07/2016") },
                new Empleado{ Cedula=00111345662 ,Nombre="Laura", Apellido="Roma", Nacionalidad=Pais.Dominicana, Telefono=8092874495, FechaContratacion= DateTime.Parse("09/01/2006") },
                new Empleado{ Cedula=00652345741 ,Nombre="Anny", Apellido="Cespedes", Nacionalidad=Pais.Dominicana, Telefono=8298775412, FechaContratacion= DateTime.Parse("04/05/2016") }
            };

            empleados.ForEach(d => context.Empleados.AddOrUpdate(d));
            context.SaveChanges();

            var prestamos = new List<Prestamo>
            {
                new Prestamo{ EmpleadoID=1, Monto=3540.60, Descripcion="Por concepto de graduacion de la universidad", Fecha_Prestamo= DateTime.Now.Date },
                new Prestamo{ EmpleadoID=2, Monto=1200.00, Descripcion="Por concepto de pago del colegio de la hija", Fecha_Prestamo= DateTime.Now.Date },
                new Prestamo{ EmpleadoID=3, Monto=960.71, Descripcion="Por concepto de tapizado de muebles en su casa", Fecha_Prestamo= DateTime.Now.Date }
            };

            prestamos.ForEach(d => context.Prestamos.AddOrUpdate(d));
            context.SaveChanges();

            var cobros = new List<Cobro>
            {
                new Cobro{ TutorID=4, Fecha_Cobro=DateTime.Now.Date, Monto=5500.56 },
                new Cobro{ TutorID=6, Fecha_Cobro=DateTime.Now.Date, Monto=6700.00 },
                new Cobro{ TutorID=1, Fecha_Cobro=DateTime.Now.Date, Monto=4700.36 },
                new Cobro{ TutorID=2, Fecha_Cobro=DateTime.Now.Date, Monto=5622.10 },
                new Cobro{ TutorID=3, Fecha_Cobro=DateTime.Now.Date, Monto=8050.70 },
                new Cobro{ TutorID=5, Fecha_Cobro=DateTime.Now.Date, Monto=15800.00 }
            };

            cobros.ForEach(d => context.Cobros.AddOrUpdate(d));
            context.SaveChanges();

            var cobrosP = new List<Cobro_Prestamo>
            {
                new Cobro_Prestamo{ EmpleadoID=1, PrestamoID=1, Fecha_Cobro_Prestamo=DateTime.Now.Date, Monto=540.00 },
                new Cobro_Prestamo{ EmpleadoID=2, PrestamoID=2, Fecha_Cobro_Prestamo=DateTime.Now.Date, Monto=600.00 },
                new Cobro_Prestamo{ EmpleadoID=3, PrestamoID=3, Fecha_Cobro_Prestamo=DateTime.Now.Date, Monto=100.00 }
            };

            cobrosP.ForEach(d => context.Cobros_Prestamos.AddOrUpdate(d));
            context.SaveChanges();

            var pagos = new List<Pago>
            {
                new Pago{ EmpleadoID=1, Monto= 10000.00, Descripcion="Sueldo mensual", Fecha_Pago=DateTime.Now.Date },
                new Pago{ EmpleadoID=2, Monto= 12200.00, Descripcion="Sueldo mensual", Fecha_Pago=DateTime.Now.Date },
                new Pago{ EmpleadoID=3, Monto= 9800.00, Descripcion="Sueldo mensual", Fecha_Pago=DateTime.Now.Date },
                new Pago{ EmpleadoID=4, Monto= 5400.00, Descripcion="Sueldo mensual", Fecha_Pago=DateTime.Now.Date },
                new Pago{ EmpleadoID=5, Monto= 5200.00, Descripcion="Sueldo mensual", Fecha_Pago=DateTime.Now.Date },
                new Pago{ EmpleadoID=6, Monto= 2400.00, Descripcion="Sueldo mensual", Fecha_Pago=DateTime.Now.Date }
            };
            
            pagos.ForEach(d => context.Pagos.AddOrUpdate(d));
            context.SaveChanges();
        }
    }
}
