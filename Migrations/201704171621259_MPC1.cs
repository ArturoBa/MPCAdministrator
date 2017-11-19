namespace MPCAdministrator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MPC1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cobro",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Monto = c.Double(nullable: false),
                        TutorID = c.Int(nullable: false),
                        Fecha_Cobro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tutor", t => t.TutorID)
                .Index(t => t.TutorID);
            
            CreateTable(
                "dbo.Tutor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Cedula = c.Int(nullable: false),
                        Nacionalidad = c.Int(nullable: false),
                        Telefono = c.Long(nullable: false),
                        TelefonoAlternativo = c.Long(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Estudiante",
                c => new
                    {
                        TutorID = c.Int(nullable: false),
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Nacionalidad = c.Int(nullable: false),
                        Colegio_Anterior = c.String(),
                        Sexo = c.Int(nullable: false),
                        Curso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TutorID)
                .ForeignKey("dbo.Tutor", t => t.TutorID)
                .Index(t => t.TutorID);
            
            CreateTable(
                "dbo.Cobro_Prestamo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PrestamoID = c.Int(nullable: false),
                        EmpleadoID = c.Int(nullable: false),
                        Monto = c.Double(nullable: false),
                        Fecha_Cobro_Prestamo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoID)
                .ForeignKey("dbo.Prestamo", t => t.PrestamoID)
                .Index(t => t.PrestamoID)
                .Index(t => t.EmpleadoID);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Cedula = c.Int(nullable: false),
                        Nacionalidad = c.Int(nullable: false),
                        Telefono = c.Long(nullable: false),
                        FechaContratacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Pago",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Monto = c.Double(nullable: false),
                        EmpleadoID = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Fecha_Pago = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoID)
                .Index(t => t.EmpleadoID);
            
            CreateTable(
                "dbo.Prestamo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmpleadoID = c.Int(nullable: false),
                        Monto = c.Double(nullable: false),
                        Fecha_Prestamo = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoID)
                .Index(t => t.EmpleadoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prestamo", "EmpleadoID", "dbo.Empleado");
            DropForeignKey("dbo.Cobro_Prestamo", "PrestamoID", "dbo.Prestamo");
            DropForeignKey("dbo.Pago", "EmpleadoID", "dbo.Empleado");
            DropForeignKey("dbo.Cobro_Prestamo", "EmpleadoID", "dbo.Empleado");
            DropForeignKey("dbo.Cobro", "TutorID", "dbo.Tutor");
            DropForeignKey("dbo.Estudiante", "TutorID", "dbo.Tutor");
            DropIndex("dbo.Prestamo", new[] { "EmpleadoID" });
            DropIndex("dbo.Pago", new[] { "EmpleadoID" });
            DropIndex("dbo.Cobro_Prestamo", new[] { "EmpleadoID" });
            DropIndex("dbo.Cobro_Prestamo", new[] { "PrestamoID" });
            DropIndex("dbo.Estudiante", new[] { "TutorID" });
            DropIndex("dbo.Cobro", new[] { "TutorID" });
            DropTable("dbo.Prestamo");
            DropTable("dbo.Pago");
            DropTable("dbo.Empleado");
            DropTable("dbo.Cobro_Prestamo");
            DropTable("dbo.Estudiante");
            DropTable("dbo.Tutor");
            DropTable("dbo.Cobro");
        }
    }
}
