using MPCAdministrator.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MPCAdministrator.ContextoDB
{
    public class MPCContext : DbContext
    {
        public MPCContext() : base("MPCContext")
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Cobro> Cobros { get; set; }
        public DbSet<Cobro_Prestamo> Cobros_Prestamos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}