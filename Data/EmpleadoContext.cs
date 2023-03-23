using Microsoft.EntityFrameworkCore;
using Asp___Angular_2.Model;

namespace Asp___Angular_2.Data
{
    public class EmpleadoContext:DbContext
    {
        public string DbPath { get; }

        public EmpleadoContext(DbContextOptions<EmpleadoContext> options) : base(options)
        { 
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "empleados.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Empleado> Empleados => Set<Empleado>();
        public DbSet<Num_telefono> Num_telefonos => Set<Num_telefono>();
    }
}
