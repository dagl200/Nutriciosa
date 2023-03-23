using Asp___Angular_2.Model;
using Asp___Angular_2.Data;
using Microsoft.EntityFrameworkCore;

namespace Asp___Angular_2.Services
{
    public class EmpleadoService
    {
        private readonly EmpleadoContext _context;

        public EmpleadoService(EmpleadoContext context) 
        { 
        
            _context = context;
        
        }

        public IEnumerable<Empleado> GetAll()
        {
            return _context.Empleados
                .AsNoTracking()
                .ToList();
        }       

            public IEnumerable<Num_telefono> GetTel()
        {
            return _context.Num_telefonos
                .AsNoTracking()
                .ToList();
        }       
    public Empleado? GetById(int id)
    {
        return _context.Empleados
        .AsNoTracking()
        //.Include(p =>p.TelefonoId)
        .SingleOrDefault(p => p.Id == id);
    }

    public Num_telefono? GetTelId(int id){
        return _context.Num_telefonos
        .AsNoTracking()
        .SingleOrDefault(p => p.TelefonoId == id);
    }

        public Num_telefono? CreateTel(Num_telefono newTelefono)
    {
        _context.Num_telefonos.Add(newTelefono);
        _context.SaveChanges();

        return newTelefono;
    }

        public void DeleteTel(int id)
    {
        var TelefonoToDelete = _context.Num_telefonos.Find(id);
        if (TelefonoToDelete is not null){
            _context.Num_telefonos.Remove(TelefonoToDelete);
            _context.SaveChanges();
        }
    }
    public Empleado? Create(Empleado newEmpleado)
    {
        _context.Empleados.Add(newEmpleado);
        _context.SaveChanges();

        return newEmpleado;
    }

    public void DeleteById(int id)
    {
        var EmpleadoToDelete = _context.Empleados.Find(id);
        if (EmpleadoToDelete is not null){
            _context.Empleados.Remove(EmpleadoToDelete);
            _context.SaveChanges();
        }
    }

    }
}